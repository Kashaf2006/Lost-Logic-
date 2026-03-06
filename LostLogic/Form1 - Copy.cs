namespace LostLogic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password!");
                return;
            }

            // 🔐 ADMIN CHECK (FIRST)
            if (username == "admin" && password == "admin123")
            {
                MessageBox.Show("Admin Login Successful!");

                this.Hide();
                AdminDashboard admin = new AdminDashboard();
                admin.Show();
                return;
            }

            // 👤 NORMAL USER LOGIN
            if (!File.Exists("user.txt"))
            {
                MessageBox.Show("No users registered yet!");
                return;
            }

            string hashedPassword = HashPassword(password);
            bool loginSuccess = false;

            string[] lines = File.ReadAllLines("user.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');

                if (parts.Length >= 2)
                {
                    if (parts[0] == username && parts[1] == hashedPassword)
                    {
                        loginSuccess = true;
                        break;
                    }
                }
            }

            if (loginSuccess)
            {
                MessageBox.Show("User Login Successful!");

                this.Hide();
                Dashboard user = new Dashboard();
                user.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Sign Up Button - Open signup form
            this.Hide();
            SignUp signupForm = new SignUp();
            signupForm.Show();
        }
        private string HashPassword(string password)
        {
            int hash = 0;
            foreach (char c in password)
                hash += c;
            return hash.ToString();
        }

    }
}
