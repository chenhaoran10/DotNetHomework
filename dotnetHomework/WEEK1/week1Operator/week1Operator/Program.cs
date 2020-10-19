using System;

namespace week1Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please input two numbers");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int result=0;
            Console.WriteLine("please input operator");
            char oper =Convert.ToChar( Console.ReadKey());
            switch (oper)
            {
                case '+':
                    result = number1 + number2;
                    break;
                case '-':
                    result = number1 - number2;
                    break;
                case '*':
                    result = number1 * number2;
                    break;
                case '/':
                    result = number1 / number2;
                    break;
                default:
                    Console.WriteLine("input error");
                    break;



            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
