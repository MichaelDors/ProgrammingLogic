namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        // Part 1: Operator Practice
        int a = 10;
        int b = 5;
        int c = 15;

        // Check if a is greater than b
        bool isAGreaterThanB = a > b;
        Console.WriteLine($"a > b: {isAGreaterThanB}");

        // Check if a is less than c
        bool isALessThanC = a < c;
        Console.WriteLine($"a < c: {isALessThanC}");

        // Check if a is greater than both b and c
        bool isAGreaterThanBoth = (a > b) && (a > c);
        Console.WriteLine($"a > b && a > c: {isAGreaterThanBoth}");

        // Combine expressions using && and ||
        bool combinedAnd = (a > b) && (a < c);
        bool combinedOr = (a > b) || (a > c);
        Console.WriteLine($"(a > b) && (a < c): {combinedAnd}");
        Console.WriteLine($"(a > b) || (a > c): {combinedOr}");

        // Part 2: Boolean Logic
        bool isRaining = true;
        bool haveUmbrella = false;

        if (isRaining && !haveUmbrella)
        {
            Console.WriteLine("Take an umbrella!");
        }
        else
        {
            Console.WriteLine("You're good to go!");
        }

        // Part 3: Conditional Logic – Movie Ticket Pricing
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        if (age < 5)
        {
            Console.WriteLine("Ticket is free!");
        }
        else if (age >= 5 && age <= 12)
        {
            Console.WriteLine("Child ticket: $5");
        }
        else if (age >= 13 && age <= 64)
        {
            Console.WriteLine("Standard ticket: $10");
        }
        else if (age >= 65)
        {
            Console.WriteLine("Senior ticket: $6");
        }

        // Part 4: Using a switch Statement
        Console.Write("Enter a day of the week (1-7): ");
        int dayNumber = int.Parse(Console.ReadLine());

        switch (dayNumber)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid day!");
                break;
        }
    }
}
