
// Reverse and Compare Approach
// Two Pointers Approach
// Using Built-in Methods

using System;

class PalindromeChecker
{
    public static bool IsPalindrome(string input)
    {
        string cleanedInput = new string(input.Where(char.IsLetterOrDigit).Select(char.ToLower).ToArray());

        char[] charArray = cleanedInput.ToCharArray();
        Array.Reverse(charArray);

        string reversedInput = new string(charArray);

        return cleanedInput == reversedInput;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string to check if it is palindrome");
        string userInput = Console.ReadLine();

        if (userInput == null)
        {
            Console.WriteLine("No input provided.");
            return;
        }

        if (PalindromeChecker.IsPalindrome(userInput))
        {
            Console.WriteLine($"The input string \"{userInput}\" is a palindrome");
        }
        else
        {
            Console.WriteLine($"The input string \"{userInput}\" is not a palindrome");
        }
    }
}

