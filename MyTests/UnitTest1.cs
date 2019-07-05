using AllisonFunProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ItAdds10and5()
        {
            //Arrange
            var a = 10;
            var b = 5;
            var expectedResult = a + b;
            var myClass = new TestThing();

            //Act
            var result = myClass.ItAddsStuff(a, b);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void ItAdds10and10()
        {
            //Arrange
            var a = 10;
            var b = 10;
            var expectedResult = a + b;
            var myClass = new TestThing();

            //Act
            var result = myClass.ItAddsStuff(a, b);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
