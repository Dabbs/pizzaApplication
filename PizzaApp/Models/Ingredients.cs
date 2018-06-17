using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.Models
{
    public class Ingredients
    {
        public int Ham { get; set; }
        public int Pepperoni { get; set; }
        public int Bacon { get; set; }
        public int Tomato { get; set; }
        public int Pork { get; set; }
        public int Cheese { get; set; }
        public int Cumcumber { get; set; }
        public int PineApple { get; set; }
        public int Banana { get; set; }

        public Ingredients()
        {

        }

        public Ingredients(int ham, int peppeoni, int bacon, int tomato, int cumcumber, int pineApple, int cheese, int banana)
        {
            this.Ham = ham;
            this.Pepperoni = peppeoni;
            this.Bacon = bacon;
            this.Tomato = tomato;
            this.Cumcumber = cumcumber;
            this.PineApple = pineApple;
            this.Cheese = cheese;
            this.Bacon = bacon;
        }

        public class Sauce : Ingredients
        {
            public string SauceName { get; set; }
        }

    }

   
    
}
