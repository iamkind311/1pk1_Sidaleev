namespace Task_14_04
{
    internal class Program
    {
        /*Определите класс User, который будет иметь статическое свойство CurrentUser, представляющее текущего 
пользователя, и метод для его установки*/
        static void Main(string[] args)
        {

            
            User user1 = new User { Name = "Алекс", Age = 30 };
            User user2 = new User { Name = "Мария", Age = 25 };

            
            User.SetCurrentUser(user1); // Устанавливаем user1 как текущего пользователя

            
            Console.WriteLine($"Текущий пользователь: {User.CurrentUser.Name}, Возраст: {User.CurrentUser.Age}");

            
            User.SetCurrentUser(user2); // Устанавливаем user2 как текущего пользователя

            
            Console.WriteLine($"Текущий пользователь: {User.CurrentUser.Name}, Возраст: {User.CurrentUser.Age}");
        }
    }
    
}
