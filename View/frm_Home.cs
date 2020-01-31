using Management_of_a_coffee_shop.View;
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
    public partial class frm_Home : Form
    {
        public frm_Home()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frm_Home_Load(object sender, EventArgs e)
        {

        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
          
        }

        private void button12_Click(object sender, EventArgs e)
        {
            frm_AddUser frm = new frm_AddUser();
            frm.Show();

        }

        private void btn_IncreaseCategory_Click(object sender, EventArgs e)
        {
            frm_BuyCategory frm = new frm_BuyCategory();
            frm.Show();
        }

        private void btn_AddCategory_Click(object sender, EventArgs e)
        {
            frm_AddCategory frm = new frm_AddCategory();
            frm.Show();
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            frm_AddProduct frm = new frm_AddProduct();
            frm.Show();
        }

        private void btn_SellingBill_Click(object sender, EventArgs e)
        {
            frm_SellingBill frm = new frm_SellingBill();
            frm.Show();
        }

        private void btn_ViewCategories_Click(object sender, EventArgs e)
        {
            frm_ViewCategories frm = new frm_ViewCategories();
            frm.Show();

        }

        private void btn_ViewProducts_Click(object sender, EventArgs e)
        {
            frm_ViewProducts frm = new frm_ViewProducts();
            frm.Show();

        }

        private void btn_ViewBills_Click(object sender, EventArgs e)
        {
            frm_ViewSellingBills frm = new frm_ViewSellingBills();
            frm.Show();

        }

        private void Btn_Categories_Click(object sender, EventArgs e)
        {
            frm_ViewCategories frm = new frm_ViewCategories();
            frm.Show();
        }

        private void btn_Products_Click(object sender, EventArgs e)
        {

            frm_ViewProducts frm = new frm_ViewProducts();
            frm.Show();
        }

        private void btn_Sells_Click(object sender, EventArgs e)
        {
            frm_Sells frm = new frm_Sells();
            frm.Show();

        }

        private void btn_Users_Click(object sender, EventArgs e)
        {
            frm_Users frm = new frm_Users();
            frm.Show();

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            frm_Login frm = new frm_Login();
            frm.Show();

        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {
            
        }
    }
}
