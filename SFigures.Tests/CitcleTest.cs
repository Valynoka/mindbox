using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SFigures.Tests
{
  [TestClass]
  public class CircleTests
  {
    [TestMethod]
    public void Circle_0_Returned_0()
    {
      //arrange
      Circle circle = new Circle(0);
      double correctArea = 0;

      //act
      double area = circle.Area;

      //assert
      Assert.AreEqual(correctArea, area);
    }

    [TestMethod]
    public void Circle_4_Returned_50_27()
    {
      //arrange
      Circle circle = new Circle(4);
      double correctArea = 50.27;

      //act
      double area = Math.Round(circle.Area, 2);

      //assert
      Assert.AreEqual(correctArea, area);
    }
  }
}
