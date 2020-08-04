using COLM_SYSTEM.Discounts;
using COLM_SYSTEM.fees;
using COLM_SYSTEM.subject;
using System;
using System.Windows.Forms;

namespace COLM_SYSTEM
{
    public partial class frm_main : Form
    {
        //#FF004000 metro studio color use for green

        private void DisplayControl(UserControl uc)
        {
            //remove all user controls in panel main first before display new user control
            foreach (UserControl item in PanelMain.Controls)
            {
                PanelMain.Controls.Remove(item);
            }

            uc.Dock = DockStyle.Fill;
            PanelMain.Controls.Add(uc);
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
            DisplayControl(new uc_discount_list());
            //uc_discount_list uc = new uc_discount_list();
            //uc.Dock = DockStyle.Fill;
            //PanelMain.Controls.Add(uc);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DisplayControl(new uc_fee_list());
            //uc_fee_list uc = new uc_fee_list();
            //uc.Dock = DockStyle.Fill;
            //PanelMain.Controls.Add(uc);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DisplayControl(new uc_subject_list());
        }
    }
}
