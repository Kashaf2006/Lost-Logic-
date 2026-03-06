namespace LostLogic
{
    partial class SignUp
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
            button3 = new Button();
            button2 = new Button();
            panel3 = new Panel();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label3 = new Label();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(950, 686);
            button3.Name = "button3";
            button3.Size = new Size(150, 57);
            button3.TabIndex = 9;
            button3.Text = "Login";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(381, 686);
            button2.Name = "button2";
            button2.Size = new Size(150, 57);
            button2.TabIndex = 8;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(217, 217, 217);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(442, 207);
            panel3.Name = "panel3";
            panel3.Size = new Size(586, 459);
            panel3.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(15, 367);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(413, 57);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(15, 298);
            label4.Name = "label4";
            label4.Size = new Size(102, 49);
            label4.TabIndex = 4;
            label4.Text = "Email";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(15, 227);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(413, 57);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(413, 57);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(15, 156);
            label2.Name = "label2";
            label2.Size = new Size(156, 49);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(15, 17);
            label1.Name = "label1";
            label1.Size = new Size(164, 49);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 688);
            panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(224, 224, 224);
            pictureBox1.Image = Properties.Resources.think_question;
            pictureBox1.Location = new Point(59, 156);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 241);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5, 6, 5, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1219, 94);
            panel1.TabIndex = 5;
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
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(18F, 49F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 782);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe Print", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            Load += SignUp_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private Button button2;
        private Panel panel3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label3;
    }
}