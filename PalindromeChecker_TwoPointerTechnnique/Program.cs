

class PalindromeChecker_TwoPointerTechnique
{
    public static bool IsPalindrome(string input)
    {
        string cleanedInput = new string(input.Where(char.IsLetterOrDigit).Select(char.ToLower).ToArray());

        int left = 0;
        int right = cleanedInput.Length - 1;

        while (left < right)
        {
            if (cleanedInput[left] != cleanedInput[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a string to check if it is palindrome");
        string userInput = Console.ReadLine();
        if (userInput == null)
        {
            Console.WriteLine("No input provided.");
            return;
        }
        if (IsPalindrome(userInput))
        {
            Console.WriteLine($"The input string \"{userInput}\" is a palindrome");
        }
        else
        {
            Console.WriteLine($"The input string \"{userInput}\" is not a palindrome");
        }
    }
}
