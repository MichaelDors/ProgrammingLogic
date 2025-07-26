using System;

class Car
{
    public string model;
    public string color;
    public int year;

    // Example method to display car details.
    public void Display()
    {
        Console.WriteLine("Car Details:");
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Color: " + color);
        Console.WriteLine("Year: " + year);
    }

    // Method to start the car
    public void Start()
    {
        Console.WriteLine("The car is starting.");
    }

    // Method to drive x miles
    public void Drive(int miles)
    {
        Console.WriteLine("The car drove " + miles + " miles.");
    }

    // Method returns a description of the car
    public string GetDescription()
    {
        return year + " " + color + " " + model;
    }

    // Method to repaint the car
    public void Repaint(string newColor)
    {
        color = newColor;
        Console.WriteLine("The car has been repainted to " + newColor + ".");
    }
}

class Program
{
    static void Main()
    {
        // Creating a Car object and assigning values to its properties
        Car myCar = new Car();
        myCar.model = "Civic";
        myCar.color = "Black";
        myCar.year = 2020;

        myCar.Display(); // Calling the Display method
        myCar.Start();   // Calling the Start method
        myCar.Drive(50); // Calling the Drive method with 50 miles

        // Get the description and print it
        string description = myCar.GetDescription();
        Console.WriteLine(description);

        // Repaint the car to red and confirm color is updated
        myCar.Repaint("red");
        Console.WriteLine("Updated color: " + myCar.color);
    }
}