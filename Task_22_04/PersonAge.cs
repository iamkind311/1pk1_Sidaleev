using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_22_04
{
    public class PersonAge
    {
        public DateOnly BirthDate { get; }

        public PersonAge(DateOnly birthDate)
        {
            BirthDate = birthDate;
        }

        // Возвращает возраст на конкретную дату
        public int GetAgeAtDate(DateOnly date)
        {
            if (date < BirthDate)
            {
                throw new ArgumentException("Дата не может быть раньше даты рождения.");
            }

            int age = date.Year - BirthDate.Year;

            // Если день рождения ещё не наступил в этом году, уменьшаем возраст на 1
            if (date.Month < BirthDate.Month || (date.Month == BirthDate.Month && date.Day < BirthDate.Day))
            {
                age--;
            }

            return age;
        }

        // Возвращает количество дней до следующего дня рождения
        public int GetNextBirthday()
        {
            var today = DateOnly.FromDateTime(DateTime.Today);
            var nextBirthday = new DateOnly(today.Year, BirthDate.Month, BirthDate.Day);

            // Если день рождения в этом году уже прошёл, берём следующий год
            if (nextBirthday < today)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }

            return (nextBirthday.ToDateTime(TimeOnly.MinValue) - today.ToDateTime(TimeOnly.MinValue)).Days;
        }
        public bool IsLeapYearBirth()
        {
            return DateTime.IsLeapYear(BirthDate.Year);
        }
    }
}