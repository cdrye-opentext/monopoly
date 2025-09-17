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
            int rent = testProperty.GetCurrentRent();

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
            var rent = testProperty.GetCurrentRent();

            //Assert
            Assert.AreEqual(rent, 70);

        }

        [TestMethod]
        public void Given_Boardwalk_Has_No_Houses_And_No_Hotel_And_Isnt_Mortgaged_And_Isnt_Monopolized_Then_Calculate_Rent()
        {
            // Arrange & Act
            var rent = RentCalculator.CalculateRent("Boardwalk", 0,false,false,"Blue");
            // Assert
            Assert.AreEqual(rent, 50);
        }
        
        [TestMethod]
        [DataRow(0,false,"DarkBlue",100)]
        [DataRow(0,false,"Blue",50)]
        [DataRow(1,false,"DarkBlue",200)]
        [DataRow(2,false,"DarkBlue",600)]
        [DataRow(3,false,"DarkBlue",1100)]
        [DataRow(4,false,"DarkBlue",1700)]
        [DataRow(0,true,"DarkBlue",2000)] // with hotel
        // // mortgaged
        // [DataRow(0,false,true,"DarkBlue",0)]
        // [DataRow(1,false,true,"DarkBlue",0)]
        // [DataRow(2,false,true,"DarkBlue",0)]
        // [DataRow(3,false,true,"DarkBlue",0)]
        // [DataRow(4,false,true,"DarkBlue",0)]
        // [DataRow(0,true,true,"DarkBlue",0)] // with hotel
        public void Given_Boardwalk_Has_No_Houses_And_No_Hotel_And_Isnt_Mortgaged_And_Isnt_Monopolized_Then_Calculate_Rent(
            int houseCount, 
            bool hasHotel, 
            string color, 
            int expectedRent
            )
        {
            // Arrange & Act
            var rent = RentCalculator.RentForBoardwalk(houseCount, hasHotel, color);
            // Assert
            Assert.AreEqual(rent, expectedRent);
        }
    }
}
