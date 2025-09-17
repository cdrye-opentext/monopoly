using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;

namespace Monopoly.UnitTests
{
    [TestClass]
    public class RentCalculatorTests
    {
        [TestMethod]
        public void Rent_For_Single_Property_Is_Base_Rent()
        {
            // Arrange
            var testProperty = new Property(10);

            // Act
            int rent = testProperty.GetCurrnentRent();

            // Assert
            Assert.AreEqual(rent, 10);
        }


        [TestMethod]
        public void Given_A_House_Is_Built_Rent_Is_Increased()
        {
            //Arrange
            var testProperty = new Property(10);

            //Act
            testProperty.AddHouse();
            var rent = testProperty.GetCurrnentRent();

            //Assert
            Assert.AreEqual(rent, 70);

        }
    }
}
