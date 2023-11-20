using MindBox_Shapes.DAL.Interfaces;
using MindBox_Shapes.DAL.Models;

var shapesList = new List<IShape>()
{
    new Circle(5),
    new Triangle(6, 8, 10),
    new Circle(12.5),
    new Triangle(2, 3, 4),
};

var totalArea = AreaCalculator.CalculateArea(shapesList);
Console.WriteLine(totalArea);
