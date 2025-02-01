namespace Task_02_04
{
    internal class Program
    {
        /* Пользователь вводит свою дату рождения построчно (сначала год, потом месяц и в конце дату) произведите
        * расчет является ли пользователь совершеннолетним на текущую дату и выведите соответствующее сообщение об
        * этом. */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год своего рождения: ");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите месяц рождения: ");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите день рождения: ");
            int day = int.Parse(Console.ReadLine());

            DateTime birthdate = new DateTime(year, month, day);
            DateTime currentdate = DateTime.Now;

            int age = currentdate.Year - birthdate.Year;
            if (currentdate < birthdate.AddYears(age))
            {
                age--;
            }
            if (age >= 18)
            {
                Console.WriteLine("Вы совершеннолетний");
            }
            else
            {
                Console.WriteLine("Вы несовершеннолетний");
            }
        }
    }
}
