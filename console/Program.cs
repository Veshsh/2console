Console.WriteLine("1 Игра \"Угадай число\"\r\n2 Таблица умножения\r\n3 Вывод делителей числа\r\n4 Закрыть програму");
Console.WriteLine("введите номер команды");
int n = Convert.ToInt32(Console.ReadLine());
while (n != 4)
{
    if (n == 1)
    {
        Console.WriteLine("введите число  от 1 до 100");
        int a = Convert.ToInt32(Console.ReadLine());
        Random random = new Random();
        int b = random.Next(0, 100);
        while (a != b)
        {
            if (b > a) { Console.WriteLine("больше"); }
            else { Console.WriteLine("меньше"); }
            a = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("угадали");
    }
    else if (n == 2)
    {
        int[,] mas = new int[9, 9];
        for (int i = 0; i < 9; i++)
        {
            for (int l = 0; l < 9; l++)
            {
                mas[i, l] = (i + 1) * (l + 1);
                Console.Write(mas[i, l] + "\t");
            }
            Console.WriteLine();
        }

    }
    else if (n == 3)
    {
        Console.WriteLine("введите положительное целое число\r\nесли хотите выйти введите: выход");
        string aa = Console.ReadLine();
        int bb;
        while (aa != "выход")
        {
            bb = Convert.ToInt32(aa);
            if (bb > 0)
            {
                for (int ii = 1; ii < bb + 1; ii++)
                {
                    if (bb % ii == 0)
                    {
                        Console.Write(ii + "\t");
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("введите положительное целое число");
            aa = Console.ReadLine();
        }
    }
    else
    {
        Console.WriteLine("Неизвестная команда");
    }
    Console.WriteLine("введите номер команды");
    n = Convert.ToInt32(Console.ReadLine());
}
