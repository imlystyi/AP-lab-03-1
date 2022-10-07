// Lab_03_1.cs
// Якубовський Владислав
// Лабораторна робота № 3.1
// Розгалуження, задане формулою: функція однієї змінної.
// Варіант 24
using System;

namespace AP_Lab_03_1
{
    internal class Lab_03_1
    {
        static void Main()
        {
            // У завданні я помітив можливу помилку: якщо -0,4 < x < 0.4, то y = х для А (програма не виконуватиме жодних розрахунків), а y для В буде виконувати розрахунки за формулою.
            Console.OutputEncoding = System.Text.Encoding.Default;

            Console.Write("Введіть значення для \"x\": ");

            double x = Double.Parse(Console.ReadLine().Replace(".", ","));

            // Спосіб 1: розгалуження в скороченій формі.
            double A = 0;

            if (x <= -1)
                A = Math.Log10(Math.Abs(Math.Cos(5 * x))) + Math.Pow(Math.E, (1 / x) + x);

            if (x > -1 && x < -0.4)
                A = Math.Sqrt(Math.Pow((2 - x), 3) - Math.Tan(x));

            if (x >= 0.4) 
                A = Math.Sin(5 * x) - Math.Sqrt(Math.Abs(1 - x));

            // Спосіб 2: розгалуження в повній формі.
            double B;

            if (x <= -1)
                B = Math.Log10(Math.Abs(Math.Cos(5 * x))) + Math.Pow(Math.E, (1 / x) + x);

            else
            {
                if (x > -1 && x < -0.4)
                    B = Math.Sqrt(Math.Pow((2 - x), 3) - Math.Tan(x));

                else B = Math.Sin(5 * x) - Math.Sqrt(Math.Abs(1 - x));
            }

            // Частина виведення.
            Console.Write($"Отримане першим способом значення для \"y\": {x + A};\n" +
                $"отримане другим способом значення для \"y\": {x + B}");

            Console.ReadLine();
        }
    }
}