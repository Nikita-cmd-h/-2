Console.WriteLine("Вы попали в консольное приложение по навигации домашней работы к уроку №2 от Синего Никиты");
Console.WriteLine("");
int imput_number = 1;
while (imput_number != 0)
{
    Console.Write("Какую задачу хотите протестировать (напишите номер задания)? Если хотите выйти то введите 0: ");
    imput_number = int.Parse(Console.ReadLine()!);
    Console.WriteLine("");
    if(imput_number==0){
        break;
    }
    /* Задача 1: Напишите программу, которая принимает
    на вход число и проверяет, кратно ли оно
    одновременно 7 и 23
    */
    if (imput_number == 1)
    {
        Console.WriteLine("Задание_1 Считает кратно ли число 7 и 23 одновременно");
        Console.WriteLine("");
        Console.Write("Ведите число: ");
        int number_1 = int.Parse(Console.ReadLine()!);
        if (number_1 % 7 == 0 & number_1 % 23 == 0)
        {
            Console.WriteLine($"Число {number_1} кратно 7 и 23");
        }
        else
        {
            Console.WriteLine($"Число {number_1} не кратно 7 и 23");
        }
    }
    if (imput_number == 2)
    {
        /*Задача 2: Напишите программу, которая принимает
        на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠
        0 и выдаёт номер координатной четверти плоскости,
        в которой находится эта точка.
        */
        Console.WriteLine("Задание_2 Считает в какой четверти находится точка при заданных координатах");
        Console.WriteLine("");
        bool condition_1 = false;
        int x = 0;
        int y = 0;

        while (!condition_1)
        {
            Console.Write("Ведите X: ");
            int firstnumber_2 = int.Parse(Console.ReadLine()!);
            Console.Write("Ведите Y: ");
            int secondnumber_2 = int.Parse(Console.ReadLine()!);
            if (firstnumber_2 == 0 | secondnumber_2 == 0)
            {
                Console.WriteLine("Нельзя вводить x или y равные нулю!");
            }
            else
            {
                x = firstnumber_2;
                y = secondnumber_2;
                condition_1 = true;
            }
        }

        int quarter = 0;

        if (x < 0)
        {
            if (y > 0)
            {
                quarter = 2;
            }
            else
            {
                quarter = 3;
            }
        }
        else
        {
            if (y > 0)
            {
                quarter = 1;
            }
            else
            {
                quarter = 4;
            }
        }

        Console.WriteLine($"Координата ({x}; {y}) находится в {quarter} четверти");
    }
    /* Задача 3: Напишите программу, которая принимает
    на вход целое число из отрезка [10, 99] и показывает
    наибольшую цифру числа.
        */
    if (imput_number == 3)
    {
        bool condition_3 = false;
        int number_3 = 0;
        int maxfigure = 0;

        Console.WriteLine("Задание_3 Находит наибольшию цифру в двух значном числе");
        Console.WriteLine("");

        while (!condition_3)
        {
            Console.Write("Введите число от 10 до 99: ");
            number_3 = int.Parse(Console.ReadLine()!);
            if (number_3 >= 10 & number_3 <= 99)
            {
                condition_3 = true;
            }
            else
            {
                Console.WriteLine("Вводить число нужно от 10 и до 99 включительно!");
            }
        }
        if (number_3 / 10 < number_3 % 10)
        {
            maxfigure = number_3 % 10;
            Console.WriteLine($"Наибольшая цифра в числе {number_3} это {maxfigure}");
        }
        else if (number_3 / 10 == number_3 % 10)
        {
            Console.WriteLine($"Цифры в числе {number_3} равны");
        }
        else
        {
            maxfigure = number_3 / 10;
            Console.WriteLine($"Наибольшая цифра в числе {number_3} это {maxfigure}");
        }
    }
    /*Задача 4: Напишите программу, которая на вход
    принимает натуральное число N, а на выходе
    показывает его цифры через запятую.
        */
    if (imput_number == 4)
    {
        bool condition_4 = false;
        int current = 0;
        int number_4 = 0;
        int i = 10;
        string quantity = "";

        Console.WriteLine("Задание_4 Переписывает цифры через запятую, которые присутствуют в натуральном числе");
        Console.WriteLine("");

        while (!condition_4)
        {
            Console.Write("Введите любое натуральное число: ");
            number_4 = int.Parse(Console.ReadLine()!);
            if (number_4 < 0)
            {
                Console.WriteLine("Введите натуральное число!");
            }
            else
            {
                condition_4 = true;
                current = number_4;
            }
        }
        while (i != 0)
        {
            if (number_4 / i < 1)
            {
                string q = $"{current % 10}";
                current = (number_4 - number_4 % i) / i;
                quantity = $"{q}{quantity}";
                i = 0;
            }
            else
            {
                string q = $"{current % 10}";
                current = (number_4 - number_4 % i) / i;
                quantity = $",{q}{quantity}";
                i *= 10;
            }
        }

        Console.WriteLine(quantity);
    }
}