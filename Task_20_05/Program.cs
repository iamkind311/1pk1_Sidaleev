namespace Task_20_05
{
    internal class Program
    {
        /* Напишите программу, имитирующую систему авторизации с использованием перечисления AccessLevel:
        • Guest (только чтение)
        • User (чтение + комментарии)
        • Moderator (удаление контента)
        • Admin (полный доступ)
        Создайте метод, который проверяет, может ли пользователь выполнить действие (например, удалить пост).
        На основе уровня доступа выводите сообщение (например, "Ошибка: Недостаточно прав!")*/
        static void Main(string[] args)
        {
            AuthorizationSystem user1 = new AuthorizationSystem(AccessLevel.Guest);
            user1.PerformAction("delete post"); // Ошибка: Недостаточно прав для удаления поста!

            AuthorizationSystem user2 = new AuthorizationSystem(AccessLevel.Moderator);
            user2.PerformAction("delete post"); // Пост успешно удалён!

            AuthorizationSystem user3 = new AuthorizationSystem(AccessLevel.User);
            user3.PerformAction("comment"); // Комментарий успешно добавлен!
        }
    
        public class AuthorizationSystem
        {
            public AccessLevel UserAccessLevel { get; private set; }

            public AuthorizationSystem(AccessLevel accessLevel)
            {
                UserAccessLevel = accessLevel;
            }

            public void PerformAction(string action)
            {
                switch (action.ToLower())
                {
                    case "delete post":
                        if (UserAccessLevel < AccessLevel.Moderator)
                        {
                            Console.WriteLine("Ошибка: Недостаточно прав для удаления поста!");
                        }
                        else
                        {
                            Console.WriteLine("Пост успешно удалён!");
                        }
                        break;

                    case "comment":
                        if (UserAccessLevel < AccessLevel.User)
                        {
                            Console.WriteLine("Ошибка: Недостаточно прав для добавления комментария!");
                        }
                        else
                        {
                            Console.WriteLine("Комментарий успешно добавлен!");
                        }
                        break;

                    default:
                        Console.WriteLine("Действие не распознано.");
                        break;
                }
            }
        }
    }
}      
        
