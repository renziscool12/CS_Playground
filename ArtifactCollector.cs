using System;
namespace PracticeSet2;

class Program
{
    static void Main(string[] args)
    {
        //we call collectartifacts and displayresult on this main method
        //so it can print the output
        int[] collect = CollectArtifacts();
        DiplayResults(collect);

        //so we made our first method collect artifacts
        //with an array so we make an array and named it
        //adventurer, and we store team on the index so
        //it doesn't go error like if you store 5 in input
        //it stay 5 only doesn't go up
        //then we use for loop to know how many we are printing
        //then we declare the adventurer and return it
        static int[] CollectArtifacts()
        {
            Console.Write("How many adventures are in the team? ");
            int team = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int[] adventurer = new int[team];
            for (int i = 0; i < adventurer.Length; i++)
            {
                Console.Write($"Adventurer {i + 1}: ");
                adventurer[i] = Convert.ToInt32(Console.ReadLine());
            }

            return adventurer;
        }

        //so we made our 2nd method which is determinerank
        //we used condition on this one so we can know
        //what class or what they're called
        static string DetermineRank(int count)
        {
            if (count >= 15)
            {
                return "Legendary Collector";
            }
            else if (count >= 10)
            {
                return "Skilled Collector";
            }
            else
            {
                return "Novice Collector";
            }
        }

        //so here we have our last method which is displayresult
        //we put this on method and put our first variable name which is collect
        //then we store it inside displayresult
        static void DiplayResults(int[] counts)
        {
            Console.WriteLine("\n---ADVENTURE ARTIFACTS COLLECTED---");
            for (int i = 0; i < counts.Length; i++)
            {
                string adventure = DetermineRank(counts[i]);
                string text = $"Adventure {i + 1}: {counts[i]} Artifacts - {adventure}";
                Console.WriteLine(text);
            }
        }
    }
}
