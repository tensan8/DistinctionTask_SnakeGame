
namespace Snake
{
    partial class EndGame
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
            this.back_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.latest_score_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.Transparent;
            this.back_button.FlatAppearance.BorderSize = 0;
            this.back_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.back_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.back_button.Location = new System.Drawing.Point(626, 549);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(195, 69);
            this.back_button.TabIndex = 0;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Snake.Properties.Resources.die_snake;
            this.pictureBox1.Location = new System.Drawing.Point(434, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(522, 400);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // latest_score_label
            // 
            this.latest_score_label.AutoSize = true;
            this.latest_score_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latest_score_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.latest_score_label.Location = new System.Drawing.Point(582, 494);
            this.latest_score_label.Name = "latest_score_label";
            this.latest_score_label.Size = new System.Drawing.Size(175, 59);
            this.latest_score_label.TabIndex = 2;
            this.latest_score_label.Text = "Score:";
            this.latest_score_label.Click += new System.EventHandler(this.latest_score_label_Click);
            // 
            // EndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1500, 769);
            this.Controls.Add(this.latest_score_label);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EndGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EndGame";
            this.Load += new System.EventHandler(this.EndGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label latest_score_label;
    }
}