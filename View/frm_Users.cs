﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Management_of_a_coffee_shop.PAL
{
    public partial class frm_Users : Form
    {
        public frm_Users()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            frm_AddUser frm = new frm_AddUser();
            frm.Show();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }
    }
}
