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

            double x = Double.Parse(Console.ReadLine().Replace(".", ",")), y = 0;

            // Спосіб 1: розгалуження в скороченій формі.
            if (x <= -1)
                y = x + Math.Log10(Math.Abs(Math.Cos(5 * x))) + Math.Pow(Math.E, (1 / x));

            if (x > -1 && x < -0.4)
                y = x + Math.Sqrt(Math.Pow((2 - x), 3) - Math.Tan(x));

            if (x >= 0.4) 
                y = x + Math.Sin(5 * x) - Math.Sqrt(Math.Abs(1 - x));

            Console.Write($"Отримане першим способом значення для \"y\": {y};\n");
            // Спосіб 2: розгалуження в повній формі.

            if (x <= -1)
                y = x + Math.Log10(Math.Abs(Math.Cos(5 * x))) + Math.Pow(Math.E, (1 / x));

            else
            {
                if (x > -1 && x < -0.4)
                    y = x + Math.Sqrt(Math.Pow((2 - x), 3) - Math.Tan(x));

                else y = x + Math.Sin(5 * x) - Math.Sqrt(Math.Abs(1 - x));
            }

            Console.Write($"отримане другим способом значення для \"y\": {y}");
            Console.ReadLine();
        }
    }
}