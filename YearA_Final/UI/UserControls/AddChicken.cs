using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YearA_Final.Back;
using YearA_Final.Back.Model;
using YearA_Final.UI.UserControls;

namespace YearA_Final.UI.UserControls
{
    public partial class AddChicken : UserControl
    {
        private BindingList<Chicken> chickens;
        public AddChicken(BindingList<Chicken> chickens)
        {
            InitializeComponent();
            this.chickens = chickens;
            comboBoxChickenType.DataSource = Enum.GetValues(typeof(eChickenType));
        }

        public void buttonAddChicken_Click(object sender, EventArgs e)
        {
            try
            {
                int quantity = Int32.Parse(textBoxQuantity.Text);
                int finalprice;
                DateTime timeNow = DateTime.Now;
                eChickenType chickenType;

                switch (comboBoxChickenType.SelectedIndex)
                {
                    case (int)eChickenType.Breast:
                        chickenType = eChickenType.Breast;
                        finalprice = quantity * 45;
                        timeNow = timeNow.AddDays(16);
                        break;
                    case (int)eChickenType.Wings:
                        chickenType = eChickenType.Wings;
                        finalprice = quantity * 25;
                        timeNow = timeNow.AddDays(10);
                        break;
                    case (int)eChickenType.Thighs:
                        chickenType = eChickenType.Thighs;
                        finalprice = quantity * 60;
                        timeNow = timeNow.AddDays(22);
                        break;
                    default:
                        return;
                }
                Chicken chicken = new Chicken(chickenType.ToString(), timeNow.ToString("dd/MM/yy"), finalprice, 100 * quantity, chickenType.ToString());
                chicken.Quantity = quantity*100;
                chicken.Cool = true;

                Cart.AddProducts(chicken);
                chickens.Add(chicken);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input. Please enter a valid quantity.");
            }
        }

        private void comboBoxChickenType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxChickenType.SelectedIndex)
            {
                case (int)eChickenType.Breast:
                    handleChickenBreast();
                    break;
                case (int)eChickenType.Wings:
                    handleChickenWings();
                    break;
                case (int)eChickenType.Thighs:
                    handleChickenThighs();
                    break;
                default:
                    break;
            }

        }
        private void handleChickenBreast()
        {
            DateTime timeNow = DateTime.Now;
            timeNow = timeNow.AddDays(16);
            string formattedDate = timeNow.ToString("dd/MM/yy");
            textBoxExpDate.Text = formattedDate;
            textBoxPrice.Text = "45 ₪ (100g)";
            textBoxCalories.Text = "168 Calories (100g)";

        }
        private void handleChickenWings()
        {
            DateTime timeNow = DateTime.Now;
            timeNow = timeNow.AddDays(10);
            string formattedDate = timeNow.ToString("dd/MM/yy");
            textBoxExpDate.Text = formattedDate;
            textBoxPrice.Text = "25 ₪ (100g)";
            textBoxCalories.Text = "210 Calories per 100g";

        }
        private void handleChickenThighs()
        {
            DateTime timeNow = DateTime.Now;
            timeNow = timeNow.AddDays(22);
            string formattedDate = timeNow.ToString("dd/MM/yy");
            textBoxExpDate.Text = formattedDate;
            textBoxPrice.Text = "60 ₪ (100g)";
            textBoxCalories.Text = "177 Calories (100g)";
              
        }

    }

}
