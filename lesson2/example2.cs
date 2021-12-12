/*
Написать метод подсчета количества цифр числа.
Шауленков Алексей
*/

class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
		int count = 0;

		while (n != 0)
		{
			count++;
			n = n / 10;// так как n-целое, деление целочисленное	
		}
		Console.WriteLine(count);


        }
    }
