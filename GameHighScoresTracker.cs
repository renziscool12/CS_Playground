using System;
using System.Collections.Generic;
using System.Linq;

public class GameHighScoresTracker
{
    public static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        Console.Write("How many players? ");
        int players = int.Parse(Console.ReadLine());
        Console.WriteLine();
        
        for(int i = 0;  i < players; i++) 
        {
            Console.Write("Enter Score #" + (i+1) + ": ");
            int score = int.Parse(Console.ReadLine());
            numbers.Add(score);
        }
        Console.WriteLine();
        
        Console.Write("All scores: ");
        for(int i = 0; i < numbers.Count; i++) 
        {
            Console.Write(numbers[i] + ", ");
        }
        
        int max = numbers.Max();
        int min = numbers.Min();
        int ave = (int)numbers.Average();
        
        Console.WriteLine("\nHighest Score: " + max);
        Console.WriteLine("Lowest Score: " + min);
        Console.WriteLine("Average Score: " + ave);
        
        Console.WriteLine("Scores above average: ");
        List<int> above = numbers.Where(n => n > ave).ToList();
        foreach(int a in above)
        {
            Console.Write(a + ", ");
        }
    }
}
