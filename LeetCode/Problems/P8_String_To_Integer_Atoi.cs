
using System.Text;

namespace Leetcode.Problems
{
    public class P8_String_To_Integer_Atoi
    {

        public static int MyAtoi(string s)
        {

            double value = 0;
            int index = 0;
            for (; index < s.Length && IsToIgnore(s[index]); index++) ;
            if (index == s.Length)
                return 0;

            int isPosiveNumber = 1;

            if (IsPositiveCharacter(s[index]) || IsNegativeCharacter((s[index])))
            {
                isPosiveNumber = IsPositiveCharacter(s[index]) ? 1 : -1;
                index++;
            }
         
            for (int i = index; i < s.Length; i++)
            {
                var character = s[i];

                if (IsDigit(character))
                {
                   value = value * 10 + (character - 48);


                }            
                else
                {
                    break;
                }

            }
         
            value = value > int.MaxValue && isPosiveNumber == 1 ? int.MaxValue : value;
            value = value * isPosiveNumber < int.MinValue && isPosiveNumber == -1 ? int.MinValue : value;
            return (int)value * isPosiveNumber;
        }

        public static bool IsDigit(char c)
        {

            switch ((int)c)
            {
                case 48:
                case 49:
                case 50:
                case 51:
                case 52:
                case 53:
                case 54:
                case 55:
                case 56:
                case 57:
                    return true;
                default: return false;
            };

        }
        public static bool IsDigit2(char c)
        {

            return (int)c switch
            {
                48 or 49 or 50 or 51 or 52 or 53 or 54 or 55 or 56 or 57 => true,
                _ => false,
            };

        }
        public static bool IsToIgnore(char c)
        {
            return c == ' ';

        }

        public static bool IsNegativeCharacter(char c)
        {

            return c == '-';
        }

        public static bool IsPositiveCharacter(char c)
        {
            return c == '+';
        }
    }
}
