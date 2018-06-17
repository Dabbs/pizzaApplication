using PizzaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PizzaApp
{
    /// <summary>
    /// Interaction logic for PizzaDataView.xaml
    /// </summary>
    public partial class PizzaDataView : Window
    {           
        public PizzaDataView()
        {
            InitializeComponent();
            listAllPizzas();
        }

        private void listAllPizzas()
        {
            LinkedList<Pizza> pizzas = PizzaInterface.pizzas;
            DataGridXAML.Items.Clear();

            if (pizzas == null)
                return;

            foreach (Pizza pizza in pizzas)
            {
                DataGridXAML.Items.Add(pizza);
            }
        }

        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
