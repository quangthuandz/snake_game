namespace snake
{
    partial class AdminMenu
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
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            textBox1 = new TextBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(842, 338);
            dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(113, 382);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(760, 382);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Users List";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 382);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 3;
            label1.Text = "Game Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 432);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 7;
            label2.Text = "Search Name";
            // 
            // button2
            // 
            button2.Location = new Point(611, 382);
            button2.Name = "button2";
            button2.Size = new Size(132, 29);
            button2.TabIndex = 8;
            button2.Text = "Export to File";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(113, 432);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(178, 27);
            textBox1.TabIndex = 9;
            // 
            // button3
            // 
            button3.Location = new Point(316, 432);
            button3.Name = "button3";
            button3.Size = new Size(59, 29);
            button3.TabIndex = 10;
            button3.Text = "Find";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // AdminMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 543);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Name = "AdminMenu";
            Text = "AdminMenu";
            Load += AdminMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Button button2;
        private TextBox textBox1;
        private Button button3;
    }
}