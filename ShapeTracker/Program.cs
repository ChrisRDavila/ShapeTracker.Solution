using System;
using ShapeTracker.Models;
using System.Collections.Generic;

namespace ShapeTracker
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Welcome to the Shape Tracker app!");
      Console.WriteLine("We'll calculate what type of triangle you have based off of the lengths of the triangle's 3 sides.");
      Console.WriteLine("Please enter a number:");
      string stringNumber1 = Console.ReadLine();  
      Console.WriteLine("Enter another number:");
      string stringNumber2 = Console.ReadLine();  
      Console.WriteLine("Enter a third number:");
      string stringNumber3 = Console.ReadLine();  
      int length1 = int.Parse(stringNumber1);  
      int length2 = int.Parse(stringNumber2);  
      int length3 = int.Parse(stringNumber3);  
      Triangle tri = new Triangle(length1, length2, length3);
      ConfirmOrEditTriangle(tri);
    }

    static void ConfirmOrEditTriangle(Triangle tri)
    {
      Console.WriteLine("Please confirm that you entered in your triangle correctly:");
      Console.WriteLine($"Side 1 has a length of {tri.Side1}.");
      Console.WriteLine($"Side 2 has a length of {tri.Side2}.");
      Console.WriteLine($"Side 3 has a length of {tri.GetSide3()}.");
      Console.WriteLine("Is that correct? Enter 'yes' to proceed, or 'no' to re-enter the triangle's sides");
      string userInput = Console.ReadLine();  
      if (userInput == "yes")
      {
        CheckTriangleType(tri);
      }
      else
      {
        Console.WriteLine("Let's fix your triangle. Please enter the 3 sides again!");
        Console.WriteLine("Please enter a number:");
        string stringNumber1 = Console.ReadLine();  
        Console.WriteLine("Enter another number:");
        string stringNumber2 = Console.ReadLine();  
        Console.WriteLine("Enter a third number:");
        string stringNumber3 = Console.ReadLine();  
        tri.Side1 = int.Parse(stringNumber1);  
        tri.Side2 = int.Parse(stringNumber2);  
        tri.SetSide3(int.Parse(stringNumber3)); 
        ConfirmOrEditTriangle(tri);
      }
    }

    static void CheckTriangleType(Triangle tri)
    {
      string result = tri.CheckType();
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("Your result is: " + result + ".");
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("What's next?");
      Console.WriteLine("Would you like to check a new triangle (new)?");
      Console.WriteLine("Please enter 'new' to check the type of a new triangle. To see all of your triangles, enter 'all'. To exit, enter any key.");
      string result = tri.CheckType();
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("Your result is: " + result + ".");
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("What's next?");
      Console.WriteLine("Would you like to check a new triangle (new)?");
      Console.WriteLine("Please enter 'new' to check the type of a new triangle. To see all of your triangles, enter 'all'. To clear all the triangle, enter 'clear'.To exit, enter any key.");
      string userResponse = Console.ReadLine(); 
      if (userResponse == "new" || userResponse == "New")
      {
        Main();
      }

      else if (userResponse == "all" || userResponse == "All")
      {
        List<Triangle> allTriangles = Triangle.GetAll();

        if (allTriangles.Count == 0)
        {
          Console.WriteLine("There are no triangles!");
        }
        else
        {
          Console.WriteLine("----------------------------------");
          foreach (Triangle triangle in allTriangles)
          {
            Console.WriteLine($"Side one of the triangle: {triangle.Side1}");
            Console.WriteLine($"Side two of the triangle: {triangle.Side2}");
            Console.WriteLine($"Side three of the triangle: {triangle.GetSide3()}");
            Console.WriteLine("----------------------------------");
          }  
        }

        Console.WriteLine("Would you like to check a new triangle (new), see your triangles or clear them?");
        Console.WriteLine("Please enter 'new' to check the type of a new triangle. To clear all the triangle, enter 'clear'.To exit, enter any key.");
        string userResponse2 = Console.ReadLine(); 
        if (userResponse2 == "new" || userResponse2 == "New")
        {
          Main();
        }
  
        else if (userResponse2 == "clear" || userResponse2 == "Clear")
        {
          // List<Triangle> allTriangles2 = Triangle.GetAll();
          Triangle.ClearAll();
          Console.WriteLine("hello!");
        }
        else
        {
          Console.WriteLine("Goodbye!");
        }

      }
      else if (userResponse == "clear" || userResponse == "Clear")
      {
        List<Triangle> allTriangles = Triangle.GetAll();
        Triangle.ClearAll();
      }
      else
      {
        Console.WriteLine("Goodbye!");
      }
    }
  }
}