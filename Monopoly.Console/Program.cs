using Monopoly; // Adjust if your Die class has a different namespace

namespace Monopoly.ConsoleApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Die d = new Die();

      for (int i = 0; i < 10; i++)
      {
        d.Roll();
        Console.WriteLine("Die was rolled, result is: " + d.FaceValue);
      }

      // Optional: Wait for input before closing
      //small change
      // Console.ReadLine();
    }
  }
}
