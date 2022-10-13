// Пользователь с клавиатуры вводит некоторый текст.
// Приложение должно изменять регистр первой буквы каждого предложения на букву в верхнем регистре.
// Например, если пользователь ввёл: "today is a good day for walking. i will try to walk near the sea."
// Результат работы приложения: "Today is a good day for walking. I will try to walk near the sea."

using System;

namespace Text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            string str = Console.ReadLine();
            //string str = "today is a good day for walking. i will try to walk near the sea.";
            str = str.ToLower();
            char[] s = str.ToCharArray();
            s[0] = char.ToUpper(s[0]);

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i-1] == '.' && s[i] == ' ') s[i+1] = char.ToUpper(s[i+1]);
            }
            Console.WriteLine();
            str = String.Concat<char>(s);
            Console.WriteLine(str);
            Console.ReadKey();

        }
    }
}
