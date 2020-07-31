using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COLM_SYSTEM
{
    public class Utilties
    {
        public static string ConvertToCurrency(double value)
        {
            return value.ToString("c");
        }

        public static int GetActiveSchoolYear()
        {
            return 1;
        }


    }
}
