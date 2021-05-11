
using System;

namespace Snake
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.start_button = new System.Windows.Forms.Button();
            this.scoreboard_button = new System.Windows.Forms.Button();
            this.snakeGIF = new System.Windows.Forms.PictureBox();
            this.exit_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.snakeGIF)).BeginInit();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.Color.Transparent;
            this.start_button.FlatAppearance.BorderSize = 0;
            this.start_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.start_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.start_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_button.Font = new System.Drawing.Font("ArcadeClassic", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.start_button.Location = new System.Drawing.Point(394, 247);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(189, 71);
            this.start_button.TabIndex = 2;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = false;
            // 
            // scoreboard_button
            // 
            this.scoreboard_button.BackColor = System.Drawing.Color.Transparent;
            this.scoreboard_button.FlatAppearance.BorderSize = 0;
            this.scoreboard_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.scoreboard_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.scoreboard_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreboard_button.Font = new System.Drawing.Font("ArcadeClassic", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreboard_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.scoreboard_button.Location = new System.Drawing.Point(317, 324);
            this.scoreboard_button.Name = "scoreboard_button";
            this.scoreboard_button.Size = new System.Drawing.Size(347, 68);
            this.scoreboard_button.TabIndex = 3;
            this.scoreboard_button.Text = "Scoreboard";
            this.scoreboard_button.UseVisualStyleBackColor = false;
            // 
            // snakeGIF
            // 
            this.snakeGIF.Image = global::Snake.Properties.Resources.snake_anim;
            this.snakeGIF.Location = new System.Drawing.Point(224, -63);
            this.snakeGIF.Name = "snakeGIF";
            this.snakeGIF.Size = new System.Drawing.Size(523, 363);
            this.snakeGIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.snakeGIF.TabIndex = 0;
            this.snakeGIF.TabStop = false;
            this.snakeGIF.Click += new System.EventHandler(this.Snake_anim);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.Transparent;
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exit_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("ArcadeClassic", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exit_button.Location = new System.Drawing.Point(403, 398);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(166, 62);
            this.exit_button.TabIndex = 4;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = false;
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(999, 501);
            this.ControlBox = false;
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.scoreboard_button);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.snakeGIF);
            this.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake Time";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.snakeGIF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox snakeGIF;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button scoreboard_button;
        private System.Windows.Forms.Button exit_button;
        private EventHandler button_start;
        private EventHandler Button_scoreboard;
    }
}