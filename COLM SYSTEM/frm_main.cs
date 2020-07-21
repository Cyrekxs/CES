using COLM_SYSTEM.Discounts;
using System;
using System.Windows.Forms;

namespace COLM_SYSTEM
{
    public partial class frm_main : Form
    {
        //#FF004000 metro studio color use for green

        private void DisplayControl()
        {
            foreach (Control item in PanelMain.Controls)
            {

            }
        }

        public frm_main()
        {
            InitializeComponent();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            uc_discount_list uc = new uc_discount_list();
            uc.Dock = DockStyle.Fill;
            PanelMain.Controls.Add(uc);
        }
    }
}
