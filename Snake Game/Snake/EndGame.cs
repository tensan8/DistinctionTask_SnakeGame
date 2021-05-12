using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class EndGame : Form
    {
        private WMPLib.WindowsMediaPlayer buttonSfx = new WMPLib.WindowsMediaPlayer();

        public EndGame(int latestScore)
        {
            InitializeComponent();
            buttonSfx.URL = "sounds/button.wav";
            back_button.MouseEnter += OnMouseEnterButton;
            back_button.MouseLeave += OnMouseLeaveButton;

            latest_score_label.Text = "Score: " + latestScore;
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
    }
}
