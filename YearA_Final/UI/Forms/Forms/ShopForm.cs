using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YearA_Final.Back;
using YearA_Final.Back.Enum;
using YearA_Final.Back.Model;
using YearA_Final.UI.UserControls;


namespace YearA_Final
{
    public partial class ShopForm : Form
    {
        public ShopForm()
        {
            InitializeComponent();
            comboBoxChooseProduct.DataSource = Enum.GetValues(typeof(eCategory));
        }
        public void PopulateCartView()
        {
            dataGridCart.DataSource = null;
            dataGridCart.DataSource = Cart.products;
        }
        private void comboBoxChooseProduct_SelectedItemChanged(object sender, EventArgs e)
        {
            panelAddUserControl.Controls.Clear();

            switch (comboBoxChooseProduct.SelectedIndex)
            {
                case (int)eCategory.Food:
                    panelAddUserControl.Controls.Clear();
                    foodCatHandle();
                    break;
                case (int)eCategory.Drinks:
                    panelAddUserControl.Controls.Clear();
                    drinksCatHandle();
                    break;
                case (int)eCategory.None:
                    panelAddUserControl.Controls.Clear();
                    comboBoxByCatgeory.Visible = false;
                    break;
                default:
                    break;
            }

            PopulateCartView();
        }


        private void comboBoxByCatgeory_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxChooseProduct.SelectedIndex == (int)eCategory.Food)
            {
                switch (comboBoxByCatgeory.SelectedItem.ToString())
                {
                    case "Choose":
                        chooseHandle();
                        break;
                    case "Bread":
                        breadHandle();
                        break;
                    case "Chicken":
                        chickenHandle();
                        break;
                    default:
                        break;

                }
            }
            else if (comboBoxChooseProduct.SelectedIndex == (int)eCategory.Drinks)
                {
                    int selectedDrinkType = (int)comboBoxByCatgeory.SelectedItem;
                    AddDrinks addDrinksControl = new AddDrinks(Cart.GetProductsByType<Drinks>(), selectedDrinkType);
                    panelAddUserControl.Controls.Clear();
                    panelAddUserControl.Controls.Add(addDrinksControl);
                }
       
            PopulateCartView();
        }

        private void chooseHandle()
        {
            panelAddUserControl.Controls.Clear();

        }

        private void foodCatHandle()
        {
            comboBoxByCatgeory.Visible = true;
            comboBoxByCatgeory.DataSource = Enum.GetValues(typeof(eFood));
        }

        private void drinksCatHandle()
        {
            comboBoxByCatgeory.Visible = true;
            comboBoxByCatgeory.DataSource = Enum.GetValues(typeof(eDrinks));
            panelAddUserControl.Controls.Clear();
            BindingList<Drinks> drinksList = Cart.GetProductsByType<Drinks>();
            int selectedDrinkType = (int)comboBoxByCatgeory.SelectedItem;
            AddDrinks addDrinksControl = new AddDrinks(drinksList, selectedDrinkType);
            addDrinksControl.BringToFront();
            panelAddUserControl.Controls.Add(addDrinksControl);
            dataGridCart.DataSource = drinksList;
            dataGridCart.Refresh();

        }


        private void chickenHandle()
        {
            panelAddUserControl.Controls.Clear();
            MessageBox.Show("Please pay attention, quantity in 100 Grams per unit.");
            BindingList<Chicken> chickenList = Cart.GetProductsByType<Chicken>();
            AddChicken addChickenControl = new AddChicken(chickenList);
            panelAddUserControl.Controls.Add(addChickenControl);
            dataGridCart.DataSource = chickenList;
            dataGridCart.Refresh();
        }

        private void breadHandle()
        {
            panelAddUserControl.Controls.Clear();

        }

        private void ShopForm_Load(object sender, EventArgs e)
        {
            PopulateCartView();
        }

        private void gridSaveButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(dataGridCart.DataSource);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileInfo fileInfo = new FileInfo("Products.txt");
            using (FileStream fileStream = new FileStream("Products.txt", FileMode.Create))
            {
                binaryFormatter.Serialize(fileStream, dataGridCart.DataSource);
            }

        }
    }
}
