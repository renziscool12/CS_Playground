namespace PraciticeSet3;

class Program
{
    static void Main(string[] args)
    {
        //here we have for loop which it prints 3 times and also our main method
        //where our method has been called here
        for(int i = 0; i < 3; i++)
        {
            GetStudentInfo(out string name, out string course, out int yearLevel, out string studentId, out double gpa);
            string status = GetStudentStatus(gpa);
            DisplayIDCard(name, course, yearLevel, studentId, gpa, status);
        }

    }
    //this is where we get the student info and put the student's information
    //also we use out parameters cause we are returning multiple value
    static void GetStudentInfo(out string name, out string course, out int yearLevel, out string studentId,
        out double gpa)
    {
        Console.Write("Name: ");
         name = Console.ReadLine();
        
        Console.Write("Course:  ");
        course = Console.ReadLine();
        
        Console.Write("Year Level: ");
        yearLevel = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Student ID: ");
        studentId = Console.ReadLine();
        
        Console.Write("GPA: ");
        gpa = double.Parse(Console.ReadLine());
        
    }
    //here we get the students status so we use condition on this one
    //so we can know what he/she gets and call it on the main method
    static string GetStudentStatus(double gpa)
    {
        return (gpa >= 1.75) ? "Dean's Lister" : "Regular Student";
    }
    
    //lastly here we have our display ID card it just display our student information
    //and we call our parameter here so it this method know what they're printing
    //and we call our last meth0d on main
    //also we use string interpolation to make it easier to put
    static void DisplayIDCard(string name, string course, int yearLevel, string studentId, double gpa, string status)
    {
        Console.WriteLine("\n===== STUDENT ID CARD =====");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Course: {course}");
        Console.WriteLine($"Year Level: {yearLevel}");
        Console.WriteLine($"Student ID: {studentId}");
        Console.WriteLine($"GPA: {gpa:F2}");
        Console.WriteLine($"Status: {status}");
        Console.WriteLine("===========================");
    }
    
    
}
