using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NipiGaz
{
    public class Point
    {
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        private readonly double x;
        private readonly double y;

        public double GetX() => this.x;
        public double GetY() => this.y;

        /// <summary>
        /// Функция возвращает текущую точку повернутую относительной другой точки p на угол angle
        /// </summary>
        /// <param name="p">Точка, относительно которой будет повернута текущая</param>
        /// <param name="angle">Угол поворота текущей точки</param>
        /// <returns></returns>
        public Point RotatePoint(Point p, double angle)
        {
            var s = Math.Sin(Math.PI * -angle / 180);
            var c = Math.Cos(Math.PI * -angle / 180);

            var a1 = c * (x - p.x) - s * (y - p.y) + p.x;
            var b1 = s * (x - p.x) + c * (y - p.y) + p.y;

            return new Point(a1, b1);
        }

        /// <summary>
        /// Возвращает текущую точку, смещенную по вектору offcetVector
        /// </summary>
        /// <param name="offcetVector">Вектор для смещения</param>
        /// <returns></returns>
        public Point OffcetPoint(Vector offcetVector)
        {
            var a = offcetVector.GetStartPoint();
            var b = offcetVector.GetEndPoint();

            return new Point(b.x - a.x + x, b.y - a.y + y);
        }
    }
}
