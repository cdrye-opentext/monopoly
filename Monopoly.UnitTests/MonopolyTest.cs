namespace Monopoly.UnitTests;

[TestClass]
public class MonopolyTest
{
    [TestMethod]
    public void Make_Sure_Rent_Is_Calculating_And_Logging_Doesnt_Explode()
    {
        // Arrange
        var logger = new DummyLogger();
        var monopolyGame = new MonopolyGame();
        monopolyGame.SetLogger(logger);
        var propertyName = "Mediterranean Avenue";
        var buildingCount = 0;
        
        // Act & Assert
        try
        {
            monopolyGame.CalculateRent(propertyName, buildingCount);
        }
        catch (Exception e)
        {
            Assert.Fail(e.Message);
        }
    }
}


public class DummyLogger : ILogger
{
    public void Log(string message)
    {
        // Do nothing
    }
}