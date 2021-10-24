using System;

namespace lab_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //2.2 - средний уровень - вариант 8                
                Console.WriteLine("Введите a:");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите b:");
                int b = int.Parse(Console.ReadLine());
                int p = a*b;
                if (a * b == p)
                if ((a <=9) && (b <=9))
                Console.WriteLine("Произведение заданных чисел = {0}",p); 
                else Console.WriteLine("Некорректный запрос - введите однозначное(ые) число(а)");
            }
            catch (Exception)
            {
                Console.WriteLine("Введите корректно переменную");
                
            }
        }
    }
}
