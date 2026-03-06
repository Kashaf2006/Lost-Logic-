using System;
using System.IO;
using System.Windows.Forms;

namespace LostLogic
{
    public partial class SearchFound : Form
    {
        string filePath = "items.txt";

        public SearchFound()
        {
            InitializeComponent();
            SearchFound_Load(this, EventArgs.Empty);
        }

        private void SearchFound_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Electronic");
            comboBox1.Items.Add("Accessories");
            comboBox1.Items.Add("Document");

            SetupGrid();
        }

        private void SetupGrid()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Add("ID", "Item ID");
            dataGridView1.Columns.Add("Name", "Item Name");
            dataGridView1.Columns.Add("Type", "Type");
            dataGridView1.Columns.Add("Category", "Category");
            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns.Add("Contact", "Contact");
            dataGridView1.Columns.Add("Location", "Location");
            dataGridView1.Columns.Add("Description", "Description");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            AddFound addForm = new AddFound();
            addForm.ShowDialog();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClaimSection claimForm = new ClaimSection();
            claimForm.ShowDialog();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Status statusForm = new Status();
            statusForm.ShowDialog();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Profile profileForm = new Profile();
            profileForm.ShowDialog();
            this.Hide();
        }

        private void SearchFound_Load_1(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count == 0)
                SetupGrid();

            dataGridView1.Rows.Clear();

            string searchName = textBox1.Text.Trim().ToLower();
            string searchCategory = comboBox1.Text;

            if (searchName == "" || searchCategory == "")
            {
                MessageBox.Show("Enter item name and select category");
                return;
            }

            if (!File.Exists(filePath))
            {
                MessageBox.Show("No data file found!");
                return;
            }

            bool found = false;

            // 📌 DSA: LINEAR SEARCH
            foreach (string line in File.ReadAllLines(filePath))
            {
                string[] data = line.Split('|');

                string itemName = data[1].ToLower();
                string category = data[3];

                if (itemName.Contains(searchName) && category == searchCategory)
                {
                    dataGridView1.Rows.Add(
                        data[0], // ID
                        data[1], // Name
                        data[2], // Type
                        data[3], // Category
                        data[4], // Date
                        data[5], // Contact
                        data[6], // Location
                        data[7]  // Description
                    );
                    found = true;
                }
            }

            if (!found)
                MessageBox.Show("No matching items found!");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form1Form = new Form1();
            form1Form.ShowDialog();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PickUpLocation pickUpForm = new PickUpLocation();
            pickUpForm.ShowDialog();
            this.Hide();
        }
    }
}


