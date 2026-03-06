using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace LostLogic
{
    public partial class Profile : Form
    {
        private string currentUsername;   // logged-in user

        // Constructor (pass username from login/dashboard)
        public Profile(string username)
        {
            InitializeComponent();
            currentUsername = username;
        }
        public Profile()
        {
            InitializeComponent();
        }


        // FORM LOAD
        private void Profile_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        // LOAD USER DATA INTO TEXTBOXES
        private void LoadUserData()
        {
            if (!File.Exists("user.txt"))
            {
                MessageBox.Show("User file not found!");
                return;
            }

            foreach (string line in File.ReadAllLines("user.txt"))
            {
                string[] parts = line.Split('|');

                if (parts.Length == 3 && parts[0] == currentUsername)
                {
                    textBox1.Text = parts[0]; // username
                    textBox3.Text = parts[2]; // email
                    break;
                }
            }
        }

        // EDIT / UPDATE BUTTON
        //private void button7_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(textBox1.Text) ||
        //        string.IsNullOrWhiteSpace(textBox3.Text))
        //    {
        //        MessageBox.Show("Username and Email cannot be empty!");
        //        return;
        //    }

        //    List<string> updatedUsers = new List<string>();

        //    foreach (string line in File.ReadAllLines("user.txt"))
        //    {
        //        string[] parts = line.Split('|');

        //        if (parts[0] == currentUsername)
        //        {
        //            string newUsername = textBox1.Text.Trim();
        //            string newEmail = textBox3.Text.Trim();

        //            // If password box empty → keep old hash
        //            string passwordHash = parts[1];

        //            if (!string.IsNullOrWhiteSpace(textBox2.Text))
        //                passwordHash = HashPassword(textBox2.Text);

        //            updatedUsers.Add($"{newUsername}|{passwordHash}|{newEmail}");
        //            currentUsername = newUsername;
        //        }
        //        else
        //        {
        //            updatedUsers.Add(line);
        //        }
        //    }

        //    File.WriteAllLines("user.txt", updatedUsers);

        //    MessageBox.Show("Profile updated successfully!");
        //    textBox2.Clear(); // clear password box
        //}

        //// PASSWORD HASHING (SHA256)
        //private string HashPassword(string password)
        //{
        //    using (SHA256 sha = SHA256.Create())
        //    {
        //        byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
        //        StringBuilder sb = new StringBuilder();
        //        foreach (byte b in bytes)
        //            sb.Append(b.ToString("x2"));
        //        return sb.ToString();
        //    }
        //}

        //// NAVIGATION BUTTONS (OPTIONAL – KEEP OR REMOVE)



        private void button1_Click(object sender, EventArgs e)
        {
            AddFound addFoundForm = new AddFound();
            addFoundForm.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchFound searchFoundForm = new SearchFound();
            searchFoundForm.ShowDialog();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClaimSection sectionForm = new ClaimSection();
            sectionForm.ShowDialog();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Status statusForm = new Status();
            statusForm.ShowDialog();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form1Form = new Form1();
            form1Form.ShowDialog();
            this.Hide();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Username and Email cannot be empty!");
                return;
            }

            List<string> updatedUsers = new List<string>();

            foreach (string line in File.ReadAllLines("user.txt"))
            {
                string[] parts = line.Split('|');

                if (parts[0] == currentUsername)
                {
                    string newUsername = textBox1.Text.Trim();
                    string newEmail = textBox3.Text.Trim();

                    // If password box empty → keep old hash
                    string passwordHash = parts[1];

                    if (!string.IsNullOrWhiteSpace(textBox2.Text))
                        passwordHash = HashPassword(textBox2.Text);

                    updatedUsers.Add($"{newUsername}|{passwordHash}|{newEmail}");
                    currentUsername = newUsername;
                }
                else
                {
                    updatedUsers.Add(line);
                }
            }

            File.WriteAllLines("user.txt", updatedUsers);

            MessageBox.Show("Profile updated successfully!");
            textBox2.Clear(); // clear password box
        }

        // PASSWORD HASHING (SHA256)
        private string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            PickUpLocation pickUpLocationForm = new PickUpLocation();
            pickUpLocationForm.ShowDialog();
            this.Hide();
        }
    }
}
