using System;

namespace Ex04.Menus.Test
{
    public class MenuActions
    {
        private const string k_VersionStr = "Version: 18.2.4.0";

        public static void ShowTime()
        {
            Console.WriteLine($"The time now is: {DateTime.Now:t}");
        }

        public static void ShowDate()
        {
            Console.WriteLine($"The date today is: {DateTime.Now:d}");;
        }

        public static void ShowCapital()
        {
            string strInput;
            int capitalCnt;
            Console.WriteLine("Please write a sentence:");
            strInput = Console.ReadLine();
            capitalCnt = countUpperCase(strInput);

            Console.WriteLine($"Number of upper case letters: {capitalCnt}");
        }

        public static void ShowVersion()
        {
            Console.WriteLine(k_VersionStr);
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
    }
}