using System;

namespace T2Palindrome_Mubasshera
{
    class Program
    {
        static bool isPalindrome(string inputString, string trashSymbolString)
        {
            int start, end;
            start = 0;
            end = inputString.Length - 1;

            while (start<end)
            {
                if(trashSymbolString.Contains(inputString[start]))
                {
                    start++;
                    continue;
                }

                if (trashSymbolString.Contains(inputString[end]))
                {
                    end--;
                    continue;
                }

                if (inputString[start]!=inputString[end])
                {
                    return false;
                }
                start++;
                end--;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to check for palindrome: ");
            string input = Console.ReadLine();

            Console.WriteLine("Enter a string containing the trash symbols: ");
            string trashSymbols = Console.ReadLine();

            if (isPalindrome(input, trashSymbols))
            {
                Console.WriteLine("It is a palindrome");
            }
            else
            {
                Console.WriteLine("Not palindrome");
            }

        }
    }
}
