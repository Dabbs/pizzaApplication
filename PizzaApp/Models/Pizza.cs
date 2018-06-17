using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.Models
{
    public class Pizza
    {
        public string Name { get; set; }
        public string TotalCost { get; set; }
        public Ingredients Ingredients { get; set; }
    }
}
