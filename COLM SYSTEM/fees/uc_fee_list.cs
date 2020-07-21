using COLM_SYSTEM_LIBRARY.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace COLM_SYSTEM.fees
{
    public partial class uc_fee_list : UserControl
    {
        List<FeeSummary> feeSummaries = Fee.GetFeeSummaries();

        public uc_fee_list()
        {
            InitializeComponent();
            DisplayFeeSummary();
        }

        private void DisplayFeeSummary()
        {
            foreach (var item in feeSummaries)
            {
                dgSummary.Rows.Add(item.EducationLevel,
                    item.YearLevel,
                    item.TotalTFee.ToString("n"),
                    item.TotalMFee.ToString("n"),
                    item.TotalOFee.ToString("n"),
                    item.TotalAFee.ToString("n"));
            }
        }

        private void dgSummary_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            YearLevel yearLevel = YearLevel.GetYearLevel(dgSummary.Rows[e.RowIndex].Cells[0].Value.ToString(), dgSummary.Rows[e.RowIndex].Cells[1].Value.ToString());
            List<Fee> fees = Fee.GetFees(yearLevel.YearLevelID);

            txtEducationLevel.Text = yearLevel.EducationLevel;
            txtYearLevel.Text = yearLevel.YearLvl;

            dgBreakdown.Tag = fees;
            comboBox1.Text = "ALL";
            dgBreakdown.Rows.Clear();

            foreach (var item in fees)
            {
                dgBreakdown.Rows.Add(item.FeeID, item.FeeDesc, item.FeeType, item.Amount.ToString("n"));
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Fee> fees = dgBreakdown.Tag as List<Fee>;

            if (comboBox1.Text == "MISCELLANEOUS FEE")
                FilterBreakDown("MFEE");
            else if (comboBox1.Text == "OTHER FEES")
                FilterBreakDown("OFEE");
            else if (comboBox1.Text == "ADDITIONAL FEE")
                FilterBreakDown("AFEE");
            else
                FilterBreakDown("ALL");
        }

        private void FilterBreakDown(string FeeType)
        {
            List<Fee> fees = dgBreakdown.Tag as List<Fee>;
            dgBreakdown.Rows.Clear();
            if (FeeType != "ALL")
            {
                foreach (var item in fees)
                {
                    if (item.FeeType == FeeType)
                        dgBreakdown.Rows.Add(item.FeeID, item.FeeDesc, item.FeeType, item.Amount.ToString("n"));
                }
            }
            else
            {
                foreach (var item in fees)
                {
                    dgBreakdown.Rows.Add(item.FeeID, item.FeeDesc, item.FeeType, item.Amount.ToString("n"));
                }
            }

        }
    }
}
