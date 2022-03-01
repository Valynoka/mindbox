using System;

namespace SFigures
{
  public class OtherFigures : AllFigures
  {
    private readonly AllFigures _figure;

    public OtherFigures(double radius)
    {
      _figure = new Circle(radius);
    }

    public OtherFigures(double sideA, double sideB, double sideC)
    {
      _figure = new Triangle(sideA, sideB, sideC);
    }

    public double Area => _figure.Area;
  }
}