using System.Runtime.CompilerServices;
Console.WriteLine("Выберите операцию, которую вы хотите совершить :");
Console.WriteLine("1 - сложение двух чисел");
Console.WriteLine("2 - вычитание первого из второго");
Console.WriteLine("3 - перемножение двух чисел");
Console.WriteLine("4 - разделене первого из второго");
Console.WriteLine("5 - возведение в степень N первого числа");
Console.WriteLine("6 - нахождение квадратного корня из числа");
Console.WriteLine("7 - нахождение 1 процента от числа");
Console.WriteLine("8 - нахождение факториала из числа");
Console.WriteLine("9 - выход из программы");
    double number = 0;
    while (number !=9)
    {
        Console.WriteLine("Введите номер операции");
        number = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите первое число");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        double b = double.Parse(Console.ReadLine());
        switch (number)
        {
            case 1:
                Console.WriteLine(a + b);
                break;
            case 2:
                Console.WriteLine(a - b);
                break;
            case 3:
                Console.WriteLine(a * b);
                break;
            case 4:
                Console.WriteLine(a / b);
                break;
            case 5:
                Console.WriteLine(Math.Pow(a, b));
                break;
            case 6:
                a = Convert.ToInt32(Math.Sqrt(a));
                Console.WriteLine(a);
                break;
            case 7:
                Console.WriteLine(a / 100);
                break;
            case 8:
            double n = a;
            int factorial = 1;
            for (int c = 2; c <= n; c++ )
            {
                factorial = factorial * c;

            }
            Console.WriteLine(factorial);
            break;
            case 9:
            break;
            default:
                Console.WriteLine("Неправильная операция");
                break;
        }
    }
