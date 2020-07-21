using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COLM_SYSTEM_LIBRARY.model;

namespace COLM_SYSTEM.Discounts
{
    public partial class uc_discount_list : UserControl
    {
        private List<Discount> _Discounts = new List<Discount>();
        public uc_discount_list()
        {
            InitializeComponent();
            _Discounts = Discount.GetDiscounts();
            DisplayDiscounts();
        }



        private string GetComputation(bool result)
        {
            if (result == true)
                return "Customize";
            else
                return "Default";
        }

        private string IsAmount(double value)
        {
            if (value > 100)
                return value.ToString("n");
            else
                return value.ToString();
        }

        private void DisplayDiscounts()
        {
            foreach (var item in _Discounts)
            {
                dataGridView3.Rows.Add(item.DiscountID, 
                    item.DiscountCode, 
                    item.Type, 
                    IsAmount( item.Value), 
                    GetComputation(item.IsCustomizeComputation),
                    item.TFee, item.MFee,
                    item.OFee, 
                    item.DateCreated);
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int DiscountID = Convert.ToInt32(dataGridView3.Rows[e.RowIndex].Cells[0].Value);
            if (e.ColumnIndex == clmEdit.Index)
            {
                frm_discount_entry frm = new frm_discount_entry(Discount.GetDiscount(DiscountID));
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_discount_entry frm = new frm_discount_entry();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }
    }
}
