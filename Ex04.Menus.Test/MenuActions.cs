using System;
namespace Ex04.Menus.Test
{
    public class MenuActions
    {

        private const string k_VersionStr = "Version: 18.2.4.0";

        public static void ShowTime()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString());
        }

        public static void ShowDate()
        {
            DateTime today = DateTime.Today;
            Console.WriteLine(today.ToString());
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