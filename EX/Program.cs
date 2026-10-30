using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Упражнение 4.1. Определение даты по номеру дня.");
        Console.WriteLine("Упражнение 4.2. Проверка правильности номера дня.");

        try
        {
            Console.Write("Введите номер дня от 1 до 365: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 1 || number > 365)
            {
                throw new Exception("Номер дня должен быть от 1 до 365!");
            }

            int start = 0;
            string month;

            if (number <= 31)
            {
                month = "января";
                start = 0;
            }
            else if (number <= 59)
            {
                month = "февраля";
                start = 31;
            }
            else if (number <= 90)
            {
                month = "марта";
                start = 59;
            }
            else if (number <= 120)
            {
                month = "апреля";
                start = 90;
            }
            else if (number <= 151)
            {
                month = "мая";
                start = 120;
            }
            else if (number <= 181)
            {
                month = "июня";
                start = 151;
            }
            else if (number <= 212)
            {
                month = "июля";
                start = 181;
            }
            else if (number <= 243)
            {
                month = "августа";
                start = 212;
            }
            else if (number <= 273)
            {
                month = "сентября";
                start = 243;
            }
            else if (number <= 304)
            {
                month = "октября";
                start = 273;
            }
            else if (number <= 334)
            {
                month = "ноября";
                start = 304;
            }
            else
            {
                month = "декабря";
                start = 334;
            }

            int day = number - start;

            Console.WriteLine($"Дата: {day} {month}");
        }
        catch (Exception error)
        {
            Console.WriteLine($"Ошибка: {error.Message}");
        }
    }
}
