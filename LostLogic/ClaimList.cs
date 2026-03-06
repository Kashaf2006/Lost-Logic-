using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace LostLogic
{
    public partial class ClaimList : Form
    {
        // Max-Heap for priority-based claims
        private PriorityQueue<Item, int> claimHeap = new PriorityQueue<Item, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));

        public ClaimList()
        {
            InitializeComponent();
        }

        private void ClaimList_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            LoadClaims();
            DisplayClaims();
        }

        // Setup DataGridView columns
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
            dataGridView1.Columns.Add("Priority", "Priority"); // NEW
        }

        // Load claims from claim.txt into the heap
        private void LoadClaims()
        {
            claimHeap.Clear();

            if (!File.Exists("claim.txt"))
            {
                MessageBox.Show("No claim.txt file found.");
                return;
            }

            foreach (string line in File.ReadAllLines("claim.txt"))
            {
                string[] parts = line.Split('|');
                if (parts.Length >= 7)
                {
                    int priority = GetPriority(parts[2].Trim());
                    var item = new Item
                    {
                        Id = parts[0].Trim(),
                        Name = parts[1].Trim(),
                        Category = parts[2].Trim(),
                        Date = parts[3].Trim(),
                        Contact = parts[4].Trim(),
                        Location = parts[5].Trim(),
                        Description = parts[6].Trim(),
                        Priority = priority
                    };
                    claimHeap.Enqueue(item, priority);
                }
            }
        }

        // Assign priority based on category
        private int GetPriority(string category)
        {
            return category switch
            {
                "Electronic" => 3,
                "Documents" => 2,
                "Accessories" => 1,
                _ => 0
            };
        }

        // Display claims in DataGridView and show next claim
        private void DisplayClaims()
        {
            dataGridView1.Rows.Clear();

            // Copy heap to list for sorting by priority
            var tempList = new List<Item>();
            foreach (var pair in claimHeap.UnorderedItems)
                tempList.Add(pair.Element);

            tempList.Sort((a, b) => b.Priority.CompareTo(a.Priority));

            foreach (var item in tempList)
            {
                dataGridView1.Rows.Add(item.Id, item.Name, item.Category,
                    item.Date, item.Contact, item.Location, item.Description, item.Priority);
            }

            if (tempList.Count > 0)
            {
                Item next = tempList[0];
                label2.Text = $"Next Claim: {next.Name} ({next.Category})";
            }
            else
            {
                label2.Text = "No claims in queue.";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

            if (claimHeap.Count == 0)
            {
                MessageBox.Show("No claims to process!");
                return;
            }

            Item processedItem = claimHeap.Dequeue(); // highest priority
            MessageBox.Show($"Claim processed: {processedItem.Name}");

            DisplayClaims();

            // Update claim.txt
            List<string> remaining = new List<string>();
            foreach (var pair in claimHeap.UnorderedItems)
            {
                var item = pair.Element;
                remaining.Add($"{item.Id}|{item.Name}|{item.Category}|{item.Date}|{item.Contact}|{item.Location}|{item.Description}");
            }
            File.WriteAllLines("claim.txt", remaining);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Verification verificationForm = new Verification();
            verificationForm.ShowDialog();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form1Form = new Form1();
            form1Form.ShowDialog();
            this.Hide();
        }
    }
}
