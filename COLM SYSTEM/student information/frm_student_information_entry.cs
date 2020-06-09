using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COLM_SYSTEM_LIBRARY.model;

namespace COLM_SYSTEM.student_information
{
    public partial class frm_student_information_entry : Form
    {
        public frm_student_information_entry()
        {
            InitializeComponent();
        }


        private bool IsValidData()
        {
            if (string.IsNullOrEmpty(txtLRN.Text))
                err.SetError(txtLRN, "LRN is required!");
            else
                err.SetError(txtLRN, string.Empty);

            if (string.IsNullOrEmpty(txtFirstname.Text))
                err.SetError(txtFirstname, "Firstname is required");
            else
                err.SetError(txtFirstname, string.Empty);

            if (string.IsNullOrEmpty(txtLastname.Text))
                err.SetError(txtLastname, "Lastname is required!");
            else
                err.SetError(txtLastname, string.Empty);

            if (string.IsNullOrEmpty(txtBirthPlace.Text))
                err.SetError(txtBirthPlace, "Birth place is required!");
            else
                err.SetError(txtBirthPlace, string.Empty);

            if (string.IsNullOrEmpty(txtStreet.Text))
                err.SetError(txtStreet, "Please provide the specific address location");
            else
                err.SetError(txtStreet, string.Empty);
           



            bool hasError = false;
            foreach (Control item in err.ContainerControl.Controls)
            {
                string err = this.err.GetError(item);
                if (err != string.Empty)
                {
                    hasError = true;
                    break;
                }
            }

            if (hasError == true)
                return false;
            else
                return true;

        }
        private void button1_Click(object sender, EventArgs e)
        {





            if (IsValidData() == false)
            {
                MessageBox.Show("Please check the errors before proceeding!");
            }

            //StudentInfo student = new StudentInfo()
            //{
            //    LRN = txtLRN.Text,
            //    Lastname = txtLastname.Text,
            //    Firstname = txtFirstname.Text,
            //    Middlename = txtMiddlename.Text,
            //    ExtensionName = txtExtensionName.Text,
            //    BirthDate = txtBirthDate.Value,
            //    BirthPlace = txtBirthPlace.Text,
            //    Street = txtStreet.Text,
            //    Barangay = txtBarangay.Text,
            //    City = txtCity.Text,
            //    Province = txtProvince.Text,
            //    MobileNo = txtMobileNo.Text,
            //    EmailAddress = txtEmailAddress.Text
            //};
        }
    }
}
