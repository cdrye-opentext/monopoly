namespace Monopoly
{
    // This class violates all SOLID principles intentionally
    public class PlayerManager
    {
        // SRP violation: Handles player data, movement, money, properties, dice, and output
        public List<Player> Players = new List<Player>();
        public Dictionary<string, int> Money = new Dictionary<string, int>();
        public Dictionary<string, List<string>> Properties = new Dictionary<string, List<string>>();
        public Die Die = new Die(); // DIP violation: depends on concrete Die

        public PlayerManager(IEnumerable<Player> players)
        {
            Players.AddRange(players);
            // OCP violation: Hardcoded player setup
            // Players.Add("Alice");
            // Players.Add("Bob");
            // Money["Alice"] = 1500;
            // Money["Bob"] = 1500;
            // Properties["Alice"] = new List<string>();
            // Properties["Bob"] = new List<string>();
        }

        // SRP & ISP violation: Does too much, no interface
        public void PlayTurn(Player player)
        {
            if (player.IsBankrupt())
            {
                RemovePlayer(player);
                return;
            }


            Die.Roll(); // Roll the die, updates FaceValue
            int roll = Die.FaceValue; // Get the result

            Console.WriteLine(player + " rolled a " + roll);

            // Move player (not implemented, just a print)
            Console.WriteLine(player + " moves " + roll + " spaces.");

            // Randomly give money or property
            if (roll % 2 == 0)
            {
                player.Money += 200;
                Console.WriteLine(player + " receives $200.");
            }
            else
            {
                player.Properties.Add("Boardwalk");
                Console.WriteLine(player + " acquires Boardwalk.");
            }

            // OCP violation: Hardcoded rules, not extensible
            if (player.Money > 2000)
            {
                Console.WriteLine(player + " wins!");
            }
        }

        public void RemovePlayer(Player player)
        {
            Players.Remove(player);

        }


        // SRP violation: Handles printing
        public void PrintStatus()
        {
            foreach (var player in Players)
            {
                Console.WriteLine(player + " has $" + Money[player.Name] + " and owns: " + string.Join(", ", Properties[player.Name]));
            }
        }
    }
}