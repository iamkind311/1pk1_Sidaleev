namespace Task_23_06
{
    internal class Program
    {
        /* Напишите программу со следующими функциями:
        1. Выведите информации о всех дисках в системе
        2. Выведите содержимое каталога C:\Users (названия папок)
        3. Создайте на диске D папку “work” и всю дальнейшую работу проводите в ней
        a) Создание вложенного каталога “temp”
        b) Вывод информации о текущем каталоге (имя, родитель и тд)
        c) Вывод информации о вложенном каталоге
        4. Переместите каталог “temp” по пути “D:\work\newTemp”
        a) Реализуйте вывод информационного сообщения об успешном (или нет) 
        перемещении
        5. Удалите каталог “D:\work\temp” и выведите сообщение об успешном (или нет) 
        удалении.
        */
        static void Main(string[] args)
        {
            // 1. Вывод информации о всех дисках в системе
            Console.WriteLine("Диски в системе:");
            foreach (var drive in DriveInfo.GetDrives())
            {
                Console.WriteLine($"Имя: {drive.Name}, Тип: {drive.DriveType}, Свободно: {drive.AvailableFreeSpace / (1024 * 1024)} МБ, Общий размер: {drive.TotalSize / (1024 * 1024)} МБ");
            }

            // 2. Вывод содержимого каталога C:\Users
            Console.WriteLine("\nСодержимое каталога C:\\Users:");
            foreach (var dir in Directory.GetDirectories(@"C:\Users"))
            {
                Console.WriteLine(Path.GetFileName(dir));
            }

            // 3. Создание папки D:\work
            string workDir = @"D:\work";
            try
            {
                Directory.CreateDirectory(workDir);
                Console.WriteLine($"\nСоздан каталог: {workDir}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при создании каталога: {ex.Message}");
            }

            // 3a. Создание вложенного каталога “temp”
            string tempDir = Path.Combine(workDir, "temp");
            try
            {
                Directory.CreateDirectory(tempDir);
                Console.WriteLine($"Создан вложенный каталог: {tempDir}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при создании вложенного каталога: {ex.Message}");
            }

            // 3b. Вывод информации о текущем каталоге
            var currentDir = new DirectoryInfo(workDir);
            Console.WriteLine($"\nИнформация о текущем каталоге:");
            Console.WriteLine($"Имя: {currentDir.Name}");
            Console.WriteLine($"Родитель: {currentDir.Parent?.FullName}");
            Console.WriteLine($"Полный путь: {currentDir.FullName}");

            // 3c. Вывод информации о вложенном каталоге
            var tempDirInfo = new DirectoryInfo(tempDir);
            Console.WriteLine($"\nИнформация о вложенном каталоге ‘temp’:");
            Console.WriteLine($"Имя: {tempDirInfo.Name}");
            Console.WriteLine($"Родитель: {tempDirInfo.Parent?.FullName}");
            Console.WriteLine($"Полный путь: {tempDirInfo.FullName}");

            // 4. Перемещение каталога “temp” по пути “D:\work\newTemp”
            string newTempDir = Path.Combine(workDir, "newTemp");
            try
            {
                Directory.Move(tempDir, newTempDir);
                Console.WriteLine($"\nКаталог ‘temp’ успешно перемещён в: {newTempDir}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка перемещения: {ex.Message}");
            }

            // 5. Удаление каталога “D:\work\newTemp”
            try
            {
                Directory.Delete(newTempDir, true);
                Console.WriteLine($"\nКаталог ‘newTemp’ успешно удалён.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка удаления: {ex.Message}");
            }
        }
    }
}
    
