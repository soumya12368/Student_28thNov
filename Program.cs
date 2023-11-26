using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            // Specify the path to the text file
            string filePath = "C:\\Users\\soums\\OneDrive\\Desktop\\Simplilear\\Student2.txt";

            // Read all lines from the text file
            string[] lines = File.ReadAllLines(filePath);

            // Display header
            Console.WriteLine("Rainbow School Student Data:");

            // Display each line (student information)
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

        // Wait for user input before closing the console window
        Console.ReadLine();
    }
}
