namespace Monopoly
{
  public class RentCalculator
  {
    // Warning: legacy mess. Do not touch unless you have band-aids nearby.
    public static int CalculateRent(string propertyName, int houses, bool hotel, bool isMortgaged, string colorGroupOwner)
    {
      int rent = 0;

      if (propertyName == "Boardwalk")
      {
        rent = RentForBoardwalk(houses, hotel, colorGroupOwner);
      }
      else if (propertyName == "Park Place")
      {
        if (hotel)
        {
          rent = 1500;
        }
        else if (houses == 4)
        {
          rent = 1100;
        }
        else if (houses == 3)
        {
          rent = 800;
        }
        else if (houses == 2)
        {
          rent = 600;
        }
        else if (houses == 1)
        {
          rent = 175;
        }
        else
        {
          rent = 35;
          if (colorGroupOwner == "DarkBlue")
          {
            rent = rent * 2;
          }
        }
      }
      else if (propertyName == "Baltic Avenue")
      {
        if (hotel)
        {
          rent = 450;
        }
        else if (houses == 4)
        {
          rent = 250;
        }
        else if (houses == 3)
        {
          rent = 100;
        }
        else if (houses == 2)
        {
          rent = 60;
        }
        else if (houses == 1)
        {
          rent = 10;
        }
        else
        {
          rent = 4;
          if (colorGroupOwner == "Brown")
          {
            rent = rent * 2;
          }
        }
      }
      else
      {
        // Default: unknown property
        Console.WriteLine("Warning: Rent not configured properly for property: " + propertyName);
        rent = 0;
      }

      if (isMortgaged)
      {
        rent = 0;
      }

      return rent;
    }

    public static int RentForBoardwalk(int houses, bool hotel, string colorGroupOwner)
    {
      int rent;
      if (hotel)
      {
        rent = 2000;
      }
      else if (houses == 4)
      {
        rent = 1700;
      }
      else if (houses == 3)
      {
        rent = 1100;
      }
      else if (houses == 2)
      {
        rent = 600;
      }
      else if (houses == 1)
      {
        rent = 200;
      }
      else
      {
        rent = 50;
        if (colorGroupOwner == "DarkBlue")
        {
          rent = rent * 2;
        }
      }

      return rent;
    }
  }
}