using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using YearA_Final.Back;
using YearA_Final.Back.Enum;
using YearA_Final.Back.Model;
using YearA_Final.UI.UserControls;

namespace YearA_Final.UI.UserControls
{
    public partial class AddDrinks : UserControl
    {
        private BindingList<Drinks> drinks;
        private int selectedDrinkType;

        public AddDrinks(BindingList<Drinks> drinks, int selectedDrinkType)
        {
            InitializeComponent();
            this.drinks = drinks;
            this.selectedDrinkType = selectedDrinkType;
            InitializeUserControl();
        }

        private void InitializeUserControl()
        {
            switch (selectedDrinkType)
            {
                case (int)eDrinks.Water:
                    handleWater();
                    break;
                case (int)eDrinks.Cola:
                    handleCola();
                    break;
                case (int)eDrinks.Milk:
                    handleMilk();
                    break;
                default:
                    break;
            }
        }

        private void handleCola()
        {
            labelAddZero.Visible = true;
            checkBoxAddZero.Visible = true;
            DateTime timeNow = DateTime.Now;
            timeNow = timeNow.AddYears(4);
            timeNow = timeNow.AddMonths(1);
            timeNow = timeNow.AddDays(12);
            textBoxExpDate.Text = timeNow.ToString("dd/MM/yy");
            textBoxPrice.Text = "13 ₪";
            textBoxCalories.Text = "42 Calories (100 ml)";
        }

        private void handleWater()
        {
            labelAddZero.Visible = false;
            checkBoxAddZero.Visible = false;
            DateTime timeNow = DateTime.Now;
            timeNow = timeNow.AddYears(3);
            timeNow = timeNow.AddMonths(2);
            timeNow = timeNow.AddDays(8);
            textBoxExpDate.Text = timeNow.ToString("dd/MM/yy");
            textBoxPrice.Text = "10 ₪";
            textBoxCalories.Text = "0 Calories (100 ml)";
        }

        private void handleMilk()
        {
            labelAddZero.Visible = false;
            checkBoxAddZero.Visible = false;
            DateTime timeNow = DateTime.Now;
            timeNow = timeNow.AddDays(15);
            textBoxExpDate.Text = timeNow.ToString("dd/MM/yy");
            textBoxPrice.Text = "6.9 ₪";
            textBoxCalories.Text = "55 Calories (100 ml)";
        }

        private void buttonAddDrink_Click(object sender, EventArgs e)
        {
            try
            {
                int quantity = Int32.Parse(textBoxQuantity.Text);
                double finalprice = 0;
                DateTime timeNow = DateTime.Now;
                string drinkType;
                Drinks drink;

                switch (selectedDrinkType)
                {
                    case (int)eDrinks.Water:
                        drinkType = eDrinks.Water.ToString();
                        finalprice = quantity * 10;
                        timeNow = timeNow.AddYears(3);
                        timeNow = timeNow.AddMonths(2);
                        timeNow = timeNow.AddDays(8);
                        break;
                    case (int)eDrinks.Cola:
                        if (checkBoxAddZero.Checked)
                            drinkType = "Cola Zero";
                        else
                            drinkType = eDrinks.Cola.ToString();
                        finalprice = quantity * 13;
                        timeNow = timeNow.AddYears(4);
                        timeNow = timeNow.AddMonths(1);
                        timeNow = timeNow.AddDays(12);
                        break;
                    case (int)eDrinks.Milk:
                        drinkType = eDrinks.Milk.ToString();
                        finalprice = quantity * 6.9;
                        timeNow.AddDays(15);
                        break;
                    default:
                        drinkType = "";
                        break;
                }
                drink = new Drinks(drinkType, timeNow.ToString("dd/MM/yy"), finalprice, drinkType);
                drink.Quantity = quantity;
                drink.Cool = true;

                Cart.AddProducts(drink);
                drinks.Add(drink);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input. Please enter a valid quantity.");
            }
        }

        private void checkBoxAddZero_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAddZero.Checked) { textBoxCalories.Text = "0.3 Calories (100 ml)"; }
            else { textBoxCalories.Text = "42 Calories (100 ml)";  }   


        }
    }
}


