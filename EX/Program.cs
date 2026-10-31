using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Домашнее задание 4.1. Определение даты с учетом високосного года.");

        try
        {
            Console.Write("Введите год: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Введите номер дня в году: ");
            int number = int.Parse(Console.ReadLine());

            bool leapYear = false;

            if (year % 400 == 0)
            {
                leapYear = true;
            }
            else if (year % 100 == 0)
            {
                leapYear = false;
            }
            else if (year % 4 == 0)
            {
                leapYear = true;
            }

            int extraDay = 0;

            if (leapYear)
            {
                extraDay = 1;
                Console.WriteLine("Год високосный.");
            }
            else
            {
                Console.WriteLine("Год не високосный.");
            }

            if (number < 1 || number > 365 + extraDay)
            {
                throw new Exception("Неверный номер дня!");
            }

            int start = 0;
            string month;

            if (number <= 31)
            {
                month = "января";
                start = 0;
            }
            else if (number <= 59 + extraDay)
            {
                month = "февраля";
                start = 31;
            }
            else if (number <= 90 + extraDay)
            {
                month = "марта";
                start = 59 + extraDay;
            }
            else if (number <= 120 + extraDay)
            {
                month = "апреля";
                start = 90 + extraDay;
            }
            else if (number <= 151 + extraDay)
            {
                month = "мая";
                start = 120 + extraDay;
            }
            else if (number <= 181 + extraDay)
            {
                month = "июня";
                start = 151 + extraDay;
            }
            else if (number <= 212 + extraDay)
            {
                month = "июля";
                start = 181 + extraDay;
            }
            else if (number <= 243 + extraDay)
            {
                month = "августа";
                start = 212 + extraDay;
            }
            else if (number <= 273 + extraDay)
            {
                month = "сентября";
                start = 243 + extraDay;
            }
            else if (number <= 304 + extraDay)
            {
                month = "октября";
                start = 273 + extraDay;
            }
            else if (number <= 334 + extraDay)
            {
                month = "ноября";
                start = 304 + extraDay;
            }
            else
            {
                month = "декабря";
                start = 334 + extraDay;
            }

            int day = number - start;

            Console.WriteLine($"Дата: {day} {month} {year} года");
        }
        catch (Exception error)
        {
            Console.WriteLine($"Ошибка: {error.Message}");
        }
    }
}
