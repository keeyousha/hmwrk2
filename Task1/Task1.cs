namespace Task1
{
    public class Task1
    {
        /*
         * Задание 1.1. Дана строка. Верните строку, содержащую текст "Длина: NN",
         * где NN — длина заданной строки. Например, если задана строка "hello",
         * то результатом должна быть строка "Длина: 5".
         */
        internal static string StringLength(string s)
        {
            return $"Длина: {Convert.ToString(s.Length)}";
        }

        /*
         * Задание 1.2. Дана непустая строка. Вернуть коды ее первого и последнего символов.
         * Рекомендуется найти специальные функции для вычисления соответствующих символов и их кодов.
         */
        internal static Tuple<int?, int?> FirstLastCodes(string s)
        {
            return new Tuple<int?, int?>(Code(First(s)), Code(Last(s)));
        }

        private static char? Last(string s)
        {
            return char.Parse(s.Substring(s.Length - 1));
        }

        private static char? First(string s)
        {
            return char.Parse(s.Substring(0, 1));
        }

        private static int? Code(char? c)
        {
            return (int)c;
        }


        /*
         * Задание 1.3. Дана строка. Подсчитать количество содержащихся в ней цифр.
         * В решении необходимо воспользоваться циклом for.
         */
        internal static int CountDigits(string s)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {

                switch (s.Substring(i, 1))
                {

                    case "0":
                        count++;
                        break;
                    case "1":
                        count++;
                        break;
                    case "2":
                        count++;
                        break;
                    case "3":
                        count++;
                        break;
                    case "4":
                        count++;
                        break;
                    case "5":
                        count++;
                        break;
                    case "6":
                        count++;
                        break;
                    case "7":
                        count++;
                        break;
                    case "8":
                        count++;
                        break;
                    case "9":
                        count++;
                        break;

                }
            }

            return count;
        }

        /*
         * Задание 1.4. Дана строка. Подсчитать количество содержащихся в ней цифр.
         * В решении необходимо воспользоваться методом Count:
         * https://docs.microsoft.com/ru-ru/dotnet/api/system.linq.enumerable.count?view=net-6.0#system-linq-enumerable-count-1(system-collections-generic-ienumerable((-0))-system-func((-0-system-boolean)))
         * и функцией Char.IsDigit:
         * https://docs.microsoft.com/ru-ru/dotnet/api/system.char.isdigit?view=net-6.0
         */
        internal static int CountDigits2(string s)
        {
            int count = 0;

            for (int i = 0; i < Enumerable.Count(s); i++)
            {

                if (Char.IsDigit(Char.Parse(s.Substring(i, 1))))
                    count++;

            }

            return count;
        }

        /*
         * Задание 1.5. Дана строка, изображающая арифметическое выражение вида «<цифра>±<цифра>±…±<цифра>»,
         * где на месте знака операции «±» находится символ «+» или «−» (например, «4+7−2−8»). Вывести значение
         * данного выражения (целое число).
         */
        internal static int CalcDigits(string expr)
        {
            char[] exprarr = expr.ToArray();

            int result = 0;

            bool nop = false; // if true => '-', if false => '+'

            for (int i = 0; i < expr.Length; i++)
            {

                if (exprarr[i] == '+' || exprarr[i] == '-')

                    if (exprarr[i] == '-')
                        nop = true;

                    else if (exprarr[i] == '+')
                        nop = false;

                if (char.IsDigit(exprarr[i]))
                {
                    if (nop == true) result -= exprarr[i];
                    if (nop == false) result += exprarr[i];
                }

            }

            return result;

        }

        /*
         * Задание 1.6. Даны строки S, S1 и S2. Заменить в строке S первое вхождение строки S1 на строку S2. (s1 - del, s2 - paste)
         */
        internal static string ReplaceWithString(string s, string s1, string s2)
        {
            int index1 = s.IndexOf(s1);
            s = s.Remove(index1, s1.Length).Insert(index1, s2);
            return s;
        }


        public static void Main(string[] args)
        {
            Console.WriteLine(CalcDigits("4+2+4+2-1"));
        }
    }
}