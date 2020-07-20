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
        public int YearLeveLID { get; set; }
        public double Value { get; set; }
        public bool IsCustomizeComputation { get; set; }
        public double TFee { get; set; }
        public double MFee { get; set; }
        public double OFee { get; set; }
        public int SchoolYearID { get; set; }
        public DateTime DateCreated { get; set; }

        public static List<Discount> GetDiscounts()
        {
            return Discount_DS.GetDiscounts();
        }

        public static bool InsertDiscount(Discount discount)
        {
            return Discount_DS.InsertDiscount(discount);
        }
    }
}
