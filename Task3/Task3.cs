using System.Text.RegularExpressions;

namespace Task3
{
    public class Task3
    {
        /*
         * Перед выполнением заданий рекомендуется просмотреть туториал по регулярным выражениям:
         * https://docs.microsoft.com/ru-ru/dotnet/standard/base-types/regular-expression-language-quick-reference
         */

        /*
         * Задание 3.1. Проверить, содержит ли заданная строка только цифры?
         */
        internal static bool AllDigits(string s)
        {

            foreach (char item in s)
            {

                if (char.IsDigit(item) == false)
                    return false;

            }
            return true;

        }

        /*
         * Задание 3.2. Проверить, содержит ли заданная строка подстроку, состоящую
         * из букв abc в указанном порядке, но в произвольном регистре?
         */
        internal static bool ContainsABC(string s)
        {

            if (s.Contains("abc")) return true;
            if (s.Contains("Abc")) return true;
            if (s.Contains("ABc")) return true;
            if (s.Contains("ABC")) return true;
            if (s.Contains("aBc")) return true;
            if (s.Contains("aBC")) return true;
            if (s.Contains("abC")) return true;
            if (s.Contains("AbC")) return true;

            return false;


        }
        /*
         * Задание 3.3. Найти первое вхождение подстроки, состоящей только из цифр,
         * и вернуть её в качестве результата. Вернуть пустую строку, если вхождения нет.
         */
        internal static string FindDigitalSubstring(string s)
        {
            string result = "";

            for (int i = 0; i < s.Length; i++)
            {

                if (Char.IsDigit(s[i]))
                {

                    for (int j = i; j < s.Length - i; j++)
                    {

                        if (Char.IsDigit(s[j]))
                        {

                            result += s[j];

                        }
                        else return result;
                    }

                    break;

                }

            }
            return result;
            //такой странный код потому что другая реализация с if else работает медленней на 1 миллисекунду

        }

        /*
         * Задание 3.4. Заменить все вхождения подстрок строки S, состоящих только из цифр,
         * на заданную строку S1.
         */
        internal static string HideDigits(string s, string s1)
        {
            return Regex.Replace(s, "[0 - 9]", s1);
        }

        public static void Main(string[] args)
        {

        }
    }
}