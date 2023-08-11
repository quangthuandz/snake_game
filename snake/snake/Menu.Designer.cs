namespace snake
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            label1 = new Label();
            btnNormal = new Button();
            btnMedium = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            label6 = new Label();
            lbScoreSpecial = new Label();
            pictureBox3 = new PictureBox();
            lbGame1HighScore = new Label();
            lbGame2HighScore = new Label();
            lbGame3HighScore = new Label();
            button2 = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtShi = new TextBox();
            txtSp = new TextBox();
            txtLive = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(311, 29);
            label1.Name = "label1";
            label1.Size = new Size(176, 46);
            label1.TabIndex = 0;
            label1.Text = "SNAKE.IO";
            // 
            // btnNormal
            // 
            btnNormal.BackColor = Color.Lime;
            btnNormal.Location = new Point(62, 383);
            btnNormal.Name = "btnNormal";
            btnNormal.Size = new Size(94, 29);
            btnNormal.TabIndex = 1;
            btnNormal.Text = "Go";
            btnNormal.UseVisualStyleBackColor = false;
            btnNormal.Click += btnNormal_Click;
            // 
            // btnMedium
            // 
            btnMedium.BackColor = Color.Lime;
            btnMedium.Location = new Point(348, 383);
            btnMedium.Name = "btnMedium";
            btnMedium.Size = new Size(94, 29);
            btnMedium.TabIndex = 2;
            btnMedium.Text = "Go";
            btnMedium.UseVisualStyleBackColor = false;
            btnMedium.Click += btnMedium_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2023_07_12_103145;
            pictureBox1.Location = new Point(12, 161);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 350);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 4;
            label2.Text = "Your Score: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(348, 350);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 5;
            label3.Text = "Your Score: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Coral;
            label4.Location = new Point(86, 119);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 6;
            label4.Text = "NORMAL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Coral;
            label5.Location = new Point(369, 119);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 7;
            label5.Text = "MEDIUM";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(286, 161);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(216, 145);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(625, 383);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Go";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Coral;
            label6.Location = new Point(642, 119);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 10;
            label6.Text = "SPECIAL";
            // 
            // lbScoreSpecial
            // 
            lbScoreSpecial.AutoSize = true;
            lbScoreSpecial.Location = new Point(630, 350);
            lbScoreSpecial.Name = "lbScoreSpecial";
            lbScoreSpecial.Size = new Size(86, 20);
            lbScoreSpecial.TabIndex = 11;
            lbScoreSpecial.Text = "Your Score: ";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(563, 161);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(216, 145);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // lbGame1HighScore
            // 
            lbGame1HighScore.AutoSize = true;
            lbGame1HighScore.Location = new Point(62, 320);
            lbGame1HighScore.Name = "lbGame1HighScore";
            lbGame1HighScore.Size = new Size(108, 20);
            lbGame1HighScore.TabIndex = 13;
            lbGame1HighScore.Text = "Highest Score: ";
            // 
            // lbGame2HighScore
            // 
            lbGame2HighScore.AutoSize = true;
            lbGame2HighScore.Location = new Point(348, 320);
            lbGame2HighScore.Name = "lbGame2HighScore";
            lbGame2HighScore.Size = new Size(108, 20);
            lbGame2HighScore.TabIndex = 14;
            lbGame2HighScore.Text = "Highest Score: ";
            // 
            // lbGame3HighScore
            // 
            lbGame3HighScore.AutoSize = true;
            lbGame3HighScore.Location = new Point(630, 320);
            lbGame3HighScore.Name = "lbGame3HighScore";
            lbGame3HighScore.Size = new Size(108, 20);
            lbGame3HighScore.TabIndex = 15;
            lbGame3HighScore.Text = "Highest Score: ";
            // 
            // button2
            // 
            button2.Location = new Point(685, 45);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 16;
            button2.Text = "Shopping";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(179, 459);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 17;
            label7.Text = "Shield:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(348, 463);
            label8.Name = "label8";
            label8.Size = new Size(54, 20);
            label8.TabIndex = 18;
            label8.Text = "Speed:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(577, 459);
            label9.Name = "label9";
            label9.Size = new Size(42, 20);
            label9.TabIndex = 19;
            label9.Text = "Live: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(22, 454);
            label10.Name = "label10";
            label10.Size = new Size(95, 31);
            label10.TabIndex = 20;
            label10.Text = "POWER";
            // 
            // txtShi
            // 
            txtShi.BackColor = Color.Pink;
            txtShi.ForeColor = Color.Black;
            txtShi.Location = new Point(238, 456);
            txtShi.Name = "txtShi";
            txtShi.ReadOnly = true;
            txtShi.Size = new Size(71, 27);
            txtShi.TabIndex = 21;
            // 
            // txtSp
            // 
            txtSp.BackColor = Color.Pink;
            txtSp.Location = new Point(433, 456);
            txtSp.Name = "txtSp";
            txtSp.ReadOnly = true;
            txtSp.Size = new Size(79, 27);
            txtSp.TabIndex = 22;
            // 
            // txtLive
            // 
            txtLive.BackColor = Color.Pink;
            txtLive.Location = new Point(625, 456);
            txtLive.Name = "txtLive";
            txtLive.ReadOnly = true;
            txtLive.Size = new Size(79, 27);
            txtLive.TabIndex = 23;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 559);
            Controls.Add(txtLive);
            Controls.Add(txtSp);
            Controls.Add(txtShi);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(lbGame3HighScore);
            Controls.Add(lbGame2HighScore);
            Controls.Add(lbGame1HighScore);
            Controls.Add(pictureBox3);
            Controls.Add(lbScoreSpecial);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(btnMedium);
            Controls.Add(btnNormal);
            Controls.Add(label1);
            Name = "Menu";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnNormal;
        private Button btnMedium;
        private PictureBox pictureBox1;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Đường dẫn tới file ảnh
            string imagePath = "C:/Users/quang/OneDrive/Pictures/Ảnh chụp màn hình/snake.png";

            // Kiểm tra xem tệp ảnh có tồn tại hay không
            if (System.IO.File.Exists(imagePath))
            {
                // Tạo đối tượng Image từ tệp ảnh
                Image image = Image.FromFile(imagePath);

                // Hiển thị ảnh trong PictureBox
                pictureBox1.Image = image;
            }
            else
            {
                MessageBox.Show("Không tìm thấy tệp ảnh.");
            }
        }

        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox2;
        private Button button1;
        private Label label6;
        private Label lbScoreSpecial;
        private PictureBox pictureBox3;
        private Label lbGame1HighScore;
        private Label lbGame2HighScore;
        private Label lbGame3HighScore;
        private Button button2;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtShi;
        private TextBox txtSp;
        private TextBox txtLive;
    }
}