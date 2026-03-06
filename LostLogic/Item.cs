using System;

namespace LostLogic
{
    public class Item
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Date { get; set; }
        public string Contact { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }  // For priority-based heap
    }
}

