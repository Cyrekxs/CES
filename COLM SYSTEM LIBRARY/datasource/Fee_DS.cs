using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using COLM_SYSTEM_LIBRARY.helper;
using COLM_SYSTEM_LIBRARY.model;
namespace COLM_SYSTEM_LIBRARY.datasource
{
    class Fee_DS
    {

        public static List<Fee> GetFees()
        {
            List<Fee> fees = new List<Fee>();
            using (SqlConnection conn = new SqlConnection(Connection.StringConnection))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand("SELECT * FROM tbl_settings_fees ORDER BY Type ASC", conn))
                {
                    using (SqlDataReader reader = comm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Fee fee = new Fee()
                            {
                                FeeID = Convert.ToInt32(reader["FeeID"]),
                                FeeDesc = Convert.ToString(reader["Fee"]),
                                FeeType = Convert.ToString(reader["Type"]),
                                YearLeveLID = Convert.ToInt16(reader["YearLevelID"]),
                                Amount = Convert.ToDouble(reader["Amount"]),
                                SchoolYearID = Convert.ToInt32(reader["SchoolYearID"])
                            };
                            fees.Add(fee);
                        }
                    }
                }
            }
            return fees;
        }

        public static List<Fee> GetFeesByType(Enums.FeeTypes type)
        {
            List<Fee> fees = new List<Fee>();
            using (SqlConnection conn = new SqlConnection(Connection.StringConnection))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand("SELECT * FROM tbl_settings_fees WHERE Type = @Type", conn))
                {
                    if (type == Enums.FeeTypes.TFee)
                        comm.Parameters.AddWithValue("@Type", "TFEE");
                    else if (type == Enums.FeeTypes.MFee)
                        comm.Parameters.AddWithValue("@Type", "MFEE");
                    else if (type == Enums.FeeTypes.OFee)
                        comm.Parameters.AddWithValue("@Type", "OFEE");
                    else if (type == Enums.FeeTypes.AFee)
                        comm.Parameters.AddWithValue("@Type", "AFEE");
                    else
                        comm.Parameters.AddWithValue("@Type", "");

                    using (SqlDataReader reader = comm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Fee fee = new Fee()
                            {
                                FeeID = Convert.ToInt32(reader["FeeID"]),
                                FeeDesc = Convert.ToString(reader["Fee"]),
                                FeeType = Convert.ToString(reader["Type"]),
                                YearLeveLID = Convert.ToInt16(reader["YearLevelID"]),
                                Amount = Convert.ToDouble(reader["Amount"]),
                                SchoolYearID = Convert.ToInt32(reader["SchoolYearID"])
                            };
                            fees.Add(fee);
                        }
                    }
                }
            }
            return fees;
        }



        public static bool InsertFee(Fee model)
        {
            int result = 0;
            using (SqlConnection conn = new SqlConnection(Connection.StringConnection))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand("INSERT INTO tbl_settings_fees VALUES (@Fee,@Type,@Amount,@EducationLevel,@YearLevel,@SchoolYearID,GETDATE())", conn))
                {
                    comm.Parameters.AddWithValue("@Fee", model.FeeDesc);
                    comm.Parameters.AddWithValue("@Type", model.FeeType);
                    comm.Parameters.AddWithValue("@amount", model.Amount);
                    comm.Parameters.AddWithValue("@YearLevel", model.YearLeveLID);
                    comm.Parameters.AddWithValue("@SchoolYearID", model.SchoolYearID);
                    result = comm.ExecuteNonQuery();
                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }
        }

        public static bool UpdateFee(Fee model)
        {
            int result = 0;
            using (SqlConnection conn = new SqlConnection(Connection.StringConnection))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand("UPDATE tbl_settings_fees SET Fee = @Fee, Type = @Type, Amount = @Amount, EducationLevel = @EducationLevel, YearLevel = @YearLevel WHERE FeeID = @FeeID", conn))
                {
                    comm.Parameters.AddWithValue("@FeeID", model.FeeID);
                    comm.Parameters.AddWithValue("@Fee", model.FeeDesc);
                    comm.Parameters.AddWithValue("@Type", model.FeeType);
                    comm.Parameters.AddWithValue("@amount", model.Amount);
                    comm.Parameters.AddWithValue("@YearLevel", model.YearLeveLID);
                    comm.Parameters.AddWithValue("@SchoolYearID", model.SchoolYearID);
                    result = comm.ExecuteNonQuery();
                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }
        }

    }
}
