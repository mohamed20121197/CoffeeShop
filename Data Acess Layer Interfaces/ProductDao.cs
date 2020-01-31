using Management_of_a_coffee_shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Management_of_a_coffee_shop.Data_Acess_Layer_Interfaces
{
    interface ProductDao
    {
        void addProduct(int product_id, string product_name, double cost, double price);
        void deleteProduct(int id);
        void editProduct(ProductDto product, int id);
        ProductDto searchByIndex(string search_word);
        List<ProductDto> getProducts();
        List<ProductDto> getIngrediants();
    }
}
