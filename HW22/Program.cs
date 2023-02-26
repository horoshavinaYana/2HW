// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите целое число а  ");
        int a = Convert.ToInt32(Console.ReadLine());
        
           
        if (99 < a && a < 1000)
        {
            Console.WriteLine($"ваше число = {a}");
           int b=a%10;
            Console.WriteLine($"третья цифра = {b}");
        }
        if (a>999)
        {
            while (a>999)
            {
                a/=10;
            }
            int b=a%10;
            Console.WriteLine($"третья цифра = {b}");
        }
        if (a < 100)
        {
            Console.WriteLine("Третьей цифры нет");
           
        }
