using COLM_SYSTEM_LIBRARY.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace COLM_SYSTEM.Discounts
{
    public partial class frm_discount_entry : Form
    {
        public frm_discount_entry()
        {
            InitializeComponent();
        }

        private void LoadYearLevels()
        {

            List<YearLevel> yearLevels = YearLevel.GetYearLevelsByEducationLevel(cmbEducationLevel.Text);

            cmbYearLevel.Items.Clear();
            foreach (var item in yearLevels)
            {
                cmbYearLevel.Items.Add(item.YearLvl);
            }
        }

        private void CheckErrors()
        {
            if (string.IsNullOrEmpty(txtDiscountCode.Text))
                er.SetError(txtDiscountCode, "Please enter value");
            else
                er.SetError(txtDiscountCode, "");

            if (string.IsNullOrEmpty(cmbEducationLevel.Text))
                er.SetError(cmbEducationLevel, "Please select education level");
            else
                er.SetError(cmbEducationLevel, "");

            if (string.IsNullOrEmpty(cmbYearLevel.Text))
                er.SetError(cmbYearLevel, "Please select year level");
            else
                er.SetError(cmbEducationLevel, "");


            if (string.IsNullOrEmpty(cmbDiscountType.Text))
                er.SetError(cmbDiscountType, "Please select discount type");
            else
                er.SetError(cmbDiscountType, "");

            if (string.IsNullOrEmpty(maskedTextBox1.Text))
                er.SetError(maskedTextBox1, "Please provide a discount value");
            else
                er.SetError(maskedTextBox1, "");
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

        private void button1_Click(object sender, EventArgs e)
        {

            if (HasError() == true)
            {
                MessageBox.Show("Errors detected!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (Convert.ToDouble(lblRemaining.Text) > 0)
            {
                MessageBox.Show("The remaining percentage must be zero in order to compute the discount exact!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            Discount discount = new Discount()
            {
                DiscountCode = txtDiscountCode.Text,
                YearLeveLID = YearLevel.GetYearLevel(cmbEducationLevel.Text, cmbYearLevel.Text).YearLevelID,
                Type = cmbDiscountType.Text,
                Value = Convert.ToDouble(maskedTextBox1.Text),
                IsCustomizeComputation = ch_customize.Checked,
                TFee = Convert.ToDouble(txtTFee.Text),
                MFee = Convert.ToDouble(txtMFee.Text),
                OFee = Convert.ToDouble(txtOFee.Text),
                SchoolYearID = Utilties.GetActiveSchoolYear()
            };

            bool result = Discount.InsertDiscount(discount);

            if (result == true)
            {
                MessageBox.Show("Discount has been successfully saved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                Dispose();
            }
            else
            {
                MessageBox.Show("Some error occured while trying to save discount in database!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbEducationLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadYearLevels();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double discount_value = 0;
            double tfee_value = 0;
            double mfee_value = 0;
            double ofee_value = 0;

            try
            {
                discount_value = Convert.ToDouble(maskedTextBox1.Text);
                tfee_value = Convert.ToDouble(txtTFee.Text);
                mfee_value = Convert.ToDouble(txtMFee.Text);
                ofee_value = Convert.ToDouble(txtOFee.Text);
            }
            catch (Exception)
            {

            }

            discount_value = discount_value - (tfee_value + mfee_value + ofee_value);

            if (ch_customize.Checked == true)
                lblRemaining.Text = discount_value.ToString();
            else
                lblRemaining.Text = "0";

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (ch_TFee.Checked == true)
            {
                txtTFee.Enabled = true;
            }
            else
            {
                txtTFee.Enabled = false;
                txtTFee.Text = 0.ToString();
            }


            if (ch_MFee.Checked == true)
            {
                txtMFee.Enabled = true;
            }
            else
            {
                txtMFee.Enabled = false;
                txtMFee.Text = 0.ToString();
            }

            if (ch_OFee.Checked == true)
            {
                txtOFee.Enabled = true;
            }
            else
            {
                txtOFee.Enabled = false;
                txtOFee.Text = 0.ToString();
            }
        }

        private void ch_customize_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_customize.Checked == true)
                groupBox1.Enabled = true;
            else
                groupBox1.Enabled = false;

            txtTFee.Text = "0";
            txtMFee.Text = "0";
            txtOFee.Text = "0";
        }
    }
}
