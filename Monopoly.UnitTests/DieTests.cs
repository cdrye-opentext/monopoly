namespace Monopoly.UnitTests
{
  [TestClass]
  public sealed class DieTests
  {
    [TestMethod]
    public void Die_Rolls_Between_1_and_6()
    {
      // Arrange
      Die d = new Die();

      // Act
      d.Roll();
      int result = d.FaceValue;

      // Assert
      if (result < 1 || result > 6) { Assert.Fail(); }
    }
  }
}
