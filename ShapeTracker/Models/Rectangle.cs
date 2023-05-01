using System.Collections.Generic;

namespace ShapeTracker.Models
{
  public class Rectangle
  {
    private int _xSide;
    public int XSide
    {
      get {return _xSide;}
      set { _xSide = value;}
    }
    // public int Yside { get; set; }
    // public Rectangle (int lengthX)
    // {
    //   _xSide = lengthX;
    // }


    public int YSide { get; set; }
    public Rectangle (int lengthX, int lengthY)
    {
      _xSide = lengthX;
      YSide = lengthY;
    }

    public string CheckRectangle()
    {
      if (XSide != YSide)
      {
        return "rectangle";
      }
      else
      {
        return "square";
      }
    }

  }
}