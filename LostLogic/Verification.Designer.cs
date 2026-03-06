namespace LostLogic
{
    partial class Verification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Verification));
            panel2 = new Panel();
            button6 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button7 = new Button();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 688);
            panel2.TabIndex = 15;
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
            button6.Click += button6_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe Print", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(12, 139);
            button2.Name = "button2";
            button2.Size = new Size(269, 53);
            button2.TabIndex = 13;
            button2.Text = "Verification";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe Print", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 53);
            button1.Name = "button1";
            button1.Size = new Size(269, 53);
            button1.TabIndex = 12;
            button1.Text = "Claim List";
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
            panel1.TabIndex = 14;
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
            label1.Size = new Size(279, 49);
            label1.TabIndex = 12;
            label1.Text = "Admin Dashboard";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(348, 479);
            label2.Name = "label2";
            label2.Size = new Size(127, 49);
            label2.TabIndex = 32;
            label2.Text = "Item Id";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(527, 478);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 50);
            textBox1.TabIndex = 38;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe Print", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(368, 611);
            button7.Name = "button7";
            button7.Size = new Size(149, 53);
            button7.TabIndex = 45;
            button7.Text = "Verify";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(329, 138);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(861, 286);
            dataGridView1.TabIndex = 46;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe Print", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(1002, 611);
            button3.Name = "button3";
            button3.Size = new Size(139, 53);
            button3.TabIndex = 47;
            button3.Text = "Reject";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // Verification
            // 
            AutoScaleDimensions = new SizeF(18F, 49F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 782);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(button7);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe Print", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Verification";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Verification";
            Load += Verification_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button button6;
        private Button button2;
        private Button button1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Button button7;
        private DataGridView dataGridView1;
        private Button button3;
    }
}