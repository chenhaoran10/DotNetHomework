using System;

namespace Prime_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入数据");
            int count = Convert.ToInt32(Console.ReadLine());
            int i = 1;//循环变量

            bool s; //表示是否为素数

            for (; i < count; i++)

            {

                s = true;//假设当前的i为素数

                for (int j = 2; j < i; j++)

                {

                    //如果i能被它本身和1以外的数整除，那么他就不是素数

                    if (i % j == 0)

                        s = false;

                }

                //如果是素数则输出

                if (s)

                    Console.WriteLine(i.ToString());

            }
        }
    }
}
