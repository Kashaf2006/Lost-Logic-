using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LostLogic
{
    public partial class PickUpLocation : Form
    {
        Dictionary<string, List<(string, int)>> graph = new Dictionary<string, List<(string, int)>>();
        Dictionary<string, int> distance = new Dictionary<string, int>();
        Dictionary<string, string> parent = new Dictionary<string, string>();

        public PickUpLocation()
        {
            InitializeComponent();
        }

        private void PickUpLocation_Load(object sender, EventArgs e)
        {
            LoadLocationsToCombo();
            LoadPickupLocations();  
            SetupGrid();
        }

        // ================= LOAD CURRENT LOCATIONS =================
        void LoadLocationsToCombo()
        {
            comboBox1.Items.Clear();
            HashSet<string> locations = new HashSet<string>();

            foreach (string line in File.ReadAllLines("locations.txt"))
            {
                string[] p = line.Split(',');
                locations.Add(p[0].Trim());
                locations.Add(p[1].Trim());
            }

            comboBox1.Items.AddRange(locations.ToArray());
        }

        // ================= LOAD PICKUP LOCATIONS =================
        void LoadPickupLocations()
        {
            comboBox2.Items.Clear(); 
            HashSet<string> pickups = new HashSet<string>();

            foreach (string line in File.ReadAllLines("found_items.txt"))
            {
                string[] p = line.Split('|');
                if (p.Length >= 7)
                    pickups.Add(p[6].Trim()); // location of the item
            }

            comboBox2.Items.AddRange(pickups.ToArray());
        }

        // ================= GRID =================
        void SetupGrid()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("From", "From");
            dataGridView1.Columns.Add("To", "To");
            dataGridView1.Columns.Add("Dist", "Distance");
        }

        // ================= LOAD GRAPH =================
        void LoadGraph()
        {
            graph.Clear();
            foreach (string line in File.ReadAllLines("locations.txt"))
            {
                string[] p = line.Split(',');
                string from = p[0].Trim();
                string to = p[1].Trim();
                int dist = int.Parse(p[2].Trim());

                AddEdge(from, to, dist);
                AddEdge(to, from, dist);
            }
        }

        void AddEdge(string from, string to, int dist)
        {
            if (!graph.ContainsKey(from))
                graph[from] = new List<(string, int)>();

            graph[from].Add((to, dist));
        }

        // ================= DIJKSTRA =================
        void Dijkstra(string start)
        {
            distance.Clear();
            parent.Clear();
            var pq = new PriorityQueue<string, int>();

            foreach (var node in graph.Keys)
            {
                distance[node] = int.MaxValue;
                parent[node] = null;
            }

            distance[start] = 0;
            pq.Enqueue(start, 0);

            while (pq.Count > 0)
            {
                string u = pq.Dequeue();
                if (!graph.ContainsKey(u)) continue;

                foreach (var (v, w) in graph[u])
                {
                    if (distance[u] + w < distance[v])
                    {
                        distance[v] = distance[u] + w;
                        parent[v] = u;
                        pq.Enqueue(v, distance[v]);
                    }
                }
            }
        }

        // ================= BUTTON =================
        //private void button7_Click(object sender, EventArgs e)
        //{
        //    if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
        //    {
        //        MessageBox.Show("Please select both current location and pickup location");
        //        return;
        //    }

        //    string start = comboBox1.Text.Trim();
        //    string pickup = comboBox2.Text.Trim();

        //    LoadGraph();

        //    if (!graph.ContainsKey(start) || !graph.ContainsKey(pickup))
        //    {
        //        MessageBox.Show("Selected locations are not in the graph!");
        //        return;
        //    }

        //    Dijkstra(start);

        //    if (distance[pickup] == int.MaxValue)
        //    {
        //        MessageBox.Show("No route exists between the selected locations");
        //        return;
        //    }

        //    // Fill text boxes
        //    //textBox1.Text = pickup;
        //    textBox2.Text = distance[pickup].ToString();

        //    // Build path for grid
        //    dataGridView1.Rows.Clear();
        //    List<string> path = new List<string>();
        //    string current = pickup;

        //    while (current != null && current != start)
        //    {
        //        path.Add(current);
        //        current = parent.ContainsKey(current) ? parent[current] : null;
        //    }

        //    path.Add(start);
        //    path.Reverse();

        //    for (int i = 0; i < path.Count - 1; i++)
        //    {
        //        string from = path[i];
        //        string to = path[i + 1];
        //        var edge = graph[from].Find(x => x.Item1 == to);
        //        int dist = edge.Item2;

        //        dataGridView1.Rows.Add(from, to, dist);
        //    }
        //}

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Please select both current location and pickup location");
                return;
            }

            string start = comboBox1.Text.Trim();
            string pickup = comboBox2.Text.Trim();

            LoadGraph();

            if (!graph.ContainsKey(start) || !graph.ContainsKey(pickup))
            {
                MessageBox.Show("Selected locations are not in the graph!");
                return;
            }

            Dijkstra(start);

            if (distance[pickup] == int.MaxValue)
            {
                MessageBox.Show("No route exists between the selected locations");
                return;
            }

            // Fill text boxes
            //textBox1.Text = pickup;
            textBox2.Text = distance[pickup].ToString();

            // Build path for grid
            dataGridView1.Rows.Clear();
            List<string> path = new List<string>();
            string current = pickup;

            while (current != null && current != start)
            {
                path.Add(current);
                current = parent.ContainsKey(current) ? parent[current] : null;
            }

            path.Add(start);
            path.Reverse();

            for (int i = 0; i < path.Count - 1; i++)
            {
                string from = path[i];
                string to = path[i + 1];
                var edge = graph[from].Find(x => x.Item1 == to);
                int dist = edge.Item2;

                dataGridView1.Rows.Add(from, to, dist);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddFound addFoundForm = new AddFound();
            addFoundForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchFound searchFoundForm = new SearchFound();
            searchFoundForm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClaimSection claimSectionForm = new ClaimSection();
            claimSectionForm.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Status statusForm = new Status();
            statusForm.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Profile profileForm = new Profile();
            profileForm.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
