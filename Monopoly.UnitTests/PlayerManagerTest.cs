using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.UnitTests
{
    [TestClass]
    internal class PlayerManagerTest
    {

        [TestMethod]
        public void PlayerManagerShouldHave2Players()
        { 
            //Arrange
            PlayerManager playerManager = new PlayerManager();

            //Act
            playerManager.PlayTurn("Alice");

            //Assert
            Assert.IsTrue(playerManager.Players.Count == 2);



        }

        [TestMethod]
        public void PlayerManager_AliceShouldHaveMoney()
        {
            //Arrange
            PlayerManager playerManager = new PlayerManager();

            //Act
            playerManager.PlayTurn("Alice");

            //Assert
            Assert.IsTrue(playerManager.Money["Alice"] > 0);

        }
    }
}
