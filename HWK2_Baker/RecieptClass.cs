using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWK2_Baker
{
    class RecieptClass
    {
        public int CustomerID { get; set; }
        public int COGQuantity { get; set; }
        public int GearQuantity { get; set; }
        private DateTime SaleDate;
        private double SaleTaxPercent;
        private double CogPrice;
        private double GearPrice;

        public RecieptClass() //Giving Starting values for instances
        {
            CustomerID = 0;
            COGQuantity = 0;
            GearQuantity = 0;
        }
        public
    }
}
