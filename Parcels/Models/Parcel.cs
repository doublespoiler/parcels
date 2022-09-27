using System.Collections.Generic;

namespace Parcels.Models
{
  public class Parcel
  {
    public string Name { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }
    public int Depth { get; set; }
    public int Weight { get; set; }

    public static List<Parcel> _instances = new List<Parcel>{};

    public Parcel(string name, int height, int width, int depth, int weight)
    {
      Name = name;
      Height = height;
      Width = width;
      Depth = depth;
      Weight = weight;
      _instances.Add(this);
    }

    public static List<Parcel> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public int Volume()
    {
      int volume = Height * Width * Depth;
      return volume;
    }

    public float CostToShip()
    {
      //medium flat rate 430in^3
      //medium 5lbs
      //5 * 430 = 2150 
      // 2150/100 = $20 + 5
      float costToShip = (Weight * Volume()) / 100 + 5;
      return costToShip;
    }
  }
}