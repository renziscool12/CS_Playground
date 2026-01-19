using System;
namespace PracticeSet6;

class Program
{
    static void Main(string[] args)
    {
        //call method to main
        double[] temp = GetTemp();
        DisplayTemps(temp);
    }

    //prints the input using for loop and tryparse
    //while loop so you can always repeat
    //stores temps into the array
    static double[] GetTemp()
    {
        int temps;
        while (true)
        {
            Console.Write("How many person to check temperature? ");
            if (int.TryParse(Console.ReadLine(), out temps) && temps > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid Input, Please try againm");
            }
        }
        Console.WriteLine();
        double[] checkTemps = new double[temps];
        for (int i = 0; i < checkTemps.Length; i++)
        {
            double tempsPerson;
            while (true)
            {
                Console.Write($"Person {i+1} Temperature: ");
                if (double.TryParse(Console.ReadLine(), out tempsPerson) && tempsPerson > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input, Please try again.");
                }
            }

            checkTemps[i] = tempsPerson;
        }

        return checkTemps;
    }
    //2nd method get highest using logic
    //Double.MinValue helps me to get the highest temp
    static double GetHighest(double[] temps)
    {
        double high = Double.MinValue;
        foreach (double a in temps)
        {
            if (a > high)
            {
                high = a;
            }
        }

        return high;
    }
    //3rd method gets the lowest still using pure logic
    //Double.MaxValue helps me get the lowest temp
    
    static double GetLowest(double[] temps)
    {
        double low = Double.MaxValue;
        foreach (double b in temps)
        {
            if (b < low)
            {
                low = b;
            }
        }

        return low;
    }

    //4th method which us get temps
    //which helps me classify the temperature of a person
    static string GetTemps(double temps)
    {
        return (temps >= 39.1) ? "Very High Fever!" :
            (temps >= 38.1) ? "High Fever!" :
            (temps >= 37.3) ? "Moderate Fever." :
            (temps >= 36.1) ? "Normal Fever." : "Below Normal.";
    }

    //5th method which display temps in output
    //prints the people temps and its summary
    static void DisplayTemps(double[] temps)
    {
        Console.WriteLine();
        Console.WriteLine("---PEOPLE'S TEMPERATURE---");
        for (int i = 0; i < temps.Length; i++)
        {
            string getTemps = GetTemps(temps[i]);
            Console.WriteLine($"Person {i+1} Temperature: {temps[i]:F2} -> {getTemps}");
        }

        double high = GetHighest(temps);
        double low = GetLowest(temps);
        Console.WriteLine();
        Console.WriteLine("\n---SUMMARY---");
        Console.WriteLine($"HIGHEST TEMPERATURE -> {high}");
        Console.WriteLine($"LOWEST TEMPERATURE -> {low}");
        
    }
}
