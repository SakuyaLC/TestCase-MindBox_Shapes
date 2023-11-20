using MindBox_Shapes.DAL.Interfaces;

namespace MindBox_Shapes.DAL.Models
{
    public static class AreaCalculator
    {
        public static double CalculateArea(IEnumerable<IShape> shapes)
        {
            double totalArea = 0;

            foreach (var shape in shapes)
            {
                totalArea += shape.CalculateArea();
            }

            return totalArea;
        }

        public static double CalculateArea(IShape shape)
        {
            return shape.CalculateArea();
        }
    }
}
