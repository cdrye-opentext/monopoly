namespace Monopoly;

public class Player
{
    public string Name { get; set; }
    public int Money { get; set; }

    public Player(string name) {
        Name = name.ToLower();
        Money = 200;
    }
}