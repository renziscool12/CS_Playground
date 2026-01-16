using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        Console.Write("How many favorite numbers do you have? ");
        int many = int.Parse(Console.ReadLine());
        
        List<int> num = new List<int>();
        
        for(int i = 0; i < many; i++)
        {
            Console.Write("Enter number #" + (i+1) +": ");
            int nums = int.Parse(Console.ReadLine());
            num.Add(nums);
        }
        
        Console.WriteLine("Your numbers: ");
        for(int i = 0; i < num.Count; i++)
        {
            Console.WriteLine(num[i]  + ", ");
        }
        int sum = 0;
        int highest = num[0];
        int lowest = num[0];
        
        for(int i = 0; i < num.Count; i++) 
        {
            sum += num[i];
        }
        for(int i = 1; i < num.Count; i++)
        {
             if(num[i] > highest)
            {
                highest = num[i];
            }
            if(num[i] < lowest)
            {
                lowest = num[i];
            }
        }
        
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Highest: " + highest);
        Console.WriteLine("Lowest " + lowest);
    }
}
