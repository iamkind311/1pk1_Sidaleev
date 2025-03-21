using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_01
{
    class Journal
    {
        public DateTime PublicationDate { get; set; }
        public string Subject { get; set; }
        public string Title { get; set; }
        public int PageCount { get; set; }
        public decimal Price { get; set; }

        // Метод для покупки журнала
        public void Purchase()
        {
            Console.WriteLine($"Вы купили журнал '{Title}' за {Price} рублей.");
        }

        // Метод для просмотра содержания журнала
        public void ViewContent()
        {
            Console.WriteLine($"Содержание журнала '{Title}':");
            Console.WriteLine($"Дата издания: {PublicationDate.ToShortDateString()}");
            Console.WriteLine($"Предметная направленность: {Subject}");
            Console.WriteLine($"Количество страниц: {PageCount}");
            Console.WriteLine($"Цена: {Price} рублей");
        }
    }

    internal class Newspaper
    {
        public DateTime PublicationDate { get; set; }
        public string Title { get; set; }
        public string MainHeadline { get; set; }
        public int PageCount { get; set; }
        public decimal Price { get; set; }

        // Метод для покупки газеты
        public void Purchase()
        {
            Console.WriteLine($"Вы купили газету '{Title}' за {Price} рублей.");
        }

        // Метод для просмотра содержания газеты
        public void ViewContent()
        {
            Console.WriteLine($"Содержание газеты '{Title}':");
            Console.WriteLine($"Дата издания: {PublicationDate.ToShortDateString()}");
            Console.WriteLine($"Заголовок главной полосы: {MainHeadline}");
            Console.WriteLine($"Количество страниц: {PageCount}");
            Console.WriteLine($"Цена: {Price} рублей");
        }
    }

    
}
