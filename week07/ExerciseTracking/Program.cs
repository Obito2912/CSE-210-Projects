using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running("Running", new DateOnly(2025, 2, 23), 40, 5);
        Cycling cycling = new Cycling("Cycling", new DateOnly(2023, 7, 15), 50, 20);
        Swimming swimming = new Swimming("Swimming", new DateOnly(2024, 5, 03), 25, 20);

        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        Console.WriteLine();
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
        Console.WriteLine();
    }
}