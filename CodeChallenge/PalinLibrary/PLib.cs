using System;

namespace PalinLibrary
{
    public class PalenLib
    {

        public bool palendromeCheck(String palendrome)
        {
            char[] str = palendrome.ToCharArray();

            for (int i = 0; i < str.Length; i++) {
                if (str[i] != str[str.Length-1-i])
                {
                    Console.WriteLine("Not a palendrome");
                    return false;
                }
            }

            return true;
        }

    }
}
