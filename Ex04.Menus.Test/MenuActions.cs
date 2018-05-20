using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class MenuActions
    {
        private const string k_VersionStr = "Version: 18.2.4.0";

        internal class ShowTimeClass : IActionForLeafItem
        {
            public void ActionMethod()
            {
                ShowTime();
            }          
        }

        internal class ShowDateClass : IActionForLeafItem
        {
            public void ActionMethod()
            {
                ShowDate();
            }
        }

        internal class ShowCapitalClass : IActionForLeafItem
        {
            public void ActionMethod()
            {
                ShowCapital();
            }           
        }

        internal class ShowVersionClass : IActionForLeafItem
        {
            public void ActionMethod()
            {
                ShowVersion();
            }           
        }

        private static int countUpperCase(string i_InputStr)
        {
            int cnt = 0;
            foreach(char charInStr in i_InputStr)
            {
                if(char.IsUpper(charInStr))
                {
                    cnt++;
                }
            }

            return cnt;     
        }

        internal static void ShowTime()
        {
            Console.WriteLine($"The time now is: {DateTime.Now:t}");
        }

        internal static void ShowDate()
        {
            Console.WriteLine($"The date today is: {DateTime.Now:d}");
        }

        internal static void ShowCapital()
        {
            string strInput;
            int capitalCnt;
            Console.WriteLine("Please write a sentence:");
            strInput = Console.ReadLine();
            capitalCnt = countUpperCase(strInput);
            Console.WriteLine($"Number of upper case letters: {capitalCnt}");
        }

        internal static void ShowVersion()
        {
            Console.WriteLine(k_VersionStr);
        }
    }
}