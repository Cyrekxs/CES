using COLM_SYSTEM_LIBRARY.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace COLM_SYSTEM.Discounts
{
    public partial class uc_discount_list : UserControl
    {
        private List<Discount> _Discounts = new List<Discount>();
        int SelectedRow = 0;
        public uc_discount_list()
        {
            InitializeComponent();
            _Discounts = Discount.GetDiscounts();
            DisplayDiscounts();
        }


        private void DisplayDiscounts()
        {
            dataGridView3.Rows.Clear();
            foreach (var item in _Discounts)
            {
                if (item.Type == "PERCENTAGE")
                    dataGridView3.Rows.Add(item.DiscountID, YearLevel.GetYearLevel(item.YearLeveLID).YearLvl, item.DiscountCode, item.Type, item.TotalValue, item.TFee, item.MFee, item.OFee, item.DateCreated);                    
                else
                    dataGridView3.Rows.Add(item.DiscountID,YearLevel.GetYearLevel(item.YearLeveLID).YearLvl, item.DiscountCode, item.Type, item.TotalValue.ToString("n"), item.TFee * 100, item.MFee * 100, item.OFee * 100, item.DateCreated);
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int DiscountID = Convert.ToInt32(dataGridView3.Rows[e.RowIndex].Cells[0].Value);
            if (e.ColumnIndex == clmEdit.Index)
            {
                cm_actions.Show(dataGridView3,new System.Drawing.Point(MousePosition.X - 270,MousePosition.Y - 120));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cm_discount.Show(button1,new System.Drawing.Point(0,35));
        }

        private void pERCENTAGEDISCOUNTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_discount_entry_percentage frm = new frm_discount_entry_percentage();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
            DisplayDiscounts();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int DiscountID = Convert.ToInt32(dataGridView3.Rows[SelectedRow].Cells[0].Value);
            frm_discount_entry_percentage frm = new frm_discount_entry_percentage(Discount.GetDiscount(DiscountID));
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void dataGridView3_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow = e.RowIndex;
        }
    }
}
