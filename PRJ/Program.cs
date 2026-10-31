using System;

enum WeekDay
{
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

class Program
{
    static void Main()
    {
        // Задача 1
        Console.WriteLine("Задача 1. Проверка последовательности на возрастание.");

        int[] numbers = new int[10];

        Console.WriteLine("Введите 10 чисел:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Число {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        bool increasing = true;

        for (int i = 1; i < 10; i++)
        {
            if (numbers[i] <= numbers[i - 1])
            {
                increasing = false;
                Console.WriteLine($"Первое нарушение: число №{i + 1}");
                break;
            }
        }

        if (increasing)
        {
            Console.WriteLine("Последовательность упорядочена по возрастанию.");
        }
        else
        {
            Console.WriteLine("Последовательность не упорядочена по возрастанию.");
        }

        Console.WriteLine();

        // Задача 2
        Console.WriteLine("Задача 2. Определение достоинства карты.");

        try
        {
            Console.Write("Введите номер карты от 6 до 14: ");
            int k = int.Parse(Console.ReadLine());

            if (k < 6 || k > 14)
            {
                throw new Exception("Номер карты должен быть от 6 до 14!");
            }

            switch (k)
            {
                case 6:
                    Console.WriteLine("Шестёрка");
                    break;
                case 7:
                    Console.WriteLine("Семёрка");
                    break;
                case 8:
                    Console.WriteLine("Восьмёрка");
                    break;
                case 9:
                    Console.WriteLine("Девятка");
                    break;
                case 10:
                    Console.WriteLine("Десятка");
                    break;
                case 11:
                    Console.WriteLine("Валет");
                    break;
                case 12:
                    Console.WriteLine("Дама");
                    break;
                case 13:
                    Console.WriteLine("Король");
                    break;
                case 14:
                    Console.WriteLine("Туз");
                    break;
            }
        }
        catch (Exception error)
        {
            Console.WriteLine($"Ошибка: {error.Message}");
        }
        finally
        {
            Console.WriteLine("Проверка карты завершена.");
        }

        Console.WriteLine();

        // Задача 3
        Console.WriteLine("Задача 3. Определение напитка по профессии.");

        Console.Write("Введите профессию на английском: ");
        string profession = Console.ReadLine();

        switch (profession.ToLower())
        {
            case "jabroni":
                Console.WriteLine("Patron Tequila");
                break;
            case "school counselor":
                Console.WriteLine("Anything with Alcohol");
                break;
            case "programmer":
                Console.WriteLine("Hipster Craft Beer");
                break;
            case "bike gang member":
                Console.WriteLine("Moonshine");
                break;
            case "politician":
                Console.WriteLine("Your tax dollars");
                break;
            case "rapper":
                Console.WriteLine("Cristal");
                break;
            default:
                Console.WriteLine("Beer");
                break;
        }

        Console.WriteLine();

        // Задача 4
        Console.WriteLine("Задача 4. Определение дня недели.");

        Console.Write("Введите номер дня недели от 1 до 7: ");
        int dayNumber = int.Parse(Console.ReadLine());

        if (dayNumber >= 1 && dayNumber <= 7)
        {
            WeekDay day = (WeekDay)dayNumber;

            switch (day)
            {
                case WeekDay.Monday:
                    Console.WriteLine("Понедельник");
                    break;
                case WeekDay.Tuesday:
                    Console.WriteLine("Вторник");
                    break;
                case WeekDay.Wednesday:
                    Console.WriteLine("Среда");
                    break;
                case WeekDay.Thursday:
                    Console.WriteLine("Четверг");
                    break;
                case WeekDay.Friday:
                    Console.WriteLine("Пятница");
                    break;
                case WeekDay.Saturday:
                    Console.WriteLine("Суббота");
                    break;
                case WeekDay.Sunday:
                    Console.WriteLine("Воскресенье");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Ошибка: номер дня должен быть от 1 до 7!");
        }

        Console.WriteLine();

        // Задача 5
        Console.WriteLine("Задача 5. Подсчёт кукол в сумке.");

        string[] toys =
        {
            "Car",
            "Hello Kitty",
            "Ball",
            "Barbie doll",
            "Robot",
            "Hello Kitty",
            "Book",
            "Barbie doll"
        };

        int count = 0;

        foreach (string toy in toys)
        {
            if (toy == "Hello Kitty" || toy == "Barbie doll")
            {
                count++;
                Console.WriteLine($"Добавили в сумку: {toy}");
            }
        }

        Console.WriteLine($"Всего кукол в сумке: {count}");
    }
}
