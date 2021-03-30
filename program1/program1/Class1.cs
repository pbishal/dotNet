using System;
using System.Collections.Generic;
using System.Text;

namespace program1
{
    /// <summary>
    /// Reading input from thr user and replacing user name with template
    /// </summary>
    class ReplaceString
    {
        public void ReadInput()
        {
            string template = "Hello <<UserName>>, How are you";
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
