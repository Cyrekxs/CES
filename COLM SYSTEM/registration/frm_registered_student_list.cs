using COLM_SYSTEM_LIBRARY.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COLM_SYSTEM.registration
{
    public partial class frm_registered_student_list : Form
    {
        private List<StudentRegistered> _RegisteredStudents = StudentRegistered.GetRegisteredStudents();
        public frm_registered_student_list()
        {
            InitializeComponent();
        }
    }
}
