using MindBox_Shapes.DAL.Interfaces;

namespace MindBox_Shapes.DAL.Models
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public bool IsValid()
        {
            bool radius = Radius > 0;

            return radius;
        }
    }
}
