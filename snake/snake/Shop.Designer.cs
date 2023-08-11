namespace snake
{
    partial class Shop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shop));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            shiedNum = new NumericUpDown();
            label6 = new Label();
            speedNum = new NumericUpDown();
            heartNum = new NumericUpDown();
            btnBuyShield = new Button();
            btnBuySpeed = new Button();
            btnBuyHeart = new Button();
            button3 = new Button();
            btnAdvertising = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shiedNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)speedNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)heartNum).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(376, 37);
            label1.Name = "label1";
            label1.Size = new Size(116, 56);
            label1.TabIndex = 0;
            label1.Text = "Shop";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(37, 118);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "Money";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.Location = new Point(116, 115);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.shield;
            pictureBox1.Location = new Point(128, 187);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(396, 187);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(113, 103);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(663, 187);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(113, 103);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(139, 310);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 6;
            label3.Text = "Price: 100$";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(405, 310);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 7;
            label4.Text = "Price: 100$";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(672, 310);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 8;
            label5.Text = "Price: 100$";
            // 
            // shiedNum
            // 
            shiedNum.Location = new Point(139, 346);
            shiedNum.Name = "shiedNum";
            shiedNum.Size = new Size(78, 27);
            shiedNum.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(37, 348);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 10;
            label6.Text = "Quantity";
            // 
            // speedNum
            // 
            speedNum.Location = new Point(405, 348);
            speedNum.Name = "speedNum";
            speedNum.Size = new Size(88, 27);
            speedNum.TabIndex = 11;
            // 
            // heartNum
            // 
            heartNum.Location = new Point(672, 348);
            heartNum.Name = "heartNum";
            heartNum.Size = new Size(88, 27);
            heartNum.TabIndex = 12;
            // 
            // btnBuyShield
            // 
            btnBuyShield.Location = new Point(132, 394);
            btnBuyShield.Name = "btnBuyShield";
            btnBuyShield.Size = new Size(94, 29);
            btnBuyShield.TabIndex = 13;
            btnBuyShield.Text = "BUY";
            btnBuyShield.UseVisualStyleBackColor = true;
            btnBuyShield.Click += btnBuyShield_Click;
            // 
            // btnBuySpeed
            // 
            btnBuySpeed.Location = new Point(396, 394);
            btnBuySpeed.Name = "btnBuySpeed";
            btnBuySpeed.Size = new Size(94, 29);
            btnBuySpeed.TabIndex = 14;
            btnBuySpeed.Text = "BUY";
            btnBuySpeed.UseVisualStyleBackColor = true;
            btnBuySpeed.Click += btnBuySpeed_Click;
            // 
            // btnBuyHeart
            // 
            btnBuyHeart.Location = new Point(666, 394);
            btnBuyHeart.Name = "btnBuyHeart";
            btnBuyHeart.Size = new Size(94, 29);
            btnBuyHeart.TabIndex = 15;
            btnBuyHeart.Text = "BUY";
            btnBuyHeart.UseVisualStyleBackColor = true;
            btnBuyHeart.Click += btnBuyHeart_Click;
            // 
            // button3
            // 
            button3.Location = new Point(780, 471);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 16;
            button3.Text = "BACK";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnAdvertising
            // 
            btnAdvertising.Location = new Point(298, 118);
            btnAdvertising.Name = "btnAdvertising";
            btnAdvertising.Size = new Size(153, 29);
            btnAdvertising.TabIndex = 17;
            btnAdvertising.Text = "More Money ?";
            btnAdvertising.UseVisualStyleBackColor = true;
            btnAdvertising.Click += btnAdvertising_Click;
            // 
            // Shop
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 534);
            Controls.Add(btnAdvertising);
            Controls.Add(button3);
            Controls.Add(btnBuyHeart);
            Controls.Add(btnBuySpeed);
            Controls.Add(btnBuyShield);
            Controls.Add(heartNum);
            Controls.Add(speedNum);
            Controls.Add(label6);
            Controls.Add(shiedNum);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Shop";
            Text = "Shop";
            Load += Shop_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)shiedNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)speedNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)heartNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown shiedNum;
        private Label label6;
        private NumericUpDown speedNum;
        private NumericUpDown heartNum;
        private Button btnBuyShield;
        private Button btnBuySpeed;
        private Button btnBuyHeart;
        private Button button3;
        private Button btnAdvertising;
    }
}