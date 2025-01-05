using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter marks (0-100): ");
            string input = Console.ReadLine();
            int marks;

            // Validate input
            if (!int.TryParse(input, out marks) || marks < 0 || marks > 100)
            {
                Console.WriteLine("Error: Marks must be between 0 and 100. Please try again.");
                continue;
            }

         
            string grade;
            if (marks >= 90)
            {
                grade = "A";
            }
            else if (marks >= 80)
            {
                grade = "B";
            }
            else if (marks >= 70)
            {
                grade = "C";
            }
            else if (marks >= 60)
            {
                grade = "D";
            }
            else
            {
                grade = "Fail";
            }

           
            string remarks;
            switch (grade)
            {
                case "A":
                    remarks = "Excellent";
                    break;
                case "B":
                    remarks = "Very Good";
                    break;
                case "C":
                    remarks = "Good";
                    break;
                case "D":
                    remarks = "Needs Improvement";
                    break;
                case "Fail":
                    remarks = "Better Luck Next Time";
                    break;
                default:
                    remarks = "Invalid Grade";
                    break;
            }

            // Display results
            Console.WriteLine("Grade:"+ grade);
            Console.WriteLine("Remarks:" +remarks);

            // Ask if the user wants to enter marks for another student
            Console.Write("Do you want to enter marks for another student? (Yes/No): ");
            string another = Console.ReadLine().Trim().ToLower();
            if (another != "yes")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
        }
    }
}