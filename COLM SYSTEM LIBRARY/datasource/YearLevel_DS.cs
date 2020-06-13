﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using COLM_SYSTEM_LIBRARY.helper;
using COLM_SYSTEM_LIBRARY.model;

namespace COLM_SYSTEM_LIBRARY.datasource
{
    class YearLevel_DS
    {
        public static List<YearLevel> GetYearLevels()
        {
            List<YearLevel> yearLevels = new List<YearLevel>();
            using (SqlConnection conn = new SqlConnection(Connection.StringConnection))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand("SELECT * FROM tbl_settings_yearlevels ORDER BY YearLevelID ASC", conn))
                {
                    using (SqlDataReader reader = comm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            YearLevel yearLevel = new YearLevel()
                            {
                                YearLvlID = Convert.ToInt32(reader["YearLevelID"]),
                                EducationLevel = Convert.ToString(reader["EducationLevel"]),
                                YearLvl = Convert.ToString(reader["YearLevel"]),
                                NextYearLvlID = Convert.ToInt32(reader["NextYearLevelID"])
                            };
                            yearLevels.Add(yearLevel);
                        }
                    }
                }
            }
            return yearLevels;
        }

        public static List<Section> GetYearLevelSections(int YearLevelID)
        {
            List<Section> sections = new List<Section>();
            using (SqlConnection conn = new SqlConnection(Connection.StringConnection))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand("SELECT * FROM tbl_settings_yearlevel_sections WHERE YearLevelID = @YearLevelID ORDER BY Section ASC", conn))
                {
                    comm.Parameters.AddWithValue("@YearLevelID", YearLevelID);
                    using (SqlDataReader reader = comm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Section section = new Section()
                            {
                                SectionID = Convert.ToInt32(reader["SectionID"]),
                                YearLevelID = Convert.ToInt32(reader["YearLevelID"]),
                                SectionName = Convert.ToString(reader["Section"]),
                                SchoolYearID = Convert.ToInt32(reader["SchoolYearID"]),
                                DateCreated = Convert.ToDateTime(reader["DateCreated"])
                            };
                            sections.Add(section);
                        }
                    }
                }
            }
            return sections;
        }
    }
}