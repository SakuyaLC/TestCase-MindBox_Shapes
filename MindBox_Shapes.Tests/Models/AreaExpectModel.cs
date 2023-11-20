using MindBox_Shapes.DAL.Interfaces;

namespace MindBox_Shapes.Tests.Models
{
    public class AreaExpectModel
    {
        public IShape Shape { get; set; }
        public double ExpectedArea { get; set; }

        public AreaExpectModel(IShape shape, double expectedArea) {
            Shape = shape;
            ExpectedArea = expectedArea;
        }
    }
}
