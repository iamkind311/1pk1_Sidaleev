namespace Task_22_04
{
    internal class Program
    {
        /*Создать класс PersonAge, который вычисляет возраст на основе DateOnly (даты рождения).
        Методы:
        • GetAgeAtDate(DateOnly) - возраст на конкретную дату
        • GetNextBirthday() - сколько дней до следующего ДР
        • IsLeapYearBirth() - родился ли в високосный год*/
        static void Main(string[] args)
        {
            var birthDate = new DateOnly(1990, 2, 15);
            var person = new PersonAge(birthDate);

            var testDate = new DateOnly(2023, 5, 10);
            Console.WriteLine($"Возраст на {testDate}: {person.GetAgeAtDate(testDate)} лет"); // 33

            Console.WriteLine($"До следующего ДР: {person.GetNextBirthday()} дней");

            Console.WriteLine($"Родился в високосный год? {person.IsLeapYearBirth()}"); // False (1990 не високосный)
        }
    }
}
