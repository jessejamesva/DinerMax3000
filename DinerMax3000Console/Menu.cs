using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000Console
{
    public class Menu
    {
        // Constructor for instantiating the class, will be run automatically
        public Menu()
        {
            items = new List<MenuItem>();
        }

        public void AddMenuItem(string Title, string Description, double Price)
        {
            MenuItem item = new MenuItem();
            item.Title = Title;
            item.Description = Description;
            item.Price = Price;
            items.Add(item);
        }
        public string Name;
        public List<MenuItem> items;
    }
}
