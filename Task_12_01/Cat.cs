using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_01
{
    class Cat
    {
        public string Name { get; set; }
        public void Meow()
        {
            Console.WriteLine($"{Name} говорит: Мяу!");
        }
    }
}
