using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COLM_SYSTEM_LIBRARY.model
{
    public class Subject
    {
        public int SubjectID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int LecUnit { get; set; }
        public int LabUnit { get; set; }
        public bool IsActive { get; set; }

    }
}
