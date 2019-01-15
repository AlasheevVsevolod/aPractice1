using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_1_OOP
{
    public class Practice
    {
        /// <summary>
        /// A.L1.P1. Вывести матрицу (двумерный массив) отображающую площадь круга, 
        /// квадрата, равнобедренного треугольника со сторонами (радиусами) от 1 до 10.
        /// </summary>
        public static void A_L1_P1_OOP()
        {
            double[,] areaArr = new double[3, 10];
            for (int i = 0; i < areaArr.GetLength(1); i++)
            {
                var newCircle = new Circle(i + 1);
                var newSquare = new Square(i + 1);
                var newTriangle = new Triangle(i + 1);

                areaArr[0, i] = newCircle.AreaCalc();
                areaArr[1, i] = newSquare.AreaCalc();
                areaArr[2, i] = newTriangle.AreaCalc();
            }

            for (int i = 0; i < areaArr.GetLength(0); i++)
            {
                for (int j = 0; j < areaArr.GetLength(1); j++)
                {
                    Console.Write($"{areaArr[i, j]:n3} ");
                }
                Console.WriteLine();
            }
        }


        /// <summary>
        /// A.L1.P5. Перегрузить следующие операторы для FuelCar < (меньше), > (больше), == (равно),
        /// != (неравно) на базе значения мощности двигателя Engine.Продемонстрировать использование в коде.
        /// </summary>
        public static void A_L1_P5_6_CarOperatorsOverloading()
        {
            FuelCar car1 = new FuelCar()
            {
                Engine = 100
            };

            FuelCar car2 = new FuelCar()
            {
                Engine = 150
            };

            Console.WriteLine(car1 < car2 ? "Car 1 has smaller engine": "Car 2 has greater engine");
            car1.Engine = 200;
            Console.WriteLine(car1 > car2 ? "Car 1 has greater engine" : "Car 2 has smaller engine");

            Console.WriteLine(car1 == car2 ? "Cars have the same engine" : "Cars have different engines");

            car1.Engine = 150;
            Console.WriteLine(car1 != car2 ? "Cars have different engines" : "Cars have the same engine");
        }

        /// <summary>
        /// A.L1.P7.Перегрузить операторы<>,==/!=  для продаваемых вещей в интернет магазине на базе их цены. 
        /// Продемонстрировать использование в коде. 
        /// </summary>
        public static void A_L1_P7_OperatorsOverloading()
        {            
        }        
    }

    public class Figure
    {
        public virtual double AreaCalc()
        {
            throw new NotImplementedException();
        }
    }

    public class Circle: Figure
    {
        private int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public override double AreaCalc()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }

    class Square : Figure
    {
        private int side;
        public Square(int side)
        {
            this.side = side;
        }

        public override double AreaCalc()
        {
            return Math.Pow(side, 2);
        }
    }

    class Triangle : Figure
    {
        private int side;

        public Triangle(int side)
        {
            this.side = side;
        }

        public override double AreaCalc()
        {
            return Math.Pow(side, 2) * Math.Sin(60 * Math.PI / 180) / 2;
        }
    }

}
