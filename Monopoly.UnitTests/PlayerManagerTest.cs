using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.UnitTests
{
    [TestClass]
    public class PlayerManagerTest
    {

        [TestMethod]
        public void PlayerManagerShouldHave2Players()
        {
            //Arrange            
            var players = new List<Player>() {
                new Player("Alice"),
                new Player("Bob")
            };
            //Act
            PlayerManager playerManager = new PlayerManager(players);

            //Assert
            Assert.IsTrue(playerManager.Players.Count == 2);



        }

        [TestMethod]
        public void PlayerManager_AliceShouldHaveMoney()
        {
            //Arrange            
            var players = new List<Player>() {
                new Player("Alice"),
                new Player("Alice")
            };
            //Act
            PlayerManager playerManager = new PlayerManager(players);

            //Assert
            Assert.IsTrue(playerManager.Players[0].Money > 0);

        }
    }
}
