using System;

namespace drob
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0 , a1 = 0, b1 = 0 , a2 = 0, b2 = 0;
            Console.WriteLine("Ввод первой дроби");
            inpf(ref a, ref b);
            Console.WriteLine("Ввод второй дроби");
            inpf(ref a1, ref b1);
            sum(ref a, ref b, ref a1, ref b1, ref a2, ref b2);
        }
        public static void inpf(ref int a , ref int b)
        {
            Console.WriteLine("Введите числитель :");
            int a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите знаменатель :");
            int b1 = int.Parse(Console.ReadLine());
            if(b<0)
            {
                Console.WriteLine("Неправильно введена дробь , проверьте правильность данных");
                inpf(ref a,ref b);
            }
            else
            {
                a = a1;
                b = b1;
            }
        }
        public static void sum(ref int a, ref int b, ref int a1, ref int b1, ref int a2, ref int b2)
        {
            if (b == b1)
                a += a1;
            else
            {
                int p = b * b1;
                a *= p / b;
                a1 *= p / b1;
                a2 = a + a1;
                b2 = p;
                s(ref a2, ref b2);
            }
        }
        public static void s(ref int a2, ref int b2)
        {
            if(a2 % 2 == 0 && b2 % 2 == 0)
            {
                while(a2 % 2 == 0 && b2 % 2 == 0)
                {
                    a2 /= 2;
                    b2 /= 2;
                }
            }
            else if(a2 % 3 == 0 && b2 % 3 == 0)
            {
                while (a2 % 3 == 0 && b2 % 3 == 0)
                {
                    a2 /= 3;
                    b2 /= 3;
                }
            }
            else if (a2 % 5 == 0 && b2 % 5 == 0)
            {
                while (a2 % 5 == 0 && b2 % 5 == 0)
                {
                    a2 /= 5;
                    b2 /= 5;
                }
            }
            else if (a2 % 7 == 0 && b2 % 7 == 0)
            {
                while (a2 % 7 == 0 && b2 % 7 == 0)
                {
                    a2 /= 7;
                    b2 /= 7;
                }
            }
            else
                Console.WriteLine($"Числитель {a2} , знаменатель {b2}");
        }
    }
}
