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
            if (result < 1 || result > 6)
            {
                Assert.Fail();
            }
        }
        
        [TestMethod]
        public void Die_Roll_Player_Can_Roll_2_Dice()
        {
            //Arrange
            //Create game
            //Create player
            //Create 2 dice
            var d1 = new Die();
            var d2 = new Die();

            //Act
            //Roll dice 1
            //Roll dice 2
            Die.RollMultiple(d1, d2);
            int result1 = d1.FaceValue;
            int result2 = d2.FaceValue;
            int total = result1 + result2;

            //Assert
            //Assert that both dice were rolled and are valid (value = 1 -6, total between 2 and 12)
            Assert.IsTrue(result1 >= 1 && result1 <= 6, $"Die 1 roll is out of bounds: {result1}");
            Assert.IsTrue(result2 >= 1 && result2 <= 6, $"Die 2 roll is out of bounds: {result2}");
            Assert.IsTrue(total >= 2 && total <= 12, $"Total roll is out of bounds: {total}");
        }

        [TestMethod]
        public void Handle_Double_Die_Roll()
        {
            // Arrange
            Given_SetupGame();
            Given_BothDice_Are_Same_Value();
            
            // Act
            // PerformTurn();
            
            // Assert
            // Should still be player 1's turn
            // Player 1 should have moved 6 spaces
            // Player 1 should have the ability to roll the dice again

        }


        [TestInitialize]
        public void Given_SetupGame()
        {
            //Arrange
            //Create game
            //Create player
            //Create 2 dice
        }


        public void Given_BothDice_Are_Same_Value()
        {
            // Return a dice value of 3 and a dice value of 3
        }


    }
}
