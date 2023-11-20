using MindBox_Shapes.DAL.Interfaces;

namespace MindBox_Shapes.DAL.Models
{
    public class Triangle : IShape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double CalculateArea()
        {
            var s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public bool IsRightAngled()
        {
            //Проверка на прямоугольность
            return Math.Pow(SideA, 2) + Math.Pow(SideB, 2) == Math.Pow(SideC, 2) ||
                   Math.Pow(SideA, 2) + Math.Pow(SideC, 2) == Math.Pow(SideB, 2) ||
                   Math.Pow(SideB, 2) + Math.Pow(SideC, 2) == Math.Pow(SideA, 2);
        }

        //Треугольник существует только тогда, когда сумма двух его сторон больше третьей
        public bool IsValid()
        {
            bool sidesSum = SideA + SideB > SideC && SideA + SideC > SideB && SideB + SideC > SideA;
            bool sidesPositive = SideA > 0 && SideB > 0 && SideC > 0;

            return sidesSum && sidesPositive;
        }
    }
}
