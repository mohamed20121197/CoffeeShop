using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Management_of_a_coffee_shop.PAL
{
    public partial class frm_Products : Form
    {
        public frm_Products()
        {
            InitializeComponent();
        }

        private void frm_Products_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            frm_AddProduct frm = new frm_AddProduct();
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            frm_ViewProducts frm = new frm_ViewProducts();
            frm.Show();
        }
    }
}
