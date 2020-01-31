using Management_of_a_coffee_shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Management_of_a_coffee_shop.Data_Acess_Layer_Interfaces
{
    interface CategoryDao
    {
        void addCategory(int category_id, string category_name, double weight, int packets_number, int units_number,double price);
        void deleteCategory(int id);
        void editCategory(CategoryDto category, int id);
        CategoryDto searchByIndex(string search_word);
        List<CategoryDto> getCategory();
        int getCategoryID(string category_name);
        void increaseCategoryWeight(int id, double weight);
        void increaseCategoryNumber(int id, int quantity);

        bool isQuantableCategory(int id);

    }
}
