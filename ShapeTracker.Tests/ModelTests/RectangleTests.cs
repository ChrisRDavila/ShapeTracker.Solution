using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;
using System.Collections.Generic;
using System;

namespace ShapeTracker.Tests
  {
    [TestClass]
    public class RectangleTests
    {
      
      [TestMethod]
      public void RectangleConstructor_CreateInstanceOfRectangle_Rectangle()
      {
        Rectangle newRectangle = new Rectangle(2, 4);
        Assert.AreEqual(typeof(Rectangle), newRectangle.GetType());
      }

      [TestMethod]
      public void GetSideX_ReturnSideX_Int()
      {
        int lengthX = 4;
        Rectangle newRectangle = new Rectangle(lengthX, 4); 
        int result  = newRectangle.XSide;
        Assert.AreEqual(lengthX, result);
      }

      [TestMethod]
      public void SetSideX_SetsValueSideX_Void()
      {
        //Arrange
        Rectangle newRectangle = new Rectangle(4, 6);
        int newLengthX = 12;
        // Act
        newRectangle.XSide = newLengthX;
        //Assert
        Assert.AreEqual(newLengthX, newRectangle.XSide);
      }

      [TestMethod]
      public void GetSideY_ReturnsSideY_Int()
      {
        //Arrange
        int lengthY = 6;
        Rectangle newRectangle = new Rectangle(5, lengthY);
        //Act
        int result = newRectangle.YSide;
        //Assert
        Assert.AreEqual(lengthY, result);
      }

      [TestMethod]
      public void SetSideY_SetsValueOfSideY_Void()
      {
        // Arrange
        Rectangle newRectangle = new Rectangle(4, 6);
        int newLengthY = 8;
        // Act
        newRectangle.YSide = newLengthY;
        //Assert
        Assert.AreEqual(newLengthY, newRectangle.YSide);

      }
      [TestMethod]
      public void GiveType_DeterminesIfSquare_String()
      {
        //Arrange 
        Rectangle isRectangle = new Rectangle(3, 4);
        //Act
        string recType = isRectangle.CheckRectangle();
        // Assert
        Assert.AreEqual("rectangle", recType);
      }
      
      [TestMethod]
      public void GiveType_DeterminesIsSquare_String()
      {
        //Arrange 
        Rectangle isRectangle = new Rectangle(4, 4);
        //Act
        string squType = isRectangle.CheckRectangle();
        // Assert
        Assert.AreEqual("square", squType);
      }
      
    }
  }