using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace sFigures
{

  class S_figures
  {
    static void Main()
    {

      System.Console.Write("Введите тип фигуры: ");
      string nameOfFigure = Console.ReadLine();

      if (nameOfFigure == "circle")
      {
        Console.Write("Введите значение радиуса: ");
        double rCircle = Convert.ToDouble(Console.ReadLine());
        double resC = SCircle(rCircle);
        Print(resC.ToString());
      }
      else if (nameOfFigure == "triangle")
      {
        System.Console.Write("Ваш треугольник прямоугольный?: ");
        string nameOfTriangle = Console.ReadLine();
        if (nameOfTriangle == "yes")
        {
          Console.Write("Введите значение стороны а: ");
          double a = Convert.ToDouble(Console.ReadLine());
          Console.Write("Введите значение стороны b: ");
          double b = Convert.ToDouble(Console.ReadLine());
          double resRT = SRightTriangle(a, b);
          Print(resRT.ToString());
        }
        else if (nameOfTriangle == "no")
        {
          Console.Write("Введите значение стороны а: ");
          double a = Convert.ToDouble(Console.ReadLine());
          Console.Write("Введите значение стороны b: ");
          double b = Convert.ToDouble(Console.ReadLine());
          Console.Write("Введите значение стороны c: ");
          double c = Convert.ToDouble(Console.ReadLine());
          double resT = STringle(a, b, c);
          Print(resT.ToString());
        }
      }
      else
      {
        System.Console.WriteLine("Подобной фигуры нет в базе");
      }
    }
    public static double SCircle(double x)
    {
      return Math.PI * x * 2;
    }
    public static double STringle(double x, double y, double z)
    {
      double p = (x + y + z) / 2;
      return Math.Sqrt(p * (p - x) * (p - y) * (p - z));
    }
    public static double SRightTriangle(double x, double y)
    {
      return (x * y) / 2;
    }
    public static void Print(string word)
    {
      Console.WriteLine("Площадь фигуры = {0}", word);
    }
  }
}