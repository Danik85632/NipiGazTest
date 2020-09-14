using System;
using System.Collections.Generic;
using System.Linq;

namespace NipiGaz
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 2
            var point1 = new Point(2.0, 1.0);
            var point2 = new Point(4.0, 1.0);
            var rotatePoint = point2.RotatePoint(point1, 90);

            var point3 = new Point(1.0, 2.0);
            var vector = new Vector(new Point(2.0, 1.0), new Point(6.0, 2.0));
            var offcetPoint = point3.OffcetPoint(vector);

            var vector1 = new Vector(new Point(3.0, 1.0), new Point(6.0, 1.0));
            var vector2 = new Vector(new Point(2.0, 1.0), new Point(2.0, 4.0));
            var result = vector1.IsPerpendicular(vector2);
            #endregion

            #region Task 1
            WorkWithUserInput();
            #endregion
        }

        private static void WorkWithUserInput()
        {
            var result = new List<int>();
            var input = Console.ReadLine();
            var b = input.Split().Where(x => x != "").ToList();
            if (b.Count != 0)
            {
                b.ForEach(x =>
                {
                    if (!int.TryParse(x, out int temp))
                    {
                        Console.WriteLine($"Возникла ошибка в приведении {input.IndexOf(x)}-го символа к типу Int32.");
                        throw new InvalidCastException($"Возникла ошибка в приведении {input.IndexOf(x)}-го символа к типу Int32.");
                    }
                    else
                        result.Add(temp);
                });
                if (result.Count > 1)
                {
                    Console.WriteLine($"Разница между максимальным и минимальным значением равна = {result.Max() - result.Min()}");
                    result.Sort();
                    Console.WriteLine($"Наиболее наименьшее число = {result[0]}, а менее наименьшее число = {result[1]}");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Строка содержит менее двух чисел.");
                    throw new IndexOutOfRangeException("Строка содержит менее двух чисел.");
                }                    
            }                   
        }
    }       
}
