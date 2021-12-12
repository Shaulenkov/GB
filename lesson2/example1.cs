/*
Написать метод, возвращающий минимальное из трех чисел.
Шауленков Алексей
*/

 class Program
    {

        static int minOfThree (int a, int b, int c)
        {
            if (a >= b)
            {
                if (b >= c)
                {
                    return c;
                }
                else
                {
                    return b;
                }

            }
            else
            {
                if (a >= c)
                {
                    return c;
                }
                else
                {
                    return a;
                }
            }
        }

     

        static void Main(string[] args)
        {
            
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите третье число: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine( "Минимальным является: " + minOfThree(a,b,c));                   

            Console.ReadKey();
        }
    }
