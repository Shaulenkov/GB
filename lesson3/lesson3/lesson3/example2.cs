/* а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
в) Добавить диалог с использованием switch демонстрирующий работу класса.

Шауленков Алексей
*/

using System;

namespace lesson3
{
    class Program
    {


        static void example2()
        {


            Console.Write("Вводите целые числа.\nДля завершения ввода данных введите ноль:\n");

            string numberStr;
            int numberInt;
            int sum = 0;
            int count = 0;
            bool flag;

            do
            {
                do
                {
                    Console.Write($"{count + 1}: ");
                    numberStr = Console.ReadLine();
                    flag = int.TryParse(numberStr, out numberInt);
                } while (!flag);

                if (numberInt != 0)
                {
                    count++;
                }

                if ((numberInt % 2 != 0) && (numberInt > 0))
                {
                    sum += numberInt;
                }

            } while (numberStr != "0");

            Console.WriteLine($"Среди введенных {count} целых чисел сумма всех положительных нечётных составляет {sum}.");
            Console.WriteLine("Нажмите любую клавишу для возврата в главное меню...");
            Console.ReadKey();
        }
    }
}