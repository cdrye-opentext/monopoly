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

        [TestMethod]
        public void PlayerManager_Can_Remove_Player()
        {
            // this method would be called when a rule determines a player is bankrupt - no cash and no properties
            //Arrange

            var playerAlice =  new Player("Alice");
            var players = new List<Player>() {
                playerAlice,
                new Player("Bob")
            };
            PlayerManager playerManager = new PlayerManager(players);
            playerAlice.UpdateCash(-200);

            //Act
            playerManager.PlayTurn(playerAlice);
            
            //Assert
            Assert.IsTrue(playerManager.Players.Count == 1);
            var alice = playerManager.Players.FirstOrDefault(p => p.Name == "Alice");
            Assert.IsNull(alice);
        }
        
    }
}
