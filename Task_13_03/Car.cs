using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_03
{
    class Car
    {
        public string LicensePlate { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public double CurrentSpeed { get; private set; } // Текущая скорость

        // по умолчанию
        public Car()
        {
            LicensePlate = "Неизвестно";
            Brand = "Неизвестно";
            Color = "Неизвестно";
            CurrentSpeed = 0.0;
        }

        // с параметрами
        public Car(string licensePlate, string brand, string color)
        {
            LicensePlate = licensePlate;
            Brand = brand;
            Color = color;
            CurrentSpeed = 0.0; // Начальная скорость
        }

        // Метод для езды 
        public void Drive(double acceleration)
        {
            CurrentSpeed += acceleration;
            Console.WriteLine($"Автомобиль {Brand} разгоняется. Текущая скорость: {CurrentSpeed} км/ч.");
        }

        // Метод для торможения
        public void Brake(double maxSpeed)
        {
            if (CurrentSpeed > maxSpeed)
            {
                CurrentSpeed = 0.0;
                Console.WriteLine($"Автомобиль {Brand} остановился из-за превышения скорости!");
            }
            else
            {
                Console.WriteLine($"Автомобиль {Brand} тормозит. Текущая скорость: {CurrentSpeed} км/ч.");
            }
        }
    }
}

