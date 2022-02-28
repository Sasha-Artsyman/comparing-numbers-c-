using System;

class NumberComparison
{
    static void Main(string[] args)
    {
        Console.WriteLine("введите первое число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("введите второе число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        if(num1 < num2)
        {
            Console.WriteLine("{0} меньше чем {1}", num1, num2);
        }
        else if (num1 > num2)
        {
            Console.WriteLine("{0} больше чем {1}", num1, num2);
        }
        else
        {
            Console.WriteLine("числа равны");
        }
        Console.ReadLine();
    }
}