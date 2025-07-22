
namespace Monopoly
{
  public class Die
  {
    int _faceValue;
    public int FaceValue
    {
      get
      {
        return _faceValue;
      }
    }
    private static Random _random = new Random();

    public void Roll()
    {
      _faceValue = _random.Next(1, 6);
    }
  }
}
