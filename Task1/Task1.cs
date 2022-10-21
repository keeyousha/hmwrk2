namespace Task1
{
    public class Task1
    {
        /*
         * Задание 1.1. Дана строка. Верните строку, содержащую текст "Длина: NN",
         * где NN — длина заданной строки. Например, если задана строка "hello",
         * то результатом должна быть строка "Длина: 5".
         */
        internal static int StringLength(string s)
        {
            return s.Length;
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
            expr.Insert(0, " ");
            string temp;
            int result = 0;

            for (int i = 0; i < Enumerable.Count(expr) / 2; i += 2)
            {

                temp = expr.Substring(i, 2);

                if (temp.Substring(0, 1).Equals(' ') || temp.Substring(0, 1).Equals('+')) // я пытался и оно не хочет работать
                    result += (int)(Char.Parse(temp.Substring(1, 1)));

                Console.WriteLine(result);

                if (temp.Substring(0, 1).Equals('-'))
                    result -= (int)(Char.Parse(temp.Substring(1, 1)));

                Console.WriteLine(result);

            }

            return result;
        }

        /*
         * Задание 1.6. Даны строки S, S1 и S2. Заменить в строке S первое вхождение строки S1 на строку S2. (s1 - del, s2 - paste)
         */
        internal static string ReplaceWithString(string s, string s1, string s2)
        {
            for (int i = 0; i < s.Length - s1.Length; i++)
            {

                if (s.Substring(i, s1.Length).Equals(s1))
                {
                    s.Replace(s.Substring(i, s1.Length), s2); //тоже чёт не очень понятно
                    return s;
                }
                    

            }
            return s;
        }


        public static void Main(string[] args)
        {
            Console.WriteLine(CalcDigits("4+2+4+2-1"));
        }
    }
}