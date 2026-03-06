using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace LostLogic
{
    public partial class Verification : Form
    {
      
        private SortedDictionary<string, Item> verificationBST = new SortedDictionary<string, Item>();

        public Verification()
        {
            InitializeComponent();
        }

        private void Verification_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            LoadVerificationClaims();
            DisplayClaims();
        }
        private void SetupDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("ItemId", "Item ID");
            dataGridView1.Columns.Add("ItemName", "Item Name");
            dataGridView1.Columns.Add("Category", "Category");
            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns.Add("Contact", "Contact");
            dataGridView1.Columns.Add("Location", "Location");
            dataGridView1.Columns.Add("Description", "Description");
            dataGridView1.Columns.Add("Status", "Status");
        }

        private void LoadVerificationClaims()
        {
            verificationBST.Clear();

            if (!File.Exists("claim.txt"))
                return;

            foreach (var line in File.ReadAllLines("claim.txt"))
            {
                var parts = line.Split('|');
                if (parts.Length >= 7)
                {
                    var item = new Item
                    {
                        Id = parts[0].Trim(),
                        Name = parts[1].Trim(),
                        Category = parts[2].Trim(),
                        Date = parts[3].Trim(),
                        Contact = parts[4].Trim(),
                        Location = parts[5].Trim(),
                        Description = parts[6].Trim()
                    };
                    verificationBST[item.Id] = item;
                }
            }
        }

    
        private void DisplayClaims()
        {
            dataGridView1.Rows.Clear();
            foreach (var kvp in verificationBST)
            {
                var item = kvp.Value;
                dataGridView1.Rows.Add(item.Id, item.Name, item.Category,
                    item.Date, item.Contact, item.Location, item.Description, "Pending");
            }
        }

      
        private void UpdateVerificationFile()
        {
            List<string> remaining = new List<string>();
            foreach (var kvp in verificationBST)
            {
                var item = kvp.Value;
                remaining.Add($"{item.Id}|{item.Name}|{item.Category}|{item.Date}|{item.Contact}|{item.Location}|{item.Description}");
            }
            File.WriteAllLines("claim.txt", remaining);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ClaimList claimListForm = new ClaimList();
            claimListForm.ShowDialog();
            this.Hide();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
            this.Hide();
        }

        // ------------------ VERIFY BUTTON (Button7) ------------------
        private void button7_Click_1(object sender, EventArgs e)
        {
            string itemId = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(itemId))
            {
                MessageBox.Show("Enter Item ID to verify!");
                return;
            }

            if (verificationBST.ContainsKey(itemId))
            {
                var item = verificationBST[itemId];
                MessageBox.Show($"Claim Verified: {item.Name}");

                File.AppendAllText("user_status.txt",
                    $"{item.Id}|{item.Name}|{item.Category}|Cleared{Environment.NewLine}");

               
                verificationBST.Remove(itemId);
                DisplayClaims();

                UpdateVerificationFile();
            }
            else
            {
                MessageBox.Show("Item ID not found!");
            }
        }

        // ------------------ REJECT BUTTON (Button3) ------------------
        private void button3_Click_1(object sender, EventArgs e)
        {
            string itemId = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(itemId))
            {
                MessageBox.Show("Enter Item ID to reject!");
                return;
            }

            if (verificationBST.ContainsKey(itemId))
            {
                var item = verificationBST[itemId];
                MessageBox.Show($"Claim Rejected: {item.Name}");

               
                File.AppendAllText("user_status.txt",
                    $"{item.Id}|{item.Name}|{item.Category}|Rejected{Environment.NewLine}");

                
                verificationBST.Remove(itemId);
                DisplayClaims();

                UpdateVerificationFile();
            }
            else
            {
                MessageBox.Show("Item ID not found!");
            }
        }
    }

    // ------------------ ITEM CLASS ------------------
    //public class Item
    //{
    //    public string Id { get; set; }
    //    public string Name { get; set; }
    //    public string Category { get; set; }
    //    public string Date { get; set; }
    //    public string Contact { get; set; }
    //    public string Location { get; set; }
    //    public string Description { get; set; }
    //    public int Priority { get; set; } // Optional for future use
    //}
}
