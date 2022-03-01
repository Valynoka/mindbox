using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SFigures.Tests
{
  [TestClass]
  public class OtherFiguresTest
  {
    [TestMethod]
    public void OtherFigures_4_Returned_50_24()
    {
      //arrange
      OtherFigures circle = new OtherFigures(4);
      double correctArea = 50.27;

      //act
      double area = Math.Round(circle.Area, 2);

      //assert
      Assert.AreEqual(correctArea, area);
    }

    [TestMethod]
    public void OtherFigures_3_4_5_6Return()
    {
      //arrange
      OtherFigures triangle = new OtherFigures(3, 4, 5);
      double correctArea = 6;

      //act
      double area = triangle.Area;

      //assert
      Assert.AreEqual(correctArea, area);
    }
  }
}