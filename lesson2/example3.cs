/*
С клавиатуры вводятся числа, пока не будет введен 0. 
Подсчитать сумму всех нечетных положительных чисел.
Шауленков Алексей
*/

 class Program
    {

       

        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите числа, для завершения введите 0: ");

            int count = 0;
            int Sum = 0;
            while (true) 
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == 0)
                {
                    break;
                }
                else if(number > 0 && number % 2 != 0 )
                {
                    count++;
                    Sum += number;
                }
            }
            Console.WriteLine("Количество чисел: " + count);
            Console.WriteLine("Сумма: " + Sum);

            Console.ReadKey();
        }
    }
        
