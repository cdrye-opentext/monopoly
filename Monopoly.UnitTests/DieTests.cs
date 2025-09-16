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

            //Act
            //Roll dice 1
            //Roll dice 2

            //Assert
            //Assert that both dice were rolled and are valid (value = 1 -6, total between 2 and 12)
        }

        [TestMethod]
        public void Handle_Double_Die_Roll()
        {
            // Arrange
            Given_SetupGame();
            Given_BothDice_Are_Same_Value();
            
            // Act
            PerformTurn();
            
            // Assert
            // Should still be player 1's turn
            // Player 1 should have moved the correct number of spaces
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
        }


    }
}
