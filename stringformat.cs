/*Create a Simple Text Formatter
Objective
Create a program to practice basic string manipulation techniques in C#.
Task
1. Write a program that performs the following steps:
• Prompt the user to input a string.
• Convert the input string to uppercase.
• Reverse the string.
• Replace all spaces in the string with underscores (_).
• Display both the original and manipulated strings.
2. Requirements
• The program should clearly display instructions to the user.
• The manipulated strings should be displayed one by one with labels (e.g., "Uppercase:", "Reversed:", "Spaces replaced:").
Example Output
Enter a string: Hello World Original String: Hello World Uppercase: HELLO WORLD Reversed: dlroW olleH Spaces Replaced: Hello_World
Deliverables
Submit the completed program in the form of a .cs file. Make sure your code is:
• Well-commented to explain the logic.
• Properly formatted for readability.
Additional Instructions
• Test your program thoroughly before submission to ensure it handles various input scenarios (e.g., empty input, strings with special characters).
• Be creative! Feel free to add extra features (e.g., count the number of characters or words in the string) if you'd like to go beyond the basic task.*/
using System;
namespace program{
    class stringmanipulation{
          public static void Main(){
           // Prompt the user to input a string
        Console.WriteLine("Please enter a string:");
        string input = Console.ReadLine();

        // Convert the input string to uppercase
        string uppercased = input.ToUpper();

        // Reverse the string
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);

        // Replace all spaces in the string with underscores
        string spacesReplaced = input.Replace(" ", "_");

        // Display the original and manipulated strings
        Console.WriteLine("\nOriginal String:");
        Console.WriteLine(input);

        Console.WriteLine("\nManipulated Strings:");
        Console.WriteLine("Uppercase:");
        Console.WriteLine(uppercased);

        Console.WriteLine("Reversed:");
        Console.WriteLine(reversed);

        Console.WriteLine("Spaces replaced:");
        Console.WriteLine(spacesReplaced);

          }
    }
}