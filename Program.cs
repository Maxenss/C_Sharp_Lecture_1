using System;

namespace C_Sharp_Lecture_1
{
    class Program
    {
        // Ctrl + A - выделить весь код 
        // Ctrl + Z - вернуться на одно действие назад
        // Ctrl + Y - вернуться на одно действие вперед
        // Ctrl + K + F - форматирование кода 

        static void Main(string[] args)
        {
            Example1();
        }


        static void Tutorial()
        {
            // Целочисленные примитивные типы данных
            byte a = 10;          // 8 bit  0...255
            short b = 20;         // 16 bit 0...65355
            int c = 30;           // 32 bit 0...(2^32) - 1 Mh
            long d = 40;          // 64 bit 0...(2^64) - 1

            // Вещественные типы данных
            float a1 = 2.34f;     // 32 bit
            double b1 = 2.32;     // 64 bit Mh

            // Символы 
            char c1 = 'd';        // 16 bit   0...65355 Mh

            // Логический тип
            bool flag = false;    // 8 bit false...true Mh

            // Сложение
            int opr1 = 20;
            int opr2 = 30;
            int res = opr1 + opr2;

            // Вычитания
            int opr11 = 20;
            int opr22 = 30;
            int res2 = opr1 - opr2;

            // Деление
            int opr111 = 20;
            int opr222 = 30;
            int res22 = opr1 / opr2;

            // Умножение 
            int opr1111 = 20;
            int opr2222 = 30;
            int res222 = opr1 * opr2;

            // Вывод на экран 
            Console.WriteLine("Hello world"); // с переносом строки
            Console.Write("Hello!");          // без переноса строки

            // Считывание данных с консоли
            int temp;
            temp = Convert.ToInt32(Console.ReadLine());

            double temp2;
            temp2 = Convert.ToDouble(Console.ReadLine());

            // Сокращенных ар. выражениях
            int operand1 = 0;

            // Сумма
            operand1 = operand1 + 20;
            operand1 += 20;

            // Разница
            operand1 = operand1 - 20;
            operand1 -= 20;

            // Деление
            operand1 = operand1 / 20;
            operand1 /= 20;

            // Умножение
            operand1 = operand1 * 20;
            operand1 *= 20;
            
            
       
            // Инкремент и декремент 
            // Инкремент - увеличение значения переменной на 1
            // Декремент - уменьшение значения переменной на 1

            int A = 20;
            --A;
            Console.WriteLine(A); // 19
            ++A;
            Console.WriteLine(A); // 20 

            // Префиксный инкремент ++i 
            int i = 10;
            ++i; // 11

            // Постфиксный инкремент i++ 
            i = 10;
            Console.WriteLine(i++); // 10
            Console.WriteLine(i);   // 11
        }

        static void Example1()
        {
            // Теорема Пифагора
            // c^2 = a^2 + b^2
            // Гипотенузу ?

            double a = 0;
            double b = 0;
            double c = 0;

            Console.Write("Введите а : ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите b : ");
            b = Convert.ToDouble(Console.ReadLine());

            c = Math.Sqrt(a * a + b * b);

            Console.WriteLine("c = {0}, b = {1}", c);

            // Задержка выполнения кода (Delay Method)
            Console.ReadKey();
        }
    }
}
