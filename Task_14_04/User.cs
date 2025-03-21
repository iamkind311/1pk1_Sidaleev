using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14_04
{
    class User
    {
        
        public static User CurrentUser { get; private set; }

        public string Name { get; set; }
        public int Age { get; set; }

        // Метод для установки текущего пользователя
        public static void SetCurrentUser(User user)
        {
            CurrentUser = user;
            Console.WriteLine($"Текущий пользователь установлен: {CurrentUser.Name}, Возраст: {CurrentUser.Age}");
        }
    }
}
