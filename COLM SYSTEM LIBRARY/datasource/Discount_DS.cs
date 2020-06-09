﻿using COLM_SYSTEM_LIBRARY.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using COLM_SYSTEM_LIBRARY.helper;
namespace COLM_SYSTEM_LIBRARY.datasource
{
    class Discount_DS
    {
        public static List<Discount> GetDiscounts()
        {
            List<Discount> discounts = new List<Discount>();
            using (SqlConnection conn = new SqlConnection(Connection.StringConnection))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand("SELECT * FROM tbl_settings_discounts ORDER BY DateCreated ASC", conn))
                {
                    using (SqlDataReader reader = comm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Discount discount = new Discount()
                            {
                                DiscountID = Convert.ToInt32(reader["DiscountID"]),
                                DiscountCode = Convert.ToString(reader["Discount"]),
                                EducationLevel = Convert.ToString(reader["EducationLevel"]),
                                YearLevel = Convert.ToString(reader["YearLevel"]),
                                Type = Convert.ToString(reader["Type"]),
                                Value = Convert.ToDouble(reader["Value"]),
                                TFee = Convert.ToBoolean(reader["TFee"]),
                                MFee = Convert.ToBoolean(reader["MFee"]),
                                OFee = Convert.ToBoolean(reader["OFee"]),
                                SchoolYearID = Convert.ToInt32(reader["SchoolYearID"]),
                                DateCreated = Convert.ToDateTime(reader["DateCreated"])
                            };
                            discounts.Add(discount);
                        }
                    }
                }
            }
            return discounts;
        }

        public static bool InsertDiscount(Discount model)
        {
            using (SqlConnection conn = new SqlConnection(Connection.StringConnection))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand("INSERT INTO tbl_settings_discounts VALUES (@EducationLevel,@YearLevel,@DiscountCode,@Type,@Value,@TFee,@MFee,@OFee,@SchoolYearID,GETDATE())", conn))
                {
                    comm.Parameters.AddWithValue("@EducationLevel", model.EducationLevel);
                    comm.Parameters.AddWithValue("@YearLevel", model.YearLevel);
                    comm.Parameters.AddWithValue("@DiscountCode", model.DiscountCode);
                    comm.Parameters.AddWithValue("@Type", model.Type);
                    comm.Parameters.AddWithValue("@Value", model.Value);
                    comm.Parameters.AddWithValue("@TFee", model.TFee);
                    comm.Parameters.AddWithValue("@MFee", model.MFee);
                    comm.Parameters.AddWithValue("@OFee", model.OFee);
                    comm.Parameters.AddWithValue("@SchoolYearID", model.SchoolYearID);
                    if (comm.ExecuteNonQuery() > 0)
                        return true;
                    else
                        return false;
                }
            }
        }
    }
}
