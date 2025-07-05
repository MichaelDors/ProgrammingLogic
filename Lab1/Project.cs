using System;

  class Program
  {
    static void Main(string[] args)
    {
      // Step 1 - use comments
      /*
        Name: Michael Dors
        Title: IT-1050 - Lab 1
      */
      // Step 2 - basic output
      Console.WriteLine("Name: Michael Dors");
      Console.WriteLine("Course title: IT-1050");
      //Step 3 - declare + use variables
      int favoriteNumber = 7;
      Console.WriteLine("My favorite number is " + favoriteNumber);
      string favoriteProgrammingLanguage = "JavaScript";
      Console.WriteLine(favoriteProgrammingLanguage + " is my favorite programming language I've worked with.");
      double numberOfPrograms = 11.0d;
      Console.WriteLine("I've probably written around " + numberOfPrograms + " programs, but that's a rough estimate.");
      bool programmingExperience = true;
      Console.WriteLine("It's " + programmingExperience + " that I have some programming experience.");
      //Step 4 - use constants
      const string myHighSchoolName = "Medina Christian Academy";
      const string myCollegeName = "Cuyahoga Community College";
      Console.WriteLine("I attend " + myHighSchoolName + ", but also " + myCollegeName + " for some classes through Dual Enrollment");
      //Step 5 - type casting
    double doubleValue = 9.78d;
    int intValue = (int)doubleValue;
    string stringFromInt = Convert.ToString(intValue);
    string stringFromBool = Convert.ToString(programmingExperience);
    
    Console.WriteLine("double: " + doubleValue);
    Console.WriteLine("int: " + intValue);
    Console.WriteLine("string from int: " + stringFromInt);
    Console.WriteLine("string from bool: " + stringFromBool);
    //Step 6 - user input / type conversion
    Console.Write("Please enter your name: ");
    string userName = Console.ReadLine();
    
    Console.Write("Please enter your age: ");
    int userAge = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Hello " + userName + "! You are " + userAge + " years old.");
    //Step 7 - arithmetic operators 
    int num1 = 20;
    int num2 = 6;
    
    Console.WriteLine("num1 = " + num1);
    Console.WriteLine("num2 = " + num2);
    
    Console.WriteLine("num1 Addition result: " + num1 + " + 10 = " + (num1 + 10));
    Console.WriteLine("num1 Subtraction result: " + num1 + " - 2 = " + (num1 - 2));
    Console.WriteLine("num1 Multiplication result: " + num1 + " * 3 = " + (num1 * 3));
    Console.WriteLine("num1 Division result: " + num1 + " / 2 = " + (num1 / 2));
    Console.WriteLine("num1 Modulus result: " + num1 + " % 2 = " + (num1 % 2));

    Console.WriteLine("num2 Addition result: " + num2 + " + 10 = " + (num2 + 10));
    Console.WriteLine("num2 Subtraction result: " + num2 + " - 2 = " + (num2 - 2));
    Console.WriteLine("num2 Multiplication result: " + num2 + " * 3 = " + (num2 * 3));
    Console.WriteLine("num2 Division result: " + num2 + " / 2 = " + (num2 / 2));
    Console.WriteLine("num2 Modulus result: " + num2 + " % 2 = " + (num2 % 2));
    //Step 8
    float floatValue = 1.123456789f;
    double doubleValue2 = 1.123456789d;
    
    Console.WriteLine("Float value: " + floatValue);
    Console.WriteLine("Double value: " + doubleValue2);
    //Step 9
    int number = 10;
    Console.WriteLine("Initial value: " + number);
    
    number++;
    Console.WriteLine("After increment: " + number);
    
    number--;
    Console.WriteLine("After decrement: " + number);
    }
  }
