using System.Text;

namespace Task2
{
    public class Task2
    {

        /*
         * В этих заданиях * рекомендуется всюду использовать класс StringBuilder.
         * Документация: https://docs.microsoft.com/ru-ru/dotnet/api/system.text.stringbuilder?view=net-6.0
         */

        /*
         * Задание 2.1. Дана непустая строка S и целое число N (> 0). Вернуть строку, содержащую символы
         * строки S, между которыми вставлено по N символов «*» (звездочка).
         */
        internal static string FillWithAsterisks(string ss, int n)
        {
            StringBuilder s = new StringBuilder(ss);

            StringBuilder dots = new StringBuilder().Append('*', n); //!

            for (int i = 0; i < ss.Length; i++)
            {

                s.Insert(i, dots);

            }
            return s.ToString();
        }

        /*
         * Задание 2.2. Сформировать таблицу квадратов чисел от 1 до заданного числа N.
         * Например, для N=4 должна получиться следующая строка:

        1  1
        2  4
        3  9
        4 16

         * Обратите внимание на выравнивание: числа в первом столбце выравниваются по левому краю,
         * а числа во втором -- по правому, причём между числами должен оставаться как минимум один
         * пробел. В решении можно использовать функции Pad*.
         */
        internal static string TabulateSquares(int n)
        {
            string npow, pow, result = "";

            for (int i = 1; i < n + 1; i++)
            {

                npow = i.ToString();
                pow = Math.Pow(i, 2).ToString();

                result = npow.PadLeft(1, ' ') + pow.PadRight(1, ' ');

            }
            return result;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(FillWithAsterisks("abc", 2));
            Console.WriteLine(TabulateSquares(4));
        }
    }
}