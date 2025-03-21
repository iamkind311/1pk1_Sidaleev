using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_01
{
    class Dog
    {
        public string Name { get; set; }
        public void Bark()
        {
            Console.WriteLine($"{Name} говорит: Гав!");
        }
    }
}
