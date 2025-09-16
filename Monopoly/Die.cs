namespace Monopoly
{
  public class Die
  {
    // Current face value of the die
    private int _faceValue;

    // Number of sides on the die
    private readonly int _sides;

    // Shared random number generator for all dice
    private static readonly Random _random = new Random();

    // Public property to expose number of sides
    public int Sides => _sides;

    // Public property to expose current face value
    public int FaceValue => _faceValue;

    // Default constructor creates a 6-sided die
    public Die() : this(6) { }

    // Constructor for a die with a custom number of sides
    public Die(int sides)
    {
      if (sides < 2)
        throw new ArgumentException("A die must have at least 2 sides.");
      _sides = sides;
      Roll(); // initialize with a valid value
    }

    // Roll the die to get a random face value
    public void Roll()
    {
      _faceValue = _random.Next(1, _sides + 1);
    }

    // Return the face value as a string like "[3]"
    public override string ToString()
    {
      return $"[{_faceValue}]";
    }

    // Roll multiple dice at once and return the sum
    public static int RollMultiple(params Die[] dice)
    {
      int total = 0;
      foreach (var die in dice)
      {
        die.Roll();
        total += die.FaceValue;
      }
      return total;
    }
  }
}