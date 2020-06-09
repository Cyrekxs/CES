using COLM_SYSTEM_LIBRARY.helper;
using COLM_SYSTEM_LIBRARY.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace COLM_SYSTEM.assessment
{
    public partial class frm_assessment : Form
    {
        string EducationLevel = "";
        string YearLevel = "";
        string Section = "";

        private List<Discount> AddedDiscounts = new List<Discount>();

        private void LoadFees()
        {
            EducationLevel = txtEducationLevel.Text;
            YearLevel = txtYearLevel.Text;
            Section = txtSection.Text;

            List<Fee> tfee_list = Fee.GetFeesByType(Enums.FeeTypes.TFee);
            List<Fee> mfee_list = Fee.GetFeesByType(Enums.FeeTypes.MFee);
            List<Fee> ofee_list = Fee.GetFeesByType(Enums.FeeTypes.OFee);

            foreach (var item in tfee_list)
            {
                if (item.EducationLevel == EducationLevel && item.YearLevel == YearLevel)
                    dataGridView1.Rows.Add(item.FeeID, item.FeeDesc, item.Amount);
            }

            foreach (var item in mfee_list)
            {
                if (item.EducationLevel == EducationLevel && item.YearLevel == YearLevel)
                    dataGridView2.Rows.Add(item.FeeID, item.FeeDesc, item.Amount);
            }

            foreach (var item in ofee_list)
            {
                if (item.EducationLevel == EducationLevel && item.YearLevel == YearLevel)
                    dataGridView3.Rows.Add(item.FeeID, item.FeeDesc, item.Amount);
            }
        }

        private void LoadDiscounts()
        {
            List<Discount> discounts = Discount.GetDiscounts();
            cmbDiscount.Tag = discounts;
            foreach (var item in discounts)
            {
                if ((item.EducationLevel == "ALL" && item.YearLevel == "ALL") || (item.EducationLevel == EducationLevel && item.YearLevel == YearLevel) || (item.EducationLevel == EducationLevel && item.YearLevel == "ALL"))
                    cmbDiscount.Items.Add(item.DiscountCode);
            }
        }

        private void LoadAssessmentTypes()
        {
            List<AssessmentType> assessmentTypes = AssessmentType.GetAssessmentTypes();

            cmbAssessmentType.Items.Clear();
            cmbAssessmentType.Tag = assessmentTypes;            
            foreach (var item in assessmentTypes)
            {
                cmbAssessmentType.Items.Add(item.AssessmentCode);
            }
        }

        private void CalculateAssessment()
        {
            
        }

        public frm_assessment()
        {
            InitializeComponent();
            LoadFees();
            LoadDiscounts();
            LoadAssessmentTypes();
        }

        private void btnAddDiscount_Click(object sender, System.EventArgs e)
        {
            List<Discount> discounts = cmbDiscount.Tag as List<Discount>;
            Discount discount = discounts[cmbDiscount.SelectedIndex];
            AddedDiscounts.Add(discount);
            dgDiscounts.Rows.Add(discount.DiscountID, discount.DiscountCode, discount.Type, discount.Value);
        }

        private void cmbAssessmentType_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            List<AssessmentType> assessmentTypes = cmbAssessmentType.Tag as List<AssessmentType>;
            AssessmentType assessmentType = assessmentTypes[cmbAssessmentType.SelectedIndex];
            txtSurcharge.Text = assessmentType.Surcharge.ToString();
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            double TotalTFee = 0;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                TotalTFee += Convert.ToDouble(item.Cells["clmTFeeAmount"].Value);
            }

            double TotalMFee = 0;
            foreach (DataGridViewRow item in dataGridView2.Rows)
            {
                TotalMFee += Convert.ToDouble(item.Cells["clmMFeeAmount"].Value);
            }

            double TotalOFee = 0;
            foreach (DataGridViewRow item in dataGridView3.Rows)
            {
                TotalOFee += Convert.ToDouble(item.Cells["clmOFeeAmount"].Value);
            }

            txtTFee.Text = TotalTFee.ToString();
            txtMFee.Text = TotalMFee.ToString();
            txtOFee.Text = TotalOFee.ToString();
        }
    }
}
