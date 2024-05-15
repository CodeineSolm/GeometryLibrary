using System;

namespace Geometry
{
    public class Circle
    {
        private double _radius;
        private double _area;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double CalculateArea()
        {
            _area = (Math.PI * Math.Pow(_radius, 2));
            return _area;
        }
    }

    public class Triangle
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;
        private double _area;

        public Triangle(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public double CalculateArea()
        {
            double p = (_sideA + _sideB + _sideC) / 2;
            _area = Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
            return _area;
        }

        public string IsRectangular()
        {
            string rectangular = "Прямоугольный";
            string notRectangular = "Не прямоугольный";

            if (_sideA > _sideB && _sideA > _sideC)
            {
                if (Math.Pow(_sideA, 2) == (Math.Pow(_sideB, 2) + Math.Pow(_sideC, 2)))
                    return rectangular;
            }
            else if (_sideB > _sideA && _sideB > _sideC)
            {
                if (Math.Pow(_sideB, 2) == (Math.Pow(_sideA, 2) + Math.Pow(_sideC, 2)))
                    return rectangular;
            }
            else if (_sideC > _sideA && _sideC > _sideB)
            {
                if (Math.Pow(_sideC, 2) == (Math.Pow(_sideA, 2) + Math.Pow(_sideB, 2)))
                    return rectangular;
            }

            return notRectangular;
        }
    }
}