using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YearA_Final.Back.Model
{
    [Serializable]
    public class Cola : Drinks
    {
    public bool IsDiet { get; set; }
    public bool IsCaffeinated { get; set; }

        public Cola(string name, string expiryDate, double price, int ml, string type, bool isDiet, bool isCaffeinated)
                    : base(name, expiryDate, price, type)
        {
        IsDiet = isDiet;
        IsCaffeinated = isCaffeinated;
        }

        public override double CalcCalories()
        {
            double total;
            if (this.IsDiet == false)
            {
                return total = 500 * 0.42;
                //return total;
            }
            else
            {
                return total = 500 * 0.03;
               // return total;
            }
            
        }

    }
}


