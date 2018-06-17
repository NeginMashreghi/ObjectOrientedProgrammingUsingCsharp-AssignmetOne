using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PizzaApp_Assignment_100973300
{
    public partial class PizzaApp : Form
    {
        private string order;
        private double totalCost;

        public PizzaApp()
        {
            InitializeComponent();
        }

        private void PizzaApp_Load(object sender, EventArgs e)
        {
            

            // tap page Pizza
            this.ComBoxSize.SelectedIndex = 0;
            this.ComBoxCrust.SelectedIndex = 0;
            this.ComBoxSauces.SelectedIndex = 0;
            this.ComBoxSpecialtyPizzas.SelectedIndex = 0;

            // tap page Bavrage
            this.TextBoxSoda.Text = "0";
            this.TextBoxWater.Text = "0";

            // tap page speciality
            this.cmboSpeciality.SelectedIndex = 0;

            // tap page costomer info
            this.textBoxName.Text = " ";
            this.textBoxAddress.Text = " ";
            this.textBoxPhone.Text = " ";
            this.textBoxEmail.Text = " ";

            order = "";
            totalCost = 0;
        }

        private void PlaceOrderButton_Click(object sender, EventArgs e)
        {
            double drinkCost,
                   pizzaCost,
                   specialtyCost;

            

            order = "";

            order += "\nCustomer Info : ";

            order += "\nName : " + textBoxName.Text;
            order += "\n";
            order += "Address : " + textBoxAddress.Text;
            order += "\n";
            order += "Phone Number : " + textBoxPhone.Text;
            order += "\n";
            order += "Email : " + textBoxEmail.Text;

            order += "\n";

            order += ComBoxSize.SelectedItem.ToString();
            order += "\n";
            order += ComBoxCrust.SelectedItem.ToString();
            order += "\n";
            order += ComBoxSauces.SelectedItem.ToString();
            order += "\n";
            order += ComBoxSpecialtyPizzas.SelectedItem.ToString();
            order += "\n";
            

            if (cheBoxToppings.SelectedItems.Count > 0)
            {
                order += "Toppings:";
                foreach (string s in cheBoxToppings.CheckedItems)
                {
                    order += "\n" + s;
                }
            }
            order += "\n";

            pizzaCost = DeterminePizzaCost();
            if (pizzaCost != 0)
            {
                order += "\nPizza Total: " + pizzaCost.ToString("C");
            }

           
            drinkCost = DetermineDrinkCost();

            if (drinkCost != 0)
            {
                order += "\nDrink Total: " + drinkCost;
            }

            specialtyCost = DetermineSpecialtyCost();
            if (specialtyCost != 0)
            {
                order += "\n\nSpecialty Items:\n" + cmboSpeciality.SelectedItem.ToString();
            }

            


            order += "\n\nAmount Due: " + (pizzaCost + drinkCost+ specialtyCost).ToString("C");
            MessageBox.Show(order, "Pizzaaaaaaaaaaaaa\n");
        }

        public double DeterminePizzaCost()
        {
            double cost;

            if (ComBoxSize.SelectedIndex == 0)
            {
                cost = 9.99;
            }
            else
            {
                if (ComBoxSize.SelectedIndex == 1)
                {
                    cost = 12.99;
                }
                else
                {
                    cost = 15.99;
                }
                    
            }
                
            return cost + (cheBoxToppings.CheckedItems.Count * 1.50);
        }

        private double DetermineDrinkCost()
        {
            double sodaCnt,
                   waterCnt;
            totalCost = 0;
           
            if (TextBoxSoda.Text != "")
            {
                while (double.TryParse(TextBoxSoda.Text, out sodaCnt) == false)
                {
                    ErrorBoxSodaWater.Text = "Quantity must be numeric";
                    TextBoxSoda.Text = "0";
                }
                order += "\n\nDrink Selections:\n" + sodaCnt + " soda(s)";
                totalCost = sodaCnt * 1.75;
            }
            if (TextBoxWater.Text != "")
            {
                while (double.TryParse(TextBoxWater.Text, out waterCnt) == false)
                {
                    ErrorBoxSodaWater.Text = "Quantity must be numeric";
                    TextBoxWater.Text = "0";
                }
                order += "\n" + waterCnt + " water(s)";
                order += "\n";
            }
            return totalCost;
        }

        public double DetermineSpecialtyCost()
        {
            double cost;

            if (cmboSpeciality.SelectedIndex == 1)
            {
                cost = 5.00;
            }
            else
                if (cmboSpeciality.SelectedIndex == 2)
            {
                cost = 4.00;
            }
            else
                    if (cmboSpeciality.SelectedIndex == 3)
            {
                cost = 3.00;
            }
            else
                cost = 0;
            return cost ;
        }



        




    }// end class
} // end namespace
