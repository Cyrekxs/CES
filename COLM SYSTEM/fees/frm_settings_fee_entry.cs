using COLM_SYSTEM_LIBRARY.model;
using System;
using System.Windows.Forms;
using static COLM_SYSTEM_LIBRARY.helper.Enums;

namespace COLM_SYSTEM
{
    public partial class frm_settings_fee_entry : Form
    {
        private SavingOptions savingstatus = new SavingOptions();
        private Fee _Fee = new Fee();

        public frm_settings_fee_entry()
        {
            InitializeComponent();
        }

        public frm_settings_fee_entry(Fee fee)
        {
            InitializeComponent();
            _Fee = fee;
            YearLevel yearLevel = YearLevel.GetYearLevel(fee.YearLeveLID);

            txtFee.Text = fee.FeeDesc;
            txtFeeAmount.Text = fee.Amount.ToString("n");
            cmbFeeType.Text = fee.FeeType;
            cmbEducationLevel.Text = yearLevel.EducationLevel;
            cmbYearLevel.Text = yearLevel.YearLvl;
        }

        private void CheckErrors()
        {
            if (string.IsNullOrEmpty(txtFee.Text))
                er.SetError(txtFee, "Please provide fee description!");
            else
                er.SetError(txtFee, "");

            if (string.IsNullOrEmpty(cmbFeeType.Text))
                er.SetError(cmbFeeType, "Please select fee type!");
            else
                er.SetError(cmbFeeType, "");


            if (string.IsNullOrEmpty(cmbEducationLevel.Text))
                er.SetError(cmbEducationLevel, "Please select education level!");
            else
                er.SetError(cmbEducationLevel, "");


            if (string.IsNullOrEmpty(cmbYearLevel.Text))
                er.SetError(cmbYearLevel, "Please select year level");
            else
                er.SetError(cmbYearLevel, "");

            if (string.IsNullOrEmpty(txtFeeAmount.Text))
                er.SetError(txtFeeAmount, "Please enter amount!");
            else
                er.SetError(txtFeeAmount, "");
        }

        private bool HasError()
        {
            CheckErrors();
            bool result = false;
            foreach (Control item in Controls)
            {
                if (string.IsNullOrEmpty(er.GetError(item)) == false)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        private string FormatFeeType(string FeeType)
        {
            if (FeeType.ToLower() == "tuition fee")
                return "TFEE";
            else if (FeeType.ToLower() == "miscellaneous fee")
                return "MFEE";
            else if (FeeType.ToLower() == "other fee")
                return "OFEE";
            else if (FeeType.ToLower() == "additional fee")
                return "AFEE";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (HasError() == true)
            {
                MessageBox.Show("Errors detected!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Fee fee = new Fee();
            fee.FeeDesc = txtFee.Text;
            fee.FeeType = cmbFeeType.Text;
            fee.YearLeveLID = YearLevel.GetYearLevel(cmbEducationLevel.Text, cmbYearLevel.Text).YearLevelID;
            fee.Amount = Convert.ToDouble(txtFeeAmount.Text);


            bool result = false;

            if (savingstatus == SavingOptions.INSERT)
                result = Fee.InsertFee(fee);
            else
            {
                fee.FeeID = _Fee.FeeID;
                result = Fee.UpdateFee(fee);
            }


            if (result == true)
                MessageBox.Show("Fee has been successfully saved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Fee saving failed!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
