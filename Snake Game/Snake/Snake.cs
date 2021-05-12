using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Snake : Form
    {
        private int cols = 50, rows = 25, score = 0, dx = 0, dy = 0, front = 0, back = 0;
        private Piece[] snake = new Piece[1250];
        private List<int> available = new List<int>();
        private bool[,] visit;
        private SoundPlayer bgMusic = new SoundPlayer("sounds/ingame.wav");
        private WMPLib.WindowsMediaPlayer eatSfx = new WMPLib.WindowsMediaPlayer();
        int life = 3;


        Random rand = new Random();
        Timer timer = new Timer();

        public Snake()
        {
            InitializeComponent();
            intial();
            launchTimer();

        }

        private void launchTimer()
        {
            timer.Interval = 50;
            timer.Tick += move;
            timer.Start();
        }

        private void Snake_KeyDown(object sender, KeyEventArgs e)
        {
            int x = snake[front].Location.X, y = snake[front].Location.Y;
            dx = dy = 0;

            switch (e.KeyCode)
            {
                case Keys.Right:
                    dx = 20;
                    break;
                case Keys.Left:
                    dx = -20;
                    break;
                case Keys.Up:
                    dy = -20;
                    break;
                case Keys.Down:
                    dy = 20;
                    break;
            }
        }

        private void Snake_Load(object sender, EventArgs e)
        {

        }

        private void move(object sender, EventArgs e)
        {
            int x = snake[front].Location.X, y = snake[front].Location.Y;
            if( dx==0&&dy==0 )return;
            if(game_over(x + dx, y + dy)) 
            {
                timer.Stop();
                DialogResult dialog = MessageBox.Show("Game Over", "Back", MessageBoxButtons.OK);
                if(dialog == DialogResult.OK)
                {
                    EndGame end = new EndGame(score);
                    end.ShowDialog(); 
                }
                return;
            }
            if(collisionFood(x + dx, y + dy))
            {
                if(lblFood.BackColor == Color.Green)
                {
                    score += 20;
                }
                else if(lblFood.BackColor == Color.Blue)
                {
                    life += 1;
                }
                else
                {
                    score += 1;
                }
                lblLife.Text = "Life: " + life.ToString();
                lblScore.Text = "Score: " + score.ToString();
                if (hits((y + dy) / 20, (x + dx) / 20)) return;
                Piece head = new Piece(x + dx, y + dy);
                front = (front - 1 + 1250) % 1250;
                snake[front] = head;
                visit[head.Location.Y / 20, head.Location.X / 20] = true;
                Controls.Add(head);
                randomFood();
            }
            else
            {
                if(hits((y + dy) / 20, (x + dx) / 20))return;
                visit[snake[back].Location.Y / 20, snake[back].Location.X / 20] = false;
                front = (front - 1 + 1250) % 1250;
                snake[front] = snake[back];
                snake[front].Location = new Point(x + dx, y + dy);
                back = (back - 1 + 1250) % 1250;
                int new_locx=(x + dx)/20;
                int new_locy=(y+dy)/20;
                if(new_locx >= 0 & new_locx <= 50 & new_locy >= 0 & new_locy <= 25) 
                { 
                    visit[(y + dy) / 20, (x + dx) / 20] = true;
                }
            }
        }

        private void randomFood()
        {
            Random rand = new Random();
            int rand_index = rand.Next(3);
            Color[] colors = new Color[] { Color.Green, Color.Red, Color.Blue };
            available.Clear();
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    if (!visit[i, j]) available.Add(i * cols + j);
                         int idx = rand.Next(available.Count) % available.Count;
            lblFood.BackColor = colors[rand_index];
            lblFood.Left=(available[idx] * 20) % Width;
            lblFood.Top=(available[idx] * 20) / Width * 20;
        }

        private bool hits(int x, int y)
        {

            if (visit[x, y])
            {
                if (check_life())
                {
                    timer.Stop();
                    bgMusic.Stop();
                    DialogResult dialog = MessageBox.Show("Snake Hit his Body", "Back", MessageBoxButtons.OK);
                    if (dialog == DialogResult.OK)
                    {
                        EndGame end = new EndGame(score);
                        end.ShowDialog();
                    }
                    return true;
                }
                else
                { 
                    life -= 1;
                    lblLife.Text = "Life: " + life.ToString();
                }
            }
            return false;
        }

        private bool collisionFood(int x, int y)
        {
            if (x == lblFood.Location.X && y == lblFood.Location.Y)
            {
                eatSfx.controls.play();
                return true;
            }
            return false;
        }

        private bool check_life()
        {
            return life == 0;
        }
        private bool game_over(int x, int y)
        {
            if (x < 0 || y < 0 || x > 980 || y > 480)
            {
                bgMusic.Stop();
                return true;
            }
            return false;
        }

        private void intial()
        {
            visit = new bool[rows, cols];
            Piece head = new Piece((rand.Next() % cols) * 20, (rand.Next() % rows) * 20);
            lblFood.Location = new Point((rand.Next() % cols) * 20, (rand.Next() % rows) * 20);
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                {
                    visit[i, j] = false;
                    available.Add(i * cols + j);
                }
            visit[head.Location.Y / 20, head.Location.X / 20] = true;
            available.Remove(head.Location.Y / 20 * cols + head.Location.X / 20);
            Controls.Add(head); snake[front] = head;
            bgMusic.PlayLooping();
            eatSfx.URL = "sounds/eat_food.wav";
        }
    }
}
