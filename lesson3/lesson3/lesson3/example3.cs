/* Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. 
 * Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
 * Написать программу, демонстрирующую все разработанные элементы класса.

Шауленков Алексей
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drobi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Основная программа
            Drob a = new Drob(4, -8);//создание объекта класса Drob
            Drob b = new Drob(2, 5);//создание объекта класса Drob

            Drob c;
            c = a + b;
            Console.WriteLine("Проверка на сложение: " + a.ToString() + "+" + b.ToString() + "=" + c.ToString());
            Console.ReadKey();

        }
    }
    class Drob//Описание класса Drob
    {
        public double c = 0;
        public double z = 0;

        public Drob(int c, int z)
        {
            this.c = c;
            this.z = z;

        }

        public override string ToString()//cтроковое представление
        {
            return "(" + c.ToString() + "/" + z.ToString() + ")";
        }

        public static Drob operator +(Drob a, Drob b)//сложение дробей
        {
            Drob t = new Drob(1, 1);//создание и инициализация новой дроби
            t.c = (a.c * b.z + a.z * b.c);//числитель новой дроби
            t.z = a.z * b.z;//знаменатель новой дроби
            Drob.SetFormat(t);//сокращаем дробь
            return t;//возвращаем результат

        }
        public static Drob operator -(Drob a, Drob b)//вычитание дробей
        {
            Drob t = new Drob(1, 1);//создание и инициализация новой дроби
            t.c = (a.c * b.z - a.z * b.c);//числитель новой дроби
            t.z = a.z * b.z;//знаменатель новой дроби
            Drob.SetFormat(t);//сокращаем дробь
            return t;//возвращаем результат

        }
        public static Drob operator *(Drob a, Drob b)//вычитание дробей
        {
            Drob t = new Drob(1, 1);//создание и инициализация новой дроби
            t.c = (a.c * b.c);//числитель новой дроби
            t.z = a.z * b.z;//знаменатель новой дроби
            Drob.SetFormat(t);//сокращаем дробь
            return t;//возвращаем результат

        }
        public static Drob operator /(Drob a, Drob b)//вычитание дробей
        {
            Drob t = new Drob(1, 1);//создание и инициализация новой дроби
            t.c = (a.c / b.c);//числитель новой дроби
            t.z = a.z / b.z;//знаменатель новой дроби
            Drob.SetFormat(t);//сокращаем дробь
            return t;//возвращаем результат
        }
        //процедура по сокращению дроби
        public static Drob SetFormat(Drob a)
        {

            double max = 0;

            //выбираем что больше числитель или знаменатель
            if (a.c > a.z)
                max = Math.Abs(a.z);//ВНИМАНИЕ! берем по модулю, что работало и с отрицательными
            else
                max = Math.Abs(a.c);//ВНИМАНИЕ! берем по модулю, что работало и с отрицательными
                                    //поиск от максимума до 2
            for (double i = max; i >= 2; i--)
            {
                //такого числа, поделив на которое бы делилось без
                //остатка и на числитель и на знаменатель
                if ((a.c % i == 0) & (a.z % i == 0))
                {
                    a.c = a.c / i;
                    a.z = a.z / i;
                }

            }
            //Определяемся со знаком
            //если в знаменателе минус, поднимаем его наверх
            if ((a.z < 0))
            {
                a.c = -1 * (a.c);
                a.z = Math.Abs(a.z);
            }
            return (a);//возращаем результат
        }
    }
}