using Management_of_a_coffee_shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Management_of_a_coffee_shop.Data_Acess_Layer_Interfaces
{
    interface SellsDao
    {
        int calcTotalItemsNumber();
        double calcTotalItemsPrice();
        double calcTotalItemsBenefits();

    }
}
