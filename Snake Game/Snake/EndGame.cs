using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.Drawing.Text;

namespace Snake
{
    public partial class EndGame : Form
    {
        private WMPLib.WindowsMediaPlayer buttonSfx = new WMPLib.WindowsMediaPlayer();
        private SoundPlayer bgMusic = new SoundPlayer("sounds/ending.wav");

        public EndGame(int latestScore)
        {
            InitializeComponent();

            PrivateFontCollection privateFontCollection = new PrivateFontCollection();
            privateFontCollection.AddFontFile("fonts/arcadeclassic.ttf");

            back_button.Font = new Font(privateFontCollection.Families[0], 28, FontStyle.Regular);

            buttonSfx.URL = "sounds/button.wav";
            bgMusic.PlayLooping();

            back_button.MouseEnter += OnMouseEnterButton;
            back_button.MouseLeave += OnMouseLeaveButton;

            latest_score_label.Text = "Score: " + latestScore;

            ScoreBoard score = new ScoreBoard();
            score.SaveScore(latestScore);

            latest_score_label.Font = new Font(privateFontCollection.Families[0], 28, FontStyle.Regular);

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

        private void back_button_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.ShowDialog();
        }

        private void EndGame_Load(object sender, EventArgs e)
        {

        }

        private void latest_score_label_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
