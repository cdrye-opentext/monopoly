namespace Monopoly;

public class Player
{
    public string Name { get; set; }
    public int Money { get; set; }
    public List<string> Properties {  get; set; }

    public Player(string name)
    {
        Name = name.ToLower();
        Money = 200;
        Properties = new List<string>();
    }

    public void UpdateCash(int amount)
    {
        Money += amount;
    }

    public bool IsBankrupt()
    {
        return Money <= 0;
    }

}