using Management_of_a_coffee_shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Management_of_a_coffee_shop.Data_Acess_Layer_Interfaces
{
    interface UserDao
    {
        void addUser(String user_name, String full_name, string password, int accessability);
        void deleteUser(int id);
        void EditUser(UserDto user, int id);
        bool checkAccessability(UserDto user);

        List <UserDto> getUsers();
    }

    
}
