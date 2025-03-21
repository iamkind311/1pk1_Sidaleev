using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_02
{
    class Pet
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public bool IsHealthy { get; set; } 

        // Конструктор по умолчанию
        public Pet()
        {
            Name = "Неизвестно";
            Species = "Неизвестно";
            Age = 0;
            Weight = 0.0;
            IsHealthy = true;
        }

        // Конструктор с параметрами
        public Pet(string name, string species, int age, double weight, bool isHealthy)
        {
            Name = name;
            Species = species;
            Age = age;
            Weight = weight;
            IsHealthy = isHealthy;
        }

        // Метод для вывода информации о питомце
        public void ShowInfo()
        {
            Console.WriteLine($"Кличка: {Name}, Вид: {Species}, Возраст: {Age} лет, Вес: {Weight} кг, Состояние здоровья: {(IsHealthy ? "Здоров" : "Нездоров")}");
        }

        // Метод для изменения веса
        public void ChangeWeight(double newWeight)
        {
            Weight = newWeight;
            Console.WriteLine($"Вес питомца {Name} изменён на {Weight} кг.");
        }

        // Метод для изменения здоровья
        public void ChangeHealthStatus(bool healthStatus)
        {
            IsHealthy = healthStatus;
            Console.WriteLine($"Состояние здоровья питомца {Name} изменено на {(IsHealthy ? "Здоров" : "Нездоров")}");
        }
    }
}
