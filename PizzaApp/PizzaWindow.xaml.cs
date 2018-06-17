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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PizzaApp
{
    /// <summary>
    /// Interaction logic for PizzaInterface.xaml
    /// </summary>
    public partial class PizzaInterface : Window
    {
        public static LinkedList<Pizza> pizzas = new LinkedList<Pizza>();

        public PizzaInterface()
        {
            InitializeComponent();
        }

        private void tomatoRadioBtn_Checked(object sender, RoutedEventArgs e)
        {
            costSauceLbl.Content = "$2.00";
            addTotalCost();
        }

        private void babacueRadioBtn_Checked(object sender, RoutedEventArgs e)
        {
            costSauceLbl.Content = "$2.00";
            addTotalCost();
        }

        private void hummasRadioBtn_Checked(object sender, RoutedEventArgs e)
        {
            costSauceLbl.Content = "$3.00";
            addTotalCost();
        }

        private void hamTxtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            addQuantity(hamTxtInput, hamCost, 2);
            addTotalCost();
        }

        private void addQuantity(TextBox textbox, Label cost, int costValuePerOne)
        {
            string inputTextbox = textbox.Text;

            if (inputTextbox.Equals(""))
            {
                cost.Content = "$0.00";   
                return;
            }

            int quantity = Convert.ToInt16(inputTextbox);
            int totalCost = costValuePerOne * quantity;
            cost.Content = "$" + Convert.ToString(totalCost) + ".00";
        }

        private void cheeseTxtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            addQuantity(cheeseTxtInput, cheeseCost, 2);
            addTotalCost();
        }

        private void pepperoniTxtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            addQuantity(pepperoniTxtInput, pepperoniCost, 2);
            addTotalCost();
        }

        private void cumcumberTxtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            addQuantity(CumcumberTxtInput, cumcumberCost, 2);
            addTotalCost();
        }

        private void tomatoTxtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            addQuantity(tomatoTxtInput, tomatoCost, 2);
            addTotalCost();
        }

        private void pineAppleTxtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            addQuantity(pineAppleTxtInput, pineAppleCost, 2);
            addTotalCost();
        }

        private void addTotalCost()
        {       
            double ham = getCostValue(hamCost);
            double cheese = getCostValue(cheeseCost);
            double pepperioni = getCostValue(pepperoniCost);
            double bacon = getCostValue(baconCost);
            double tomato = getCostValue(tomatoCost);
            double cucumber = getCostValue(cumcumberCost);
            double pork = getCostValue(porkCost);
            double pineapple = getCostValue(pineAppleCost);
            double banana = getCostValue(bananaCost);
            double totalCost = 0;

            if (tomatoRadioBtn.IsChecked == true)
            {
                totalCost += 2;
            }

            else if (babacueRadioBtn.IsChecked == true)
            {
                totalCost += 2;
            }
            else
            {
                totalCost += 3;
            }

            totalCost += ham + cheese + pepperioni + bacon + tomato + cucumber + pork + pineapple + banana;
            totalCostLbl.Content = "$" + Convert.ToString(totalCost) + ".00";

        }

        private double getCostValue(Label cost)
        {
            string newCost = cost.Content.ToString();
            var charsToRemove = new string[] {"$"};

            foreach (var c in charsToRemove)
            {
                newCost = newCost.Replace(c, string.Empty);
            }
            
            return Convert.ToDouble(newCost);
        }

        private void baconTxtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            addQuantity(baconTxtInput, baconCost, 3);
            addTotalCost();
        }

        private void bananaTxtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            addQuantity(bananaTxtInput, bananaCost, 3);
            addTotalCost();
        }

        private void porkTxtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            addQuantity(porkTxtInput, porkCost, 3);
            addTotalCost();
        }

        private void pizzaBtn_Click(object sender, RoutedEventArgs e)
        {
            var name = nameTextBx.Text;
            var totalCost = totalCostLbl.Content;
           
            if (name.Equals("") || (totalCost.Equals("$0.00")))
            {
                return;
            }

            // Create variables and instantiate them.
            int ham = getNumberForIngredient(hamTxtInput);
            int cheese = getNumberForIngredient(cheeseTxtInput);
            int pepperoni = getNumberForIngredient(pepperoniTxtInput);
            int banana = getNumberForIngredient(cheeseTxtInput);
            int pork = getNumberForIngredient(porkTxtInput);
            int bacon = getNumberForIngredient(baconTxtInput);
            int tomato = getNumberForIngredient(tomatoTxtInput);
            int cumcumber = getNumberForIngredient(CumcumberTxtInput);
            int pineApple = getNumberForIngredient(pineAppleTxtInput);

            // Create ingridents
            var ingredients = new Ingredients.Sauce();

            // Assign each ingridents.
            ingredients.Ham = ham;
            ingredients.Cheese = cheese;
            ingredients.Pepperoni = pepperoni;
            ingredients.Banana = banana;
            ingredients.Pork = pork;
            ingredients.Bacon = bacon;
            ingredients.Tomato = tomato;
            ingredients.Cumcumber = cumcumber;
            ingredients.PineApple = pineApple;
            ingredients.SauceName = getSauceRadioSelected();          

            Models.Pizza pizza = new Models.Pizza()
            {
                Name = name,
                TotalCost = totalCost.ToString(),
                Ingredients = ingredients
            };

            pizzas.AddLast(pizza);
            openForm();
            clearScreen();
        }

        private int getNumberForIngredient(TextBox ingredient)
        {
            if (ingredient.Text == "")
                return 0;
            else
                return Convert.ToInt16(ingredient.Text);
        }

        private string getSauceRadioSelected()
        {
            if (babacueRadioBtn.IsChecked == true)
            {
                return "babacue";
            }
            else if (tomatoRadioBtn.IsChecked == true)
            {
                return "tomato";
            }
            else
            {
                return "hummas";
            }
        }

        private void viewBtn_Click(object sender, RoutedEventArgs e)
        {
            PizzaDataView win2 = new PizzaDataView();
            win2.Show();
        }

        private void openForm()
        {
            PizzaDataView win2 = new PizzaDataView();
            win2.Show();
        }

        private void clearScreen()
        {
            nameTextBx.Text = "";
            hamTxtInput.Text = "";
            cheeseTxtInput.Text = "";
            porkTxtInput.Text = "";
            bananaTxtInput.Text = "";
            CumcumberTxtInput.Text = "";
            pineAppleTxtInput.Text = "";
            cheeseTxtInput.Text = "";
            pepperoniTxtInput.Text = "";
        }
    }
}
