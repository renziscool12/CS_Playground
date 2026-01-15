using System;

public class ServerTest
{
    public static void Main(string[] args)
    {
        int[] test = numServer();
        savePing(test);
        
    static int [] numServer()
    {
        Console.Write("How many servers to test? ");
        int servers = int.Parse(Console.ReadLine());
        Console.WriteLine();
        
        int[] test = new int[servers];
        for(int i = 0; i < test.Length; i++) {
            Console.Write("Enter ping for Server " + (i+1) + ": ");
            test[i] = int.Parse(Console.ReadLine());
        }
        return test;
    }
    static string getPing(int ping)
    {
       return (ping > 150) ? "Laggy (UNSTABLE)" : (ping > 50) ? "Good (PLAYABLE)" : "Excellent (COMPETITIVE)";
    }
    static void savePing(int[] net)
    {
        Console.WriteLine("\n--- SERVER REPORT ---");
        for(int i = 0; i < net.Length; i++) {
            string ping = getPing(net[i]);
            string text = "Server " + (i+1) + ": " + ping + " - " + net[i] + "ms";
            Console.WriteLine(text);
        }
    }
    
    }
}
