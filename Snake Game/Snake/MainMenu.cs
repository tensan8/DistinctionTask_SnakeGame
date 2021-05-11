using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Snake
{
    public partial class MainMenu : Form
    {
        private SoundPlayer opening_music = new SoundPlayer("sounds/main_menu.wav");

        public MainMenu()
        {
            InitializeComponent();
            start_button.MouseEnter += OnMouseEnterButton;
            scoreboard_button.MouseEnter += OnMouseEnterButton;
            exit_button.MouseEnter += OnMouseEnterButton;
            
            start_button.MouseLeave += OnMouseLeaveButton;
            scoreboard_button.MouseLeave += OnMouseLeaveButton;
            exit_button.MouseLeave += OnMouseLeaveButton;

            opening_music.PlayLooping();
        }

        private void OnMouseEnterButton(object sender, EventArgs e)
        {
            Button chosenButton = (Button)sender;
            chosenButton.ForeColor = Color.DarkRed;
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

        private void Button_start_clicked(object sender, EventArgs e)
        {

        }

        private void Button_scoreboard_clicked(object sender, EventArgs e)
        {

        }

        private void Button_exit_clicked(object sender, EventArgs e)
        {

        }
    }
}
