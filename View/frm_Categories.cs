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
    public partial class frm_Categories : Form
    {
        public frm_Categories()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            frm_AddCategory frm = new frm_AddCategory();
            frm.Show();
        }
    }
}
