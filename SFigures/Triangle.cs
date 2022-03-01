using System;

namespace SFigures
{
  public class Triangle : AllFigures
  {
    private readonly double _x, _y, _z;

    public Triangle(double x, double y, double z)
    {
      _x = x;
      _y = y;
      _z = z;
    }

    public double Area
    {
      get
      {
        double p = (_x + _y + _z) / 2;
        return Math.Sqrt(p * (p - _x) * (p - _y) * (p - _z));
      }
    }

    public bool IsRightTriangle()
    {
      return 
      _x == Math.Sqrt(Math.Pow(_y, 2) + Math.Pow(_z, 2)) ||
      _y == Math.Sqrt(Math.Pow(_x, 2) + Math.Pow(_z, 2)) ||
      _z == Math.Sqrt(Math.Pow(_x, 2) + Math.Pow(_y, 2));
    }
  }
}