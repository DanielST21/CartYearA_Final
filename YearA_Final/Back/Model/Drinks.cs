using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YearA_Final.Back.Model;

namespace YearA_Final.Back.Model
{
    [Serializable]
    public class Drinks : Category
    {
        public  string Type { get; set; }

        public Drinks(string name, string expiryDate, double price, string type)
            : base(name, expiryDate, price)
        {           
            Type = type;
        }
        public override double CalcCalories()
        {
            return 0;
        }
    }
}
