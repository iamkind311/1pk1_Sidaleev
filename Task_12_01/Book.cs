using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_01
{
    class Book
    {
        public string title { get; set; }
        public string autor { get; set; }
        private bool isIssued; //выдана или свободна

        // вывод информации о книге
        public void GetInfo()
        {
            Console.WriteLine($"{autor} : {title}");
        }

        // выдачи книги
        public void GetBoot()
        {
            if (!isIssued)
            {
                isIssued = true;
                Console.WriteLine("Книга выдана на неделю");
            }
            else
            {
                Console.WriteLine($"Книга {title} в данный момент выдана другому читателю");
            }
        }

        // возврат книги
        public void ReturnBook()
        {
            if (isIssued)
            {
                isIssued = false;
                Console.WriteLine($"Книга {title} возвращена и теперь свободна.");
            }
            else
            {
                Console.WriteLine($"Книга {title} уже свободна.");
            }
        }
    }
}
