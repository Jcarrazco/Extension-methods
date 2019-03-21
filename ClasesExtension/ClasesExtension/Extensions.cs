using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClasesExtension
{
    static class Extensions
    {
        
        public static string DelCha  (this string s, char x)
        {
            List<Char> TmpStr = s.ToList();
            s = "";
            TmpStr.RemoveAll(c => c == x);

            foreach(char z in TmpStr)
            {
                s = s + z;
            }
            return s;
        }

        public static bool ValidateStringAlpha (this string str, bool acceptSpace = true)
        {
            char[] specialChars = {'"','@', '!', '#', '$', '%',
                '&', '/', '(', ')', '=', '?', '¨', '{', '}', '[',
                ']', '_', '-', '.', ',' };
            List<char> tempStr = str.ToList();
            bool estado;

            if (acceptSpace)
            {
                tempStr.RemoveAll(c => c == ' ');
            }

            estado = true;
            foreach (char x in tempStr)
            {
                foreach(char y in specialChars) { 
                if (x == y) estado = false;
                }
            }
            
            return estado;
        }

        public static bool ValidateStringNumeric(this string str, bool acceptSpace = true)
        {
            char[] NumChars = {'1','2', '3', '4', '5', '6',
                '7', '8', '9', '0'};
            List<char> tempStr = str.ToList();
            bool estado;

            if (acceptSpace)
            {
                tempStr.RemoveAll(c => c == ' ');
            }

            estado = false;
            foreach (char x in tempStr)
            {
                foreach (char y in NumChars)
                {
                    if (x == y) estado = true;
                }
            }

            return estado;
        }

        public static string ConvertCharListToString(this List<char> charList)
        {

            char[] chars = charList.ToArray();

            string charString = string.Empty;

            for (int i = 0; i < chars.Length - 1; i++)
            {
                charString += chars[i] + " ";
            }

            charString += chars[chars.Length - 1];

            return charString;
        }
    }
}
