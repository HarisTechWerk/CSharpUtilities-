using System.IO.IsolatedStorage;

Console.WriteLine("Palindrome Checker App");
Console.WriteLine("-----------------------");
Console.WriteLine("Choose an option:");
Console.WriteLine("1. Check a string");
Console.WriteLine("2. Check a number");
Console.WriteLine("Enter your choice (1 or 2):");

string choice = Console.ReadLine();
switch (choice)
{
    case "1":
        CheckStringPalindrome();
        break;
    case "2":
        CheckNumberPalindrome();
        break;
    default:
        Console.WriteLine("Invalid choice. Please enter 1 or 2.");
        break;
}

void CheckStringPalindrome()
{
    Console.WriteLine("\nEnter a string to check if it is palindrome");
    string input = Console.ReadLine() ?? string.Empty; 

    if (IsStringPalindrome(input))
    {
        Console.WriteLine($"\"{input}\" is a palindrome");
    }
    else
    {
        Console.WriteLine($"\"{input}\" is not a palindrome");
    }
}

void CheckNumberPalindrome()
{
    Console.WriteLine("\nEnter a number to check if it is palindrome");
    string userInput = Console.ReadLine() ?? string.Empty;
    int number;

    if (int.TryParse(userInput, out number))
    {
        if (IsNumberPalindrome(number))
        {
            Console.WriteLine($"The input number \"{number}\" is a palindrome");
        }
        else
        {
            Console.WriteLine($"The input number \"{number}\" is not a palindrome");
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
}

bool IsStringPalindrome(string input)
{
    string cleanedInput = CleanString(input);
    char[] charArray = cleanedInput.ToCharArray();
    Array.Reverse(charArray);
    string reversedInput = new string(charArray);
    return cleanedInput == reversedInput;
}

string CleanString(string input)
{
    return new string(input.Where(char.IsLetterOrDigit).Select(char.ToLower).ToArray());
}

bool IsNumberPalindrome(int number)
{
    if (number < 0)
    {
        return false;
    }
    int reversedNumber = 0;
    int originalNumber = number;
    while (number > 0)
    {
        int remainder = number % 10;
        reversedNumber = reversedNumber * 10 + remainder;
        number /= 10;
    }
    return originalNumber == reversedNumber;
}
