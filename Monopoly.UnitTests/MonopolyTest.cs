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
    
    [TestMethod]
    public void Make_Sure_Rent_Is_Calculating_And_Does_Actually_Log()
    {
        // Arrange
        var logger = new MockLogger();
        var monopolyGame = new MonopolyGame();
        monopolyGame.SetLogger(logger);
        var propertyName = "Mediterranean Avenue";
        var buildingCount = 0;
        
        // Act & Assert
        try
        {
            monopolyGame.CalculateRent(propertyName, buildingCount);
            Assert.IsTrue(logger.LogLines.Any(l => l.Contains("Calculating rent for ")));
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

public class MockLogger : ILogger
{
    public List<string> LogLines { get; private set; } = new List<string>();
    
    public void Log(string message)
    {
        LogLines.Add(message);
    }
}