using System;

namespace FoxmindedTasks
{
    class Program
    {
        static void Main(string[] args)
        {          
            Console.WriteLine("Hi! Let me revers words in your awesom string!\n" +
                              "Keep in mind that non-letter chars keep their index!\n" +
                              "E.g.: \"a1c qwe1r\"=>\"c1a rew1q\"");
            while (true)
            {
                string testString = Console.ReadLine();
                Console.WriteLine("Your string with reversed words looks like this:");
                string reverseString = ReverseLettersInWords(testString);
                Console.WriteLine(reverseString);
            }
        }
        public static string ReverseLettersInWords(string inputString) 
        {
            if (String.IsNullOrEmpty(inputString))
            {
                return "Warning! You enter empty or null string";
            }
            else
            {
                string[] wordsArray = inputString.Split(' ');
                for (int i = 0; i < wordsArray.Length; i++)
                {
                    char[] wordsToCharArray = wordsArray[i].ToCharArray();
                    int rightPoint = wordsToCharArray.Length - 1;
                    int leftPoint = 0;
                    while (leftPoint < rightPoint)
                    {
                        if (!char.IsLetter(wordsToCharArray[leftPoint]))
                        {
                            leftPoint++;
                        }
                        else if (!char.IsLetter(wordsToCharArray[rightPoint]))
                        {
                            rightPoint--;
                        }
                        else
                        {
                            char temp = wordsToCharArray[leftPoint];
                            wordsToCharArray[leftPoint] = wordsToCharArray[rightPoint];
                            wordsToCharArray[rightPoint] = temp;
                            leftPoint++;
                            rightPoint--;
                        }
                    }
                    wordsArray[i] = new string(wordsToCharArray);
                }
                return string.Join(" ", wordsArray);

            }

        }
    }
}
