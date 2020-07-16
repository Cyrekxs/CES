using COLM_SYSTEM_LIBRARY.datasource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COLM_SYSTEM_LIBRARY.model
{
    public class Discount
    {
        public int DiscountID { get; set; }
        public string DiscountCode { get; set; }
        public string Type { get; set; }
        public string YearLeveLID { get; set; }
        public double Value { get; set; }
        public bool TFee { get; set; }
        public bool MFee { get; set; }
        public bool OFee { get; set; }
        public int SchoolYearID { get; set; }
        public DateTime DateCreated { get; set; }

        public static List<Discount> GetDiscounts()
        {
            return Discount_DS.GetDiscounts();
        }
    }
}
