using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YearA_Final.Back.Model
{
    [Serializable]
    public class Water : Drinks
    {
        public bool EinGedi { get; set; }
        public bool MeyEden { get; set; }

        public Water(string name, string expiryDate, double price,string type,
            bool einGedi = false, bool meyEden = false)            
            : base(name, expiryDate, price, type)
        {
            EinGedi = einGedi;
            MeyEden = meyEden;
        }
        public override double CalcCalories()
        {
            return 0;
        }
    }
}
