using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace LostLogic
{
    public partial class Status : Form
    {
        private Dictionary<string, StatusItem> statusMap =
            new Dictionary<string, StatusItem>();

        public Status()
        {
            InitializeComponent();
            Load += Status_Load;
        }

        private void Status_Load(object sender, EventArgs e)
        {
            SetupGrid();
            LoadStatus();
            DisplayStatus();
        }

     
        private void SetupGrid()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("ItemId", "Item ID");
            dataGridView1.Columns.Add("ItemName", "Item Name");
            dataGridView1.Columns.Add("Category", "Category");
            dataGridView1.Columns.Add("Status", "Status");
        }
        private void LoadStatus()
        {
            statusMap.Clear();

            if (!File.Exists("user_status.txt"))
                return;

            foreach (string line in File.ReadAllLines("user_status.txt"))
            {
                string[] parts = line.Split('|');
                if (parts.Length == 4)
                {
                    statusMap[parts[0]] = new StatusItem
                    {
                        Id = parts[0],
                        Name = parts[1],
                        Category = parts[2],
                        Status = parts[3]
                    };
                }
            }
        }
        private void DisplayStatus()
        {
            dataGridView1.Rows.Clear();

            foreach (var item in statusMap.Values)
            {
                int rowIndex = dataGridView1.Rows.Add(
                    item.Id,
                    item.Name,
                    item.Category,
                    item.Status
                );

                if (item.Status == "Cleared")
                    dataGridView1.Rows[rowIndex].Cells[3].Style.ForeColor = System.Drawing.Color.Green;
                else if (item.Status == "Rejected")
                    dataGridView1.Rows[rowIndex].Cells[3].Style.ForeColor = System.Drawing.Color.Red;
                else
                    dataGridView1.Rows[rowIndex].Cells[3].Style.ForeColor = System.Drawing.Color.Orange;
            }
        }

        // Refresh Button (button7)
        private void button7_Click(object sender, EventArgs e)
        {
            LoadStatus();
            DisplayStatus();
            MessageBox.Show("Status refreshed!");
        }

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
            ClaimSection claimSectionForm = new ClaimSection();
            claimSectionForm.ShowDialog();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Profile profileForm = new Profile();
            profileForm.ShowDialog();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form1Form = new Form1();
            form1Form.ShowDialog();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PickUpLocation pickUpLocationForm = new PickUpLocation();
            pickUpLocationForm.ShowDialog();
            this.Hide();
        }

        private void Status_Load_1(object sender, EventArgs e)
        {

        }
    }

    // Simple model class
    public class StatusItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Status { get; set; }
    }
}
