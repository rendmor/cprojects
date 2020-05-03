//Студент Ales Gokhberg-Shidlovsky. Домашнее задание 1.3.a.
// 3.	а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(value: "Введите координату x первой точки A:");
        double x1 = Convert.ToDouble(value: Console.ReadLine().Replace(oldChar: '.', newChar: ','));

        Console.WriteLine(value: "Введите координату y первой точки A:");
        double y1 = Convert.ToDouble(value: Console.ReadLine().Replace(oldChar: '.', newChar: ','));

        Console.WriteLine(value: "Введите координату x второй точки B:");
        double x2 = Convert.ToDouble(value: Console.ReadLine().Replace(oldChar: '.', newChar: ','));

        Console.WriteLine(value: "Введите координату y второй точки B:");
        double y2 = Convert.ToDouble(value: Console.ReadLine().Replace(oldChar: '.', newChar: ','));

        double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        Console.WriteLine(value: $"Расстояние между двумя точками A и B: {r:F2}.");
        Console.ReadKey(); /**вывод с использованием знака $*/
    }
}