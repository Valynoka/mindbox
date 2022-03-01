using System;

namespace SFigures
{
  public class Circle : AllFigures
  {
    private readonly double _radius;

    public Circle(double radius)
    {
      _radius = radius;
    }

    public double Area
    {
      get
      {
        return Math.PI* Math.Pow(_radius, 2);
      }
    }
  }
}