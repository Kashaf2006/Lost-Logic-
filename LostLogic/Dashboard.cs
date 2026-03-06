using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LostLogic
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddFound form = new AddFound();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchFound form = new SearchFound();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClaimSection claimSectionForm = new ClaimSection();
            claimSectionForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Status form = new Status();
            form.Show();
            this.Hide();
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form1Form = new Form1();
            form1Form.ShowDialog();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PickUpLocation pickUpLocationForm = new PickUpLocation();
            pickUpLocationForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Profile profileForm = new Profile();
            profileForm.Show();
            this.Hide();
        }
    }
}
