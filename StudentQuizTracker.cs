
namespace PracticeSet8;

class Program
{
    static void Main(string[] args)
    {
        double[,] scoress = GetSCORES();
        DisplayScores(scoress);

    }

    static double[,] GetSCORES()
    {
        int students;
       
        while (true)
        {
            Console.WriteLine("Enter how many students? ");
            if (int.TryParse(Console.ReadLine(), out students) && students > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("ERROR: SCORE INVALID INPUT");
            }
        }

        int quizes;
        while (true)
        {
            Console.WriteLine("Enter how many quizes? ");
            if (int.TryParse(Console.ReadLine(), out quizes) && quizes > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("ERROR: SCORE INVALID INPUT");
            }
        }

        double[,] scores = new double[students, quizes];

            for (int i = 0; i < students; i++)
            {
                for (int j = 0; j < quizes; j++)
                {
                    double value;
                    while (true)
                    {
                        Console.Write($"Student {i + 1} - Quiz {j + 1}: ");
                        if (double.TryParse(Console.ReadLine(), out value) && value > 0)
                        {
                            break;
                        }
                        Console.WriteLine("Invalid input must be >= 0");
                    }

                    scores[i, j] = value;
                }
            }
        return scores;
    }

    static double GetHighest(double[,] scores)
    {
        double highest = Double.MinValue;

        foreach (double a in scores)
        {
            if (a > highest)
                highest = a;
        }

        return highest;
    }

    static double GetLowest(double[,] scores)
    {
        double lowest = Double.MaxValue;

        foreach (double b in scores)
        {
            if (b < lowest)
                lowest = b;
        }

        return lowest;
    }

    static double GetAverage(double[,] scores)
    {
        double average = 0;

        foreach (double c in scores)
        {
            average += c;
        }

        return average / scores.Length;
    }

    static void DisplayScores(double[,] scores)
    {
        Console.WriteLine("\nSTUDENT SCORES");
        Console.WriteLine("------------------------------");
       for(int i = 0; i < scores.GetLength(0); i++)
       {
           Console.Write($"Student {i + 1}: ");
           for (int j = 0; j < scores.GetLength(1); j++)
           {
               Console.Write($"{scores[i, j]:F2}");
           }
           Console.WriteLine();
       }

        double highest = GetHighest(scores);
        double lowest = GetLowest(scores);
        double average = GetAverage(scores);

        Console.WriteLine("SUMMARY");
        Console.WriteLine($"HIGHEST SCORE: {highest}");
        Console.WriteLine($"LOWEST SCORE: {lowest}");
        Console.WriteLine($"AVERAGE SCORE: {average}");
    }
}
