using System;
using System.Collections;
using System.Collections.Generic;

namespace PalinLibrary
{
    public class PalenLib
    {

        public bool palendromeCheck(String palendrome)
        {
            palendrome = palendrome.ToLower();
            char[] str = palendrome.ToCharArray();

            ArrayList charArr = new ArrayList();

            foreach(char c in str)
            {
                if (c != ' ' && c != ',' && c!='.')
                {
                    charArr.Add(c);
                }
            }

            for (int i = 0; i < charArr.Count; i++) {
                if (!charArr[i].Equals(charArr[charArr.Count-1-i]))
                {
                    return false;
                }
            }

            return true;
        }

    }
}
