namespace PracticeSet5;

class Program
{
    //this is the main method
    //this is where we call every method
    //in this main
    static void Main(string[] args)
    {
        double[] score = GetScores();
        DisplayScores(score);
    }
    
    //this is my first method
    //name GetScores
    //this is my input
    //gets student grade from user input
    //returns array of scores
    //also for loop when i ask how many times to print it
    //i use while loop because we dont know when it ends
    //also i added true on the while parameter so we can 
    //repeat we we got it wrong also i use tryparse
    //so it won't get error when it becomes an actual app
    //it's a good practice for me
    static double[] GetScores()
    {
        int students;
        while (true)
        {
            
            Console.Write("How many students? ");
            if (int.TryParse(Console.ReadLine(), out students) && students >= 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }
        double[] scores = new double[students];
        for (int i = 0; i < scores.Length; i++)
        {
            double score;
            while (true)
            {
                Console.Write($"Student Grade {i + 1}: ");
                if (double.TryParse(Console.ReadLine(), out score) && score >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
            scores[i] = score;
        }
        return scores;
    }

    //here we have our second method
    //which is get average we get average
    //using logic
    static double GetAverage(double[] scores)
    {
        double average = 0;
        foreach (double a in scores)
        {
            average += a;
        }

        return average / scores.Length;
    }
    
    //this is our third method
    //which again get highest
    //same as the second method but gets average
    //here we use logic once again
    static double GetHighest(double[] scores)
    {
        double high = Double.MinValue;
        foreach (double b in scores)
        {
            if (b > high)
            {
                high = b;
            }
        }

        return high;
    }
    //our 4th method is get lowest
    //which it gets the lowest grade
    //we use logic once more
    static double GetLowest(double[] scores)
    {
        double low = Double.MaxValue;
        foreach (double c in scores)
        {
            if (c < low)
            {
                low = c;
            }
        }

        return low;
    }
    //the 5th method is get grade where
    //we get every grades like A, B OR C etc.
    static string GetGrade(double score)
    {
        return (score >= 90) ? "A" : (score >= 80) ? "B" : (score >= 70) ? "C" : (score >= 60) ? "D" : "F";
    }
    //lastly or the 6th method is display scores
    //so here we call this on the main method so
    //it can show everything in terminal
    //also this is where i declare average, highest,
    // and lowest 
    static void DisplayScores(double[] scores)
    {
        Console.WriteLine("\n---------------------");
        Console.WriteLine("STUDENT GRADE REPORT");
        Console.WriteLine("---------------------");
        for (int i = 0; i < scores.Length; i++)
        {
            string grade = GetGrade(scores[i]);
            Console.WriteLine($"Student Grade {i+1}: {scores[i]:F2} \t-> {grade}");
        }

        double ave = GetAverage(scores);
        double high = GetHighest(scores);
        double lowest = GetLowest(scores);
        Console.WriteLine("\n--------------------");
        Console.WriteLine("       SUMMARY");
        Console.WriteLine("---------------------");
        Console.WriteLine($"HIGHEST GRADE : {high:F2}");
        Console.WriteLine($"LOWEST GRADE  : {lowest:F2}");
        Console.WriteLine($"AVERAGE GRADE : {ave:F2}");
    }
    
}
