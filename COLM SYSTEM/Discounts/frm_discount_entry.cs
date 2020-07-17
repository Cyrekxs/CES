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

        private void button1_Click(object sender, EventArgs e)
        {
            Discount discount = new Discount()
            {
                DiscountCode = txtDiscountCode.Text,
                YearLeveLID = YearLevel.GetYearLevel(cmbEducationLevel.Text, cmbYearLevel.Text).YearLevelID,
                Type = cmbDiscountType.Text,
                Value = Convert.ToDouble(txtDiscountValue.Text),
                TFee = ch_TFee.Checked,
                MFee = ch_MFee.Checked,
                OFee = ch_OFee.Checked,
                SchoolYearID = Utilties.GetActiveSchoolYear()
            };

            Discount.InsertDiscount(discount);

        }

        private void cmbEducationLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadYearLevels();
        }
    }
}
