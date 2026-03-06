using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace LostLogic
{
    public partial class ClaimSection : Form
    {
        private List<Item> items = new List<Item>();

        public ClaimSection()
        {
            InitializeComponent();
            LoadCategories();
            LoadItems();
            //DisplayItems();
        }

        private void ClaimSection_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("ItemId", "Item ID");
            dataGridView1.Columns.Add("ItemName", "Item Name");
            dataGridView1.Columns.Add("Category", "Category");
            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns.Add("Contact", "Contact");
            dataGridView1.Columns.Add("Location", "Location");
            dataGridView1.Columns.Add("Description", "Description");

            DisplayItems();
        }


        private void LoadCategories()
        {
            comboBox1.Items.AddRange(new string[] { "Electronic", "Accessories", "Document" });
        }

        private void LoadItems()
        {
            if (!File.Exists("items.txt"))
            {
                MessageBox.Show("items.txt not found");
                return;
            }

            items.Clear();

            foreach (string line in File.ReadAllLines("items.txt"))
            {
                string[] parts = line.Split('|');

                if (parts.Length >= 8)
                {
                    items.Add(new Item
                    {
                        Id = parts[0].Trim(),
                        Name = parts[1].Trim(),
                        Category = parts[3].Trim(),   // CORRECT index
                        Date = parts[4].Trim(),
                        Contact = parts[5].Trim(),
                        Location = parts[6].Trim(),
                        Description = parts[7].Trim()
                    });
                }
            }
        }


        private void DisplayItems()
        {
            dataGridView1.Rows.Clear();
            foreach (Item item in items)
            {
                dataGridView1.Rows.Add(item.Id, item.Name, item.Category,
                    item.Date, item.Contact, item.Location, item.Description);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text.Trim();
            string category = comboBox1.Text.Trim();

            if (id == "" || category == "")
            {
                MessageBox.Show("Enter Item ID and select Category");
                return;
            }

            foreach (Item item in items)
            {
                if (item.Id.Equals(id, StringComparison.OrdinalIgnoreCase) &&
                    item.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
                {
                    File.AppendAllText("claim.txt",
                        $"{item.Id}|{item.Name}|{item.Category}|{item.Date}|" +
                        $"{item.Contact}|{item.Location}|{item.Description}{Environment.NewLine}");

                    MessageBox.Show("Item claimed successfully!");

                    textBox1.Clear();
                    comboBox1.SelectedIndex = -1;
                    return;
                }
            }

            MessageBox.Show("Item not found!");
        }


        public class Item
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Category { get; set; }
            public string Date { get; set; }
            public string Contact { get; set; }
            public string Location { get; set; }
            public string Description { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddFound addFoundForm = new AddFound();
            addFoundForm.ShowDialog();  // Show the AddFound form
            this.Hide();  // Hide current form after AddFound closes
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchFound searchFoundForm = new SearchFound();
            searchFoundForm.ShowDialog();  // Show the SearchFound form
            this.Hide();  // Hide current form after SearchFound closes
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Status statusForm = new Status();
            statusForm.ShowDialog();  // Show the Status form, not 'this'
            this.Hide();  // This will hide the current form after Status closes
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Profile profileForm = new Profile();
            profileForm.ShowDialog();  // Show the Profile form, not 'this'
            this.Hide();  // Hide current form after Profile closes
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form1Form = new Form1();
            form1Form.ShowDialog();  // This is correct
            this.Hide();  // This will hide current form after Form1 closes
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PickUpLocation pickUpLocationForm = new PickUpLocation();
            pickUpLocationForm.ShowDialog();  // Show the PickUpLocation form
            this.Hide();
        }
    }
}