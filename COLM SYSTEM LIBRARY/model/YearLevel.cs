using COLM_SYSTEM_LIBRARY.datasource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COLM_SYSTEM_LIBRARY.model
{
    public class YearLevel
    {
        public int YearLvlID { get; set; }
        public string EducationLevel { get; set; }
        public string YearLvl { get; set; }
        public int NextYearLvlID { get; set; }

        public static List<YearLevel> GetYearLevels()
        {
            return YearLevel_DS.GetYearLevels();
        }

        public static List<string> GetYearLevelsByEducationLevel(List<YearLevel> yearLevels, string EducationLevel)
        {
            return (from r in yearLevels
                    where r.EducationLevel == EducationLevel
                    select r.YearLvl).Distinct().ToList();
        }

        public static int GetYearLevelID(List<YearLevel> yearLevels, string EducationLevel,string YearLevel)
        {
            return (from r in yearLevels
                    where r.EducationLevel == EducationLevel && r.YearLvl == YearLevel
                    select r.YearLvlID).FirstOrDefault();
        }

        public static List<Section> GetYearLevelSections(int YearLevelID)
        {
            return YearLevel_DS.GetYearLevelSections(YearLevelID);
        }

    }
}
