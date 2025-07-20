namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
        //Problem 1: Simple For Loop
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        //Problem 2: Even Numbers from 1 to 20 (Using Modulus Operator)
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }

        //Problem 3: While Loop Countdown
        int count = 5;
        while (count >= 1)
        {
            Console.WriteLine(count);
            count--;
        }

        //Problem 4: While Loop – Multiples of 10 from 10 to 1000
        int num = 10;
        while (num <= 1000)
        {
            Console.WriteLine(num);
            num += 10;
        }

        //Problem 5: Seasons of the Year
        string[] seasons = { "Spring", "Summer", "Fall", "Winter" };
        foreach (string season in seasons)
        {
            Console.WriteLine("Season: " + season);
        }

        //Problem 6: Days of the Week (1–7)
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        Console.Write("Enter a number from 1 to 7: ");
        string input = Console.ReadLine();
        int dayNum;
        if (int.TryParse(input, out dayNum) && dayNum >= 1 && dayNum <= 7)
        {
            Console.WriteLine("Day: " + days[dayNum - 1]);
        }
        else
        {
            Console.WriteLine("Invalid entry");
        }

        //Problem 7: Favorite Books and Authors
        string[] favBooks = { "A Wrinkle In Time", "Michael Vey", "The Three Investigators" };
        string[] favAuthors = { "Madeleine L'Engle", "Richard Paul Evans", "Robert Arthur Jr." };
        for (int i = 0; i < favBooks.Length; i++)
        {
            Console.WriteLine(favBooks[i] + " by " + favAuthors[i]);
        }

        //Problem 8: Temperature Tracker
        int[] temps = { 73, 67, 82, 69, 77 };
        Array.Sort(temps);
        Console.WriteLine("Temperatures in ascending order:");
        foreach (int temp in temps)
        {
            Console.WriteLine(temp);
        }
        Console.WriteLine("Lowest temperature: " + temps[0]);
        Console.WriteLine("Highest temperature: " + temps[temps.Length - 1]);
        
        //Problem 9: Reverse Countdown
        int[] reverseCountdown = { 5, 4, 3, 2, 1 };
        Array.Reverse(reverseCountdown);
        Console.WriteLine("Reversed countdown:");
        for (int i = 0; i < reverseCountdown.Length; i++)
        {
            Console.WriteLine(reverseCountdown[i]);
        }
    }
}