using MindBox_Shapes.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
