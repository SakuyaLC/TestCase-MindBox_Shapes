namespace MindBox_Shapes.Tests.Tests
{
    public class TriangleTests
    {
        [Test]
        public void TriangleTest_Valid()
        {
            var expectList = new List<AreaExpectModel>()
            {
                new AreaExpectModel(new Triangle(2, 2, 3), 1.984313483298443),
                new AreaExpectModel(new Triangle(5.6, 2, 4.2), 3.4256532223796428),
            };

            foreach (var expect in expectList)
            {
                Assert.True(expect.Shape.IsValid(), message: "Shape's properties are not valid");
                Assert.That(expect.Shape.CalculateArea(), Is.EqualTo(expect.ExpectedArea), message: "Shape's calculated area is not equal to expected value");
            }
        }

        [Test]
        public void TriangleTest_Invalid()
        {
            var expectList = new List<AreaExpectModel>()
            {
                new AreaExpectModel(new Triangle(1, 2, 55), 0),
                new AreaExpectModel(new Triangle(5.6, 0, 4.2), 3.4256532223796383),
                new AreaExpectModel(new Triangle(5.6, -2, 4.2), -3.4256532223796383),
            };

            foreach (var expect in expectList)
            {
                Assert.False(expect.Shape.IsValid(), message: "Shape with invalid properties is considered valid");
            }
        }

        [Test]
        public void TriangleTest_RightAngled()
        {
            var model = new Triangle(6, 8, 10);

            Assert.True(model.IsRightAngled(), message: "Valid right angled triangle is considered not right angled");
        }

        [Test]
        public void TriangleTest_NotRightAngled()
        {
            var model = new Triangle(5, 8, 10);

            Assert.False(model.IsRightAngled(), message: "Not right angled triangle is considered right angled");
        }
    }
}
