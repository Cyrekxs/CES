﻿using COLM_SYSTEM_LIBRARY.datasource;
using COLM_SYSTEM_LIBRARY.helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COLM_SYSTEM_LIBRARY.model
{
    public class Fee
    {
        public int FeeID { get; set; }
        public string FeeDesc { get; set; }
        public string FeeType { get; set; }
        public string EducationLevel { get; set; }
        public string YearLevel { get; set; }
        public string Amount { get; set; }
        public int SchoolYearID { get; set; }

        public static bool InsertFee(Fee model)
        {
            return (Fee_DS.InsertFee(model));
        }

        public static List<Fee> GetFees()
        {
            return (Fee_DS.GetFees());
        }

        public static bool UpdateFee(Fee model)
        {
            return (Fee_DS.UpdateFee(model));
        }

        public static List<Fee> GetFeesByType(Enums.FeeTypes type)
        {
            return (Fee_DS.GetFeesByType(type));
        }
    }
}