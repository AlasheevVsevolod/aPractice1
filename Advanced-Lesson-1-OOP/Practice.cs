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
            var newCircle = new Circle();
            var newSquare = new Square();
            var newTriangle = new Triangle();
        }


        /// <summary>
        /// A.L1.P6. Перегрузить следующие операторы для Transport <>,==/!= на базе физических размеров. 
        /// Продемонстрировать использование в коде. 
        /// </summary>
        public static void A_L1_P6_OperatorsOverloading()
        {
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
        public virtual void Draw()
        {
            throw new NotImplementedException();
        }
        public virtual double AreaCalc()
        {
            throw new NotImplementedException();
        }
    }

    public class Circle: Figure
    {
        private int radius;
        public override void Draw()
        {
            Console.WriteLine("This is cirlce");
        }
        public override double AreaCalc()
        {
            return Math.PI * (radius ^ 2);
        }
    }

    class Square : Figure
    {
        public void Draw()
        {
            Console.WriteLine("This is square");
        }
        double AreaCalc(int side)
        {
            return side ^ 2;
        }
    }

    class Triangle : Figure
    {
        public void Draw()
        {
            Console.WriteLine("This is triangle");
        }
        double AreaCalc(int side)
        {
            return side ^ 2;
        }
    }

}
