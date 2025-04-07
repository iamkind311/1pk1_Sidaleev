namespace Task_20_04
{
    internal class Program
    {
        /* Создайте программу для учета транспортных средств. Используйте перечисление VehicleType:
    • Car
    • Bike
    • Bus
    • Truck
    • Motorcycle
    Храните список транспортных средств (можно просто List<VehicleType>).
    Добавьте метод для подсчёта транспорта определённого типа (например, сколько грузовиков).
    Реализуйте поиск по типу и вывод информации*/
        static void Main(string[] args)
        {
            VehicleManager vehicleManager = new VehicleManager();

            vehicleManager.AddVehicle(VehicleType.Car);
            vehicleManager.AddVehicle(VehicleType.Bike);
            vehicleManager.AddVehicle(VehicleType.Truck);
            vehicleManager.AddVehicle(VehicleType.Truck);
            vehicleManager.AddVehicle(VehicleType.Bus);
            vehicleManager.AddVehicle(VehicleType.Motorcycle);

            vehicleManager.ShowVehicles();

            VehicleType searchType = VehicleType.Truck;
            int truckCount = vehicleManager.CountVehicles(searchType);
            Console.WriteLine($"\nКоличество грузовиков: {truckCount}");
        }
        public class VehicleManager
        {
            private List<VehicleType> vehicles = new List<VehicleType>();

            public void AddVehicle(VehicleType vehicle)
            {
                vehicles.Add(vehicle);
                Console.WriteLine($"Добавлено транспортное средство: {vehicle}");
            }

            public int CountVehicles(VehicleType vehicleType)
            {
                int count = 0;
                foreach (var vehicle in vehicles)
                {
                    if (vehicle == vehicleType)
                    {
                        count++;
                    }
                }
                return count;
            }

            public void ShowVehicles()
            {
                Console.WriteLine("\nСписок транспортных средств:");
                foreach (var vehicle in vehicles)
                {
                    Console.WriteLine(vehicle);
                }
            }
        }
    }
}
