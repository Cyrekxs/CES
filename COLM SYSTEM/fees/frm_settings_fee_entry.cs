using COLM_SYSTEM_LIBRARY.model;
using System;
using System.Windows.Forms;

namespace COLM_SYSTEM
{
    public partial class frm_settings_fee_entry : Form
    {
        public frm_settings_fee_entry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtFee.Text))
            {
                MessageBox.Show("Please enter fee", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(cmbFeeType.Text))
            {
                MessageBox.Show("Please enter fee type", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(cmbEducationLevel.Text))
            {
                MessageBox.Show("Please enter education level", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(cmbYearLevel.Text))
            {
                MessageBox.Show("Please enter year level", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(txtFeeAmount.Text))
            {
                MessageBox.Show("Please enter fee amount", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }




            Fee fee = new Fee();
            fee.FeeDesc = txtFee.Text;
            fee.FeeType = cmbFeeType.Text;
            fee.YearLeveLID = YearLevel.GetYearLevel(cmbEducationLevel.Text, cmbYearLevel.Text).YearLevelID;
            fee.Amount = Convert.ToDouble(txtFeeAmount.Text);

            if (Fee.InsertFee(fee) == true)
            {
                MessageBox.Show("Fee has been successfully saved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fee saving failed!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
