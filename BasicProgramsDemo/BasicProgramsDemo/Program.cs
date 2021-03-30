using System;

namespace BasicProgramsDemo
{
    /// <summary>
    /// Reading input from thr user and replacing user name with template
    /// </summary>
    class ReplaceString
    {
        public static void Readinput()
        {
            string template = "Hello <<username>>, How are you";
            Console.WriteLine("Please enter your name: ");
            string userInput = Console.ReadLine();
            ReplaceWord(template, userInput);

        }

        private static void ReplaceWord(string template, string userInput)
        {
            string result = template.Replace("<<UserName>>", userInput);
            Console.WriteLine("After done replace\t" + result);
        }

    }
}
