namespace snake
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            txtPass = new TextBox();
            btnCancel = new Button();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(168, 57);
            label1.Name = "label1";
            label1.Size = new Size(176, 46);
            label1.TabIndex = 0;
            label1.Text = "SNAKE.IO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(16, 186);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(16, 250);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(128, 179);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(253, 27);
            txtEmail.TabIndex = 3;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(128, 247);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(253, 27);
            txtPass.TabIndex = 4;
            txtPass.UseSystemPasswordChar = true;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.Location = new Point(128, 328);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(287, 328);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2023_07_12_125621;
            pictureBox1.Location = new Point(429, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(498, 426);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogin);
            Controls.Add(btnCancel);
            Controls.Add(txtPass);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtEmail;
        private TextBox txtPass;
        private Button btnCancel;
        private Button btnLogin;
        private PictureBox pictureBox1;
    }
}