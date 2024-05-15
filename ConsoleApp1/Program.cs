using System;
using Geometry;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isWorking = true;

            while (isWorking)
            {
                ShowMenu();
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        CalculateCircleArea();
                        break;
                    case "2":
                        CalculateTriangleArea();
                        break;
                    case "3":
                        isWorking = false;
                        break;
                    default:
                        ShowError();
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("Меню: ");
            Console.WriteLine("1.Рассчитать площадь круга по радиусу.");
            Console.WriteLine("2.Рассчитать площадь треугольника по 3 сторонам.");
            Console.WriteLine("3.Выход.");
        }

        static void CalculateCircleArea()
        {
            double result;
            Console.WriteLine("Введите радиус круга в метрах: ");
            string userInput = Console.ReadLine();

            if (double.TryParse(userInput, out result))
            {
                Circle cirle = new Circle(result);
                Console.WriteLine($"Площадь круга: {cirle.CalculateArea()} м^2");
            }
            else
            {
                ShowError();
            }
        }

        static void CalculateTriangleArea()
        {
            double result;
            double trianleSideA = 0;
            double trianleSideB = 0;
            double trianleSideC = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Введите длину {i + 1} стороны в см: ");
                string userInput = Console.ReadLine();

                if (double.TryParse(userInput, out result))
                {
                    switch (i)
                    {
                        case 0:
                            trianleSideA = result;
                            break;
                        case 1:
                            trianleSideB = result;
                            break;
                        case 2:
                            trianleSideC = result;
                            break;
                    }
                }
                else
                {
                    ShowError();
                    return;
                }
            }

            Triangle triangle = new Triangle(trianleSideA, trianleSideB, trianleSideC);
            Console.WriteLine($"Площадь треугольника: {triangle.CalculateArea()} см^2");
            Console.WriteLine("Является ли треугольник прямоугольным? - " + triangle.IsRectangular());
        }

        static void ShowError()
        {
            Console.WriteLine("Неверный ввод. Попробуйте снова.");
        }
    }
}
