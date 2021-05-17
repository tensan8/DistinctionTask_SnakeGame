
namespace Snake
{
    partial class ScoreBoard
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
            this.Snake_title = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Snake_title
            // 
            this.Snake_title.AutoSize = true;
            this.Snake_title.BackColor = System.Drawing.Color.Transparent;
            this.Snake_title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Snake_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Snake_title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Snake_title.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Snake_title.Location = new System.Drawing.Point(72, 9);
            this.Snake_title.Name = "Snake_title";
            this.Snake_title.Size = new System.Drawing.Size(434, 82);
            this.Snake_title.TabIndex = 6;
            this.Snake_title.Text = "Score Board";
            this.Snake_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Snake_title.Click += new System.EventHandler(this.Snake_title_Click);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.score.Location = new System.Drawing.Point(168, 101);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(42, 37);
            this.score.TabIndex = 7;
            this.score.Text = "1.";
            this.score.Click += new System.EventHandler(this.label1_Click);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.Transparent;
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exit_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.ForeColor = System.Drawing.Color.DarkRed;
            this.exit_button.Location = new System.Drawing.Point(175, 340);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(166, 62);
            this.exit_button.TabIndex = 8;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // ScoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(565, 405);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.score);
            this.Controls.Add(this.Snake_title);
            this.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ScoreBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScoreBoard";
            this.Load += new System.EventHandler(this.ScoreBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Snake_title;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Button exit_button;
    }
}