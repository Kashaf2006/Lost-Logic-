namespace LostLogic
{
    partial class PickUpLocation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PickUpLocation));
            button7 = new Button();
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            button9 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            button8 = new Button();
            comboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button7
            // 
            button7.Font = new Font("Segoe Print", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(1000, 147);
            button7.Name = "button7";
            button7.Size = new Size(185, 53);
            button7.TabIndex = 79;
            button7.Text = "Find Route";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(319, 380);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(841, 269);
            dataGridView1.TabIndex = 78;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(612, 115);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(336, 50);
            comboBox1.TabIndex = 77;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(319, 181);
            label4.Name = "label4";
            label4.Size = new Size(247, 49);
            label4.TabIndex = 75;
            label4.Text = "Pickup Location";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(319, 116);
            label2.Name = "label2";
            label2.Size = new Size(265, 49);
            label2.TabIndex = 74;
            label2.Text = "Current Location";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(button9);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 688);
            panel2.TabIndex = 73;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe Print", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.Location = new Point(12, 484);
            button9.Name = "button9";
            button9.Size = new Size(269, 53);
            button9.TabIndex = 18;
            button9.Text = "Pickup Location";
            button9.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe Print", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(12, 573);
            button6.Name = "button6";
            button6.Size = new Size(269, 53);
            button6.TabIndex = 17;
            button6.Text = "Logout";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe Print", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(12, 403);
            button5.Name = "button5";
            button5.Size = new Size(269, 53);
            button5.TabIndex = 16;
            button5.Text = "Profile";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe Print", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(12, 315);
            button4.Name = "button4";
            button4.Size = new Size(269, 53);
            button4.TabIndex = 15;
            button4.Text = "Status";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe Print", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(12, 232);
            button3.Name = "button3";
            button3.Size = new Size(269, 53);
            button3.TabIndex = 14;
            button3.Text = "Claim Section";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe Print", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(12, 139);
            button2.Name = "button2";
            button2.Size = new Size(269, 53);
            button2.TabIndex = 13;
            button2.Text = "Search item";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe Print", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 53);
            button1.Name = "button1";
            button1.Size = new Size(269, 53);
            button1.TabIndex = 12;
            button1.Text = "Add item";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5, 6, 5, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1219, 94);
            panel1.TabIndex = 72;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe Print", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(90, 38);
            label1.Name = "label1";
            label1.Size = new Size(245, 49);
            label1.TabIndex = 12;
            label1.Text = "User Dashboard";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe Print", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(612, 19);
            label3.Name = "label3";
            label3.Size = new Size(185, 56);
            label3.TabIndex = 5;
            label3.Text = "Lost Logic";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(319, 250);
            label5.Name = "label5";
            label5.Size = new Size(271, 49);
            label5.TabIndex = 80;
            label5.Text = "Shortest Distance";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(612, 252);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(336, 50);
            textBox2.TabIndex = 81;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(319, 328);
            label6.Name = "label6";
            label6.Size = new Size(103, 49);
            label6.TabIndex = 82;
            label6.Text = "Route";
            // 
            // button8
            // 
            button8.Font = new Font("Segoe Print", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.Location = new Point(612, 684);
            button8.Name = "button8";
            button8.Size = new Size(185, 53);
            button8.TabIndex = 83;
            button8.Text = "Back";
            button8.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(612, 183);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(336, 50);
            comboBox2.TabIndex = 84;
            // 
            // PickUpLocation
            // 
            AutoScaleDimensions = new SizeF(18F, 49F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 782);
            Controls.Add(comboBox2);
            Controls.Add(button8);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(button7);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe Print", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "PickUpLocation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PickUpLocation";
            Load += PickUpLocation_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button7;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private Label label4;
        private Label label2;
        private Panel panel2;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private Label label5;
        private TextBox textBox2;
        private Label label6;
        private Button button8;
        private ComboBox comboBox2;
        private Button button9;
    }
}