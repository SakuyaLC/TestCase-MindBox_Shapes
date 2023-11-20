namespace MindBox_Shapes.Tests.Tests
{
    public class CircleTests
    {
        [Test]
        public void CircleTest_Valid()
        {
            var expectList = new List<AreaExpectModel>()
            { 
                new AreaExpectModel(new Circle(5), 78.539816339744831),
                new AreaExpectModel(new Circle(5.6), 98.520345616575909),
            };

            foreach (var expect in expectList) {
                Assert.True(expect.Shape.IsValid(), message: "Shape's properties are not valid");
                Assert.That(expect.Shape.CalculateArea(), Is.EqualTo(expect.ExpectedArea), message: "Shape's calculated area is not equal to expected value");
            }
        }

        [Test]
        public void CircleTest_Invalid()
        {
            var expectList = new List<AreaExpectModel>()
            {
                new AreaExpectModel(new Circle(0), 78.53),
                new AreaExpectModel(new Circle(-14), 98.52),
                new AreaExpectModel(new Circle(-18.53), -100),
            };

            foreach (var expect in expectList)
            {
                Assert.False(expect.Shape.IsValid(), message: "Shape with invalid properties is considered valid");
            }
        }
    }
}
