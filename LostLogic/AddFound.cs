using System;
using System.IO;
using System.Windows.Forms;


namespace LostLogic
{
    public partial class AddFound : Form
    {
        string filePath = "items.txt";
        string selectedImagePath = "";

        public AddFound()
        {
            InitializeComponent();
        }


        private void AddFound_Load_1(object sender, EventArgs e)
        {
            comboBox2.Items.Add("Lost");
            comboBox2.Items.Add("Found");

            comboBox1.Items.Add("Electronic");
            comboBox1.Items.Add("Accessories");
            comboBox1.Items.Add("Document");
        }
        private int GetNextItemID()
        {
            if (!File.Exists(filePath))
                return 1;

            string[] lines = File.ReadAllLines(filePath);
            return lines.Length + 1;
        }

        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            pictureBox2.Image = null;
            selectedImagePath = "";
        }


        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = ofd.FileName;
                pictureBox2.ImageLocation = selectedImagePath;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" ||
                comboBox1.Text == "" ||
                comboBox2.Text == "" ||
                textBox2.Text == "")
            {
                MessageBox.Show("Please fill all required fields!");
                return;
            }

            if (textBox2.Text.Length != 11)
            {
                MessageBox.Show("Contact must be 11 digits!");
                return;
            }

            int itemID = GetNextItemID();

            string record =
                itemID + "|" +
                textBox1.Text + "|" +
                comboBox2.Text + "|" +
                comboBox1.Text + "|" +
                dateTimePicker1.Text + "|" +
                textBox2.Text + "|" +
                textBox3.Text + "|" +
                textBox4.Text + "|" +
                selectedImagePath;

            File.AppendAllText(filePath, record + Environment.NewLine);

            MessageBox.Show("Item added successfully!");
            ClearFields();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchFound searchForm = new SearchFound();
            searchForm.ShowDialog();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClaimSection claimForm = new ClaimSection();
            claimForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Status status = new Status();
            status.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Profile profileForm = new Profile();
            profileForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            PickUpLocation pickUpLocationForm = new PickUpLocation();
            pickUpLocationForm.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SearchFound searchFoundForm = new SearchFound();
            searchFoundForm.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ClaimSection claimSectionForm = new ClaimSection();
            claimSectionForm.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Status statusForm = new Status();
            statusForm.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Profile profileForm = new Profile();
            profileForm.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 form1Form = new Form1();
            form1Form.Show();
            this.Hide();
        }
    }
}
