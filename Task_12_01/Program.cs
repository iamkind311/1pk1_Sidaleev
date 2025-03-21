namespace Task_12_01
{
    internal class Program
    {
        /* разобрать прилагаемый проект с сущностями книг - добавить новую функциональность в соответствии с условиями и 
сохранить в репозиторий под названием Task_12_01*/
        static void Main(string[] args)
        {
            Book book1 = new Book();
            var book2 = new Book();
            var book3 = new Book() { title = "Автостопом по галактике", autor = "Дуглас Адамс" };
            Book book4 = new Book() { title = "Хоббит", autor = "Джон Толкин" };


            book1.autor = "Рей Бредберри";
            book1.title = "Марсианские хроники";
            book1.GetInfo();    //Рей Бредберри : Марсианские хроники

            book2.autor = "Джона Роулинг";
            book2.title = "Гарри Поттер и философский камень";
            book2.GetInfo();    //Джона Роулинг : Гарри Поттер и философский камень

            //выдача книги
            book2.GetBoot(); // книга выдана на неделю

            //попытка выдать уже занятую книгу
            book2.GetBoot(); // книга Гарри Поттер и философский камень в данный момент выдана другому читателю

            //class cat и dog
            Cat cat = new Cat() { Name = "Мурка" };
            Dog dog = new Dog { Name = "Шарик" };
            cat.Meow();
            dog.Bark();

            // Journal
            Journal journal = new Journal
            {
                PublicationDate = new DateTime(2023, 10, 1),
                Subject = "Наука и техника",
                Title = "Научный обзор",
                PageCount = 50,
                Price = 300
            };

            journal.ViewContent(); // Просмотр содержания журнала
            journal.Purchase(); // Покупка журнала

            // Пример работы c Newspaper
            Newspaper newspaper = new Newspaper
            {
                PublicationDate = new DateTime(2023, 10, 10),
                Title = "Ежедневные новости",
                MainHeadline = "Новые достижения в науке",
                PageCount = 20,
                Price = 100
            };

            newspaper.ViewContent(); // Просмотр газеты
            newspaper.Purchase(); // Покупка газеты
        }

    }
}
