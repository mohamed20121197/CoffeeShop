using Management_of_a_coffee_shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Management_of_a_coffee_shop.Data_Acess_Layer_Interfaces
{
    interface BillDao
    {
        void addBill(int bill_id, int products_number, double total_cost, double benefit,string user_name, DateTime date);
        void deleteBill(int id);
        BillDto searchByIndex(string search_word);
        List<BillDto> getBill();
    }
}
