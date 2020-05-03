//Студент Ales Gokhberg-Shidlovsky. Домашнее задание 1.5.a.
//5.	а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
//б) * Сделать задание, только вывод организовать в центре экрана.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(value: "Введите ваше имя:");
        string name = Console.ReadLine();

        Console.WriteLine(value: "Введите вашу фамилию:");
        string surname = Console.ReadLine();

        Console.WriteLine(value: "Введите ваш город проживания:");
        string city = Console.ReadLine();

        {
            string[] str = { $"Твое имя: {name}", $"Фамилия: {surname}", $"Город: {city}" };
            int width = Console.WindowWidth, height = Console.WindowHeight;
            Print();

            while (true)
            {
                if (width != Console.WindowWidth || height != Console.WindowHeight)
                {
                    width = Console.WindowWidth;
                    height = Console.WindowHeight;
                    Print();
                }
            }

            void Print()
            {
                Console.Clear();
                int top = Console.WindowHeight / 2 - str.Length / 2;
                for (int i = 0; i < str.Length; i++, top++)
                {
                    Console.SetCursorPosition(Console.WindowWidth / 2 - str[i].Length / 2, top);
                    Console.Write(str[i]);
                }
            }
        }
    }
}