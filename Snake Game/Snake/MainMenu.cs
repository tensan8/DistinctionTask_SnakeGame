using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.Drawing.Text;

namespace Snake
{
    public partial class MainMenu : Form
    {
        private SoundPlayer opening_music = new SoundPlayer("sounds/main_menu.wav");
        private WMPLib.WindowsMediaPlayer buttonSfx = new WMPLib.WindowsMediaPlayer();


        public MainMenu()
        {
            InitializeComponent();

            PrivateFontCollection privateFontCollection = new PrivateFontCollection();
            privateFontCollection.AddFontFile("fonts/arcadeclassic.ttf");
            privateFontCollection.AddFontFile("fonts/fipps.otf");

            start_button.Font = new Font(privateFontCollection.Families[0], 28, FontStyle.Regular);
            scoreboard_button.Font = new Font(privateFontCollection.Families[0], 28, FontStyle.Regular);
            exit_button.Font = new Font(privateFontCollection.Families[0], 28, FontStyle.Regular);
            Snake_title.Font = new Font(privateFontCollection.Families[1], 34, FontStyle.Regular);
            Time_title.Font = new Font(privateFontCollection.Families[1], 34, FontStyle.Regular);

            start_button.MouseEnter += OnMouseEnterButton;
            scoreboard_button.MouseEnter += OnMouseEnterButton;
            exit_button.MouseEnter += OnMouseEnterButton;

            start_button.MouseLeave += OnMouseLeaveButton;
            scoreboard_button.MouseLeave += OnMouseLeaveButton;
            exit_button.MouseLeave += OnMouseLeaveButton;

            opening_music.PlayLooping();

            buttonSfx.URL = "sounds/button.wav";

            Snake_title.BackColor = System.Drawing.Color.Transparent;
        }

        private void OnMouseEnterButton(object sender, EventArgs e)
        {
            Button chosenButton = (Button)sender;
            chosenButton.ForeColor = Color.DarkRed;
            buttonSfx.controls.play();
        }

        private void OnMouseLeaveButton(object sender, EventArgs e)
        {
            Button chosenButton = (Button)sender;
            chosenButton.ForeColor = SystemColors.ControlLightLight;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void Snake_anim(object sender, EventArgs e)
        {

        }

        private void Button_scoreboard_clicked(object sender, EventArgs e)
        {

        }

        private void start_button_Click(object sender, EventArgs e)
        {
            Snake snake = new Snake();
            snake.ShowDialog();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Snake_title_Click(object sender, EventArgs e)
        {

        }

        private void scoreboard_button_Click(object sender, EventArgs e)
        {
            ScoreBoard sb = new ScoreBoard();
            sb.ShowDialog();
        }
    }
}
