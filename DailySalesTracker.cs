using System;
namespace PracticeSet4;

class Program
{
    static void Main(string[] args)
    {
        //so here is our input for this  daily sales gtracker
        Console.WriteLine("\n-----------------------------------------");
        Console.WriteLine("        DAILY SALES TRACKER REPORT");
        Console.WriteLine("-----------------------------------------");
        
        //here we have while loop and for loop why?
        //because we use this so it won't error when it comes to app
        //for today im practicing tryparse which is useful for me in
        //the future what tryparse do is returns true or false
        //this is why we use if else when you put like "abc"
        //it throws you a warning then it terminates the program
        //this is why we use while because we don't know when it ends
        //then we put true inside it so it can repeat
        //int.parse crashes when invalid input and it cant handle null
        //only if input is valid but when you put wrong input it crashes
        //however you can do toint32 however it is very risky
        //this is why tryparse is the best it doesn't crashes when valid input
        //it can handle null which is good for apps/games
        int days;
        while (true)
        {
            Console.Write("Enter number of days to record: ");
            if (int.TryParse(Console.ReadLine(), out  days) && days > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("INVALID INPUT! RERUN AGAIN");
            }
        }
        
        //here we have to declare variables here
        //double min finds the lowest number
        //double max finds the highest
        double totalSales = 0;
        double highestSales = double.MinValue;
        double lowestSales = double.MaxValue;
        
        Console.WriteLine("\n-----------------------------------------");
        Console.WriteLine("         SALES PERFORMANCE LOG");
        Console.WriteLine("-----------------------------------------");
        
        for (int i = 0; i < days; i++)
        {
            double sale;
            while (true)
            {
                Console.Write($"\nEnter sale for Day {i+1}: ");
                if (double.TryParse(Console.ReadLine(), out  sale) && sale >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("INVALID INPUT! RERUN AGAIN");
                   
                }
            }
            //we have the condition here
            //we add our total sale and sale
            //also our logic
            totalSales += sale;
            if (sale > highestSales)
                highestSales = sale;
            if (sale < lowestSales)
                lowestSales = sale;

            string performance;
            if (sale >= 5000)
                performance = "High Performance";
            else if (sale >= 3000)
                performance = "Target Met";
            else if (sale >= 1000)
               performance = "Below Target";
            else
                performance = "Critical!";
            Console.WriteLine($"Day {i+1}: {sale:F2} -> {performance}");
        }
        //lastly we have to divde days and totalsales
        //and this is the output and we use string
        //interpolation to make it easy
        double averageSales = totalSales / days;
        
        Console.WriteLine("\n-----------------------------------------");
        Console.WriteLine("          FINANCIAL SUMMARY");
        Console.WriteLine("-----------------------------------------");
        
        Console.WriteLine($"Highest Sale: {highestSales:F2}");
        Console.WriteLine($"Lowest Sale: {lowestSales}");
        Console.WriteLine($"Average Sale: {averageSales}");
    }
} 
