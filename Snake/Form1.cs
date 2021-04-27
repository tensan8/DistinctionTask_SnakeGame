using System;
using System.Collections.Generic;
using System.Drawing;//Brush
using System.Windows.Forms;

namespace Snake
{

    public partial class Form1 : Form
    {
        
        private List<CircleFood> Snake = new List<CircleFood>();
        private CircleFood food = new CircleFood();

        public Form1()
        {
            InitializeComponent();
            nmbSpeed.Value = 20;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            new Settings((int)nmbSpeed.Value);

            gTimer.Interval = 1000 / Settings.speed;
            gTimer.Tick += UpdateScreen;
            gTimer.Start();

            StartGame();
        }

        private void StartGame()
        {
            lblgameover.Visible = false;//Hide the game over message

            //New snake Object
            Snake.Clear();
            CircleFood head = new CircleFood { X = 10, Y = 5 };//Middle of the screen
            Snake.Add(head);//Create the head of the circle

            lblscore.Text = Settings.score.ToString();//0
            RandomFoodGeneration();
        }

        //Place random food object
        private void RandomFoodGeneration()
        {
            //Map size for prevent out map generation
            //CAN BE GLOBAL BECAUSE WE USE IT FREQUENTLY
            int max_XPosition = Gcanvas.Size.Width / Settings.width;
            int max_YPosition = Gcanvas.Size.Height / Settings.height;

            Random random = new Random();//Declaration of a Random object
            food = new CircleFood { X = random.Next(0, max_XPosition), Y = random.Next(0, max_YPosition) };
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            //Check if the game is not over
            if (Settings.gameOver)
            {
                //Enter is pressed start a new game
                if (Input.keyIsPressed(Keys.Enter))
                {
                    StartGame();
                }
            }
            //If the player still alive
            else
            {
                /*
                 For all direction we check if the new direction is different of the current one
                 if yes we can go to the new direction
                 */
                if (Input.keyIsPressed(Keys.Right) && Settings.direction != Direction.Left)
                    Settings.direction = Direction.Right;
                else if (Input.keyIsPressed(Keys.Left) && Settings.direction != Direction.Right)
                    Settings.direction = Direction.Left;
                else if (Input.keyIsPressed(Keys.Up) && Settings.direction != Direction.Down)
                    Settings.direction = Direction.Up;
                else if (Input.keyIsPressed(Keys.Down) && Settings.direction != Direction.Up)
                    Settings.direction = Direction.Down;

                MoveTheSnakeBody();
            }

         Gcanvas.Invalidate(); //For refresh the map
        }

        private void Gcanvas_paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics; //Choose the canvas

            if (!Settings.gameOver)
            {
                for (int i = 0; i < Snake.Count; i++)
                {
                    Brush snakeColour;

                    if (i == 0) //The first point is the head
                        snakeColour = Brushes.Black;
                    else
                        snakeColour = Brushes.White; //Rest of body

                    //Snake
                    canvas.FillEllipse(snakeColour, new Rectangle(Snake[i].X * Settings.width,Snake[i].Y * Settings.height, Settings.width, Settings.height));


                    //Food
                    canvas.FillEllipse(Brushes.Red, new Rectangle(food.X * Settings.width, food.Y * Settings.height, Settings.width, Settings.height));
                }
            }
            else
            {
                string gameOver = "GAME OVER \nYour Score is : " + Settings.score + "\nPress button to play again";
                lblgameover.Text = gameOver;
                lblgameover.Visible = true; //Show the game over message
            }
        }

        private void MoveTheSnakeBody()
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0) //Start a the head of the snake
                {
                    switch (Settings.direction)
                    {
                        case Direction.Right:
                            Snake[i].X++;
                            break;
                        case Direction.Left:
                            Snake[i].X--;
                            break;
                        case Direction.Up:
                            Snake[i].Y--;
                            break;
                        case Direction.Down:
                            Snake[i].Y++;
                            break;
                    }
                    
                    int max_XPosition = Gcanvas.Size.Width / Settings.width;
                    int max_YPosition = Gcanvas.Size.Height / Settings.height;

                    //Collision with the map limit
                    if (Snake[i].X < 0 || Snake[i].Y < 0 || Snake[i].X >= max_XPosition || Snake[i].Y >= max_YPosition)
                    {
                        Die();
                        //We can implement a new function for an infinite map
                    }

                    //Collision with the snake body
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X &&
                           Snake[i].Y == Snake[j].Y)
                        {
                            Die();
                        }
                    }

                    //Collision with the food
                    if (Snake[0].X == food.X && Snake[0].Y == food.Y)
                    {
                        EatFood();
                    }
                }

                else
                {
                    //Move the rest of the body
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true); //Button is pressed
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false); //Button is not pressed
        }

        private void EatFood()
        {
            //Add a new circle to the snake body
            CircleFood circle = new CircleFood
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };

            Snake.Add(circle);
            //Update and show the score
            Settings.score += Settings.points;
            lblscore.Text = Settings.score.ToString();

            //Generate a new random food on the map
            RandomFoodGeneration();
        }

        private void Die()
        {
            Settings.gameOver = true;
        }
    }
}