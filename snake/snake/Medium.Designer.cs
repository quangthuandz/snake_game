namespace snake
{
    partial class Medium
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
            components = new System.ComponentModel.Container();
            startButton = new Button();
            snapButton = new Button();
            picCanvas = new PictureBox();
            txtScore = new Label();
            txtHighScore = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picCanvas).BeginInit();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.BackColor = Color.SkyBlue;
            startButton.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            startButton.Location = new Point(793, 18);
            startButton.Margin = new Padding(4, 5, 4, 5);
            startButton.Name = "startButton";
            startButton.Size = new Size(152, 86);
            startButton.TabIndex = 0;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += StartGame;
            // 
            // snapButton
            // 
            snapButton.BackColor = Color.Violet;
            snapButton.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            snapButton.Location = new Point(793, 236);
            snapButton.Margin = new Padding(4, 5, 4, 5);
            snapButton.Name = "snapButton";
            snapButton.Size = new Size(152, 86);
            snapButton.TabIndex = 0;
            snapButton.Text = "Back";
            snapButton.UseVisualStyleBackColor = false;
            snapButton.Click += TakeSnapShot;
            // 
            // picCanvas
            // 
            picCanvas.BackColor = Color.Silver;
            picCanvas.Location = new Point(12, 18);
            picCanvas.Margin = new Padding(4, 5, 4, 5);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(773, 644);
            picCanvas.TabIndex = 1;
            picCanvas.TabStop = false;
            picCanvas.Paint += UpdatePictureBoxGraphics;
            // 
            // txtScore
            // 
            txtScore.AutoSize = true;
            txtScore.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtScore.Location = new Point(793, 118);
            txtScore.Margin = new Padding(4, 0, 4, 0);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(94, 25);
            txtScore.TabIndex = 2;
            txtScore.Text = "Score: 0";
            // 
            // txtHighScore
            // 
            txtHighScore.AutoSize = true;
            txtHighScore.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtHighScore.Location = new Point(793, 170);
            txtHighScore.Margin = new Padding(4, 0, 4, 0);
            txtHighScore.Name = "txtHighScore";
            txtHighScore.Size = new Size(119, 25);
            txtHighScore.TabIndex = 2;
            txtHighScore.Text = "High Score";
            // 
            // gameTimer
            // 
            gameTimer.Interval = 50;
            gameTimer.Tick += GameTimerEvent;
            // 
            // Medium
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 1055);
            Controls.Add(txtHighScore);
            Controls.Add(txtScore);
            Controls.Add(picCanvas);
            Controls.Add(snapButton);
            Controls.Add(startButton);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Medium";
            Text = "Classic Snakes Game MOO ICT";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startButton;
        private Button snapButton;
        private PictureBox picCanvas;
        private Label txtScore;
        private Label txtHighScore;
        private System.Windows.Forms.Timer gameTimer;
    }
}