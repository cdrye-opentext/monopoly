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
      var calc = new RentCalculator();

      // Act
      int rent = calc.GetRent(10);

      // Assert
      Assert.AreEqual(10, rent);
    }
  }
}
