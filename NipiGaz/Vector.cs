using System;

namespace NipiGaz
{
    public class Vector
    {
        public Vector(Point start, Point end)
        {
            this.start = start;
            this.end = end;
        }

        private readonly Point start;
        private readonly Point end;

        public Point GetStartPoint() => this.start;
        public Point GetEndPoint() => this.end;
        /// <summary>
        /// Функция возвращает перпендикулярность текущего вектора относительно вектора vector
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        public bool IsPerpendicular(Vector vector)
        {
            var ab1 = this.end.GetX() - this.start.GetX();
            var ab2 = this.end.GetY() - this.start.GetY();

            var cd1 = vector.end.GetX() - vector.start.GetX();
            var cd2 = vector.end.GetY() - vector.start.GetY();

            var result = ab1 * cd1 + ab2 * cd2;

            return result < 0.0001 && result > -0.0001;
        }
    }
}