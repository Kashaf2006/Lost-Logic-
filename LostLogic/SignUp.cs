using System;
using System.IO;
using System.Windows.Forms;

namespace LostLogic
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();
            string email = textBox3.Text.Trim();

            string filePath = Application.StartupPath + "\\user.txt";

            if (string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            // Prevent admin registration
            if (username.ToLower() == "admin")
            {
                MessageBox.Show("This username is reserved!");
                return;
            }

            // Check duplicate username
            if (File.Exists(filePath))
            {
                foreach (string line in File.ReadAllLines(filePath))
                {
                    string[] parts = line.Split('|');
                    if (parts[0] == username)
                    {
                        MessageBox.Show("Username already exists!");
                        return;
                    }
                }
            }

            string hashedPassword = HashPassword(password);

            // Auto create file & write data
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine(username + "|" + hashedPassword + "|" + email);
            }

            MessageBox.Show("Registration Successful!");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private string HashPassword(string password)
        {
            int hash = 0;
            foreach (char c in password)
                hash += c;
            return hash.ToString();
        }
    private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
