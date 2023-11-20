using MindBox_Shapes.DAL.Models;
using MindBox_Shapes.Tests.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox_Shapes.Tests.Tests
{
    public class CircleTests
    {
        [Test]
        public void CircleAreaTest_Valid()
        {
            var expectList = new List<AreaExpectModel>()
            { 
                new AreaExpectModel(new Circle(5), 78.53),
                new AreaExpectModel(new Circle(5.6), 98.52),
            };

            foreach (var expect in expectList) {
                Assert.True(expect.Shape.IsValid(), message: "Circle's properties are not valid");
                Assert.That(expect.Shape.CalculateArea(), Is.EqualTo(expect.ExpectedArea), message: "Shape's calculated area is not equal to expected value");
            }
        }

        [Test]
        public void CircleAreaTest_Invalid()
        {
            var expectList = new List<AreaExpectModel>()
            {
                new AreaExpectModel(new Circle(0), 78.53),
                new AreaExpectModel(new Circle(-14), 98.52),
                new AreaExpectModel(new Circle(-18.53), -100),
            };

            foreach (var expect in expectList)
            {
                Assert.False(expect.Shape.IsValid(), message: "Circle's invalid properties are valid");
            }
        }
    }
}
