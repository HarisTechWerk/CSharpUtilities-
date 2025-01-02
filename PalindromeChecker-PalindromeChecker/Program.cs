
public class PalindromeCheckerNumbers
{
    public static bool IsPalindrome(int number)
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
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to check if it is palindrome");
        //int userInput = Convert.ToInt32(Console.ReadLine());
        //if (PalindromeCheckerNumbers.IsPalindrome(userInput))
        //{
        //    Console.WriteLine($"The input number \"{userInput}\" is a palindrome");
        //}
        //else
        //{
        //    Console.WriteLine($"The input number \"{userInput}\" is not a palindrome");
        //}

        string userInput = Console.ReadLine();      

        if (int.TryParse(userInput, out int number))
        {
            if (PalindromeCheckerNumbers.IsPalindrome(number))
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
}
// if (int.TryParse(userInput, out number))
// this line of code is used to convert the string input to an integer.
// If the conversion is successful,
// the number variable will contain the converted value and the method will return true.
// Otherwise, it will return false.
// This is a common pattern used to handle input validation and conversion in C#.