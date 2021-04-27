namespace Snake
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Gcanvas = new System.Windows.Forms.PictureBox();
            this.score = new System.Windows.Forms.Label();
            this.lblscore = new System.Windows.Forms.Label();
            this.gTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblgameover = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.nmbSpeed = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Gcanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // Gcanvas
            // 
            this.Gcanvas.BackColor = System.Drawing.SystemColors.GrayText;
            this.Gcanvas.Location = new System.Drawing.Point(35, 31);
            this.Gcanvas.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Gcanvas.Name = "Gcanvas";
            this.Gcanvas.Size = new System.Drawing.Size(1677, 1374);
            this.Gcanvas.TabIndex = 0;
            this.Gcanvas.TabStop = false;
            this.Gcanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Gcanvas_paint);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(1773, 50);
            this.score.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(266, 83);
            this.score.TabIndex = 1;
            this.score.Text = "Score :";
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore.Location = new System.Drawing.Point(2312, 55);
            this.lblscore.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(0, 83);
            this.lblscore.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 32);
            this.label2.TabIndex = 3;
            // 
            // lblgameover
            // 
            this.lblgameover.AutoSize = true;
            this.lblgameover.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgameover.Location = new System.Drawing.Point(1773, 1133);
            this.lblgameover.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblgameover.Name = "lblgameover";
            this.lblgameover.Size = new System.Drawing.Size(505, 76);
            this.lblgameover.TabIndex = 4;
            this.lblgameover.Text = "LabelGameOver";
            this.lblgameover.Visible = false;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(2008, 315);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(106, 32);
            this.lblSpeed.TabIndex = 5;
            this.lblSpeed.Text = "Speed:";
            // 
            // nmbSpeed
            // 
            this.nmbSpeed.Location = new System.Drawing.Point(2120, 309);
            this.nmbSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmbSpeed.Name = "nmbSpeed";
            this.nmbSpeed.Size = new System.Drawing.Size(120, 38);
            this.nmbSpeed.TabIndex = 6;
            this.nmbSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(2014, 489);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(226, 75);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(2008, 373);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(247, 32);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "(1-100, default 20)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(2704, 1414);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.nmbSpeed);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblgameover);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.score);
            this.Controls.Add(this.Gcanvas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Snake in C#";
            this.TransparencyKey = System.Drawing.SystemColors.ControlDarkDark;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Gcanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Gcanvas;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.Timer gTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblgameover;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.NumericUpDown nmbSpeed;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblDescription;
    }
}

