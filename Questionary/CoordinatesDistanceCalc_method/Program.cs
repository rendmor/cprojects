//Студент Ales Gokhberg-Shidlovsky. Домашнее задание 1.3.b.
// 3.	б) * Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2), оформив вычисления расстояния между точками в виде метода.

using System;

class Program
{
    static double r(double x1,double y1,double x2,double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }
    static void Main()
    {
        Console.Write("Введите координату x первой точки A: ");
        double x1 = double.Parse(Console.ReadLine().Replace(oldChar: '.', newChar: ','));

        Console.Write(value: "Введите координату y первой точки A: ");
        double y1 = double.Parse(Console.ReadLine().Replace(oldChar: '.', newChar: ','));

        Console.Write(value: "Введите координату x второй точки B: ");
        double x2 = double.Parse(Console.ReadLine().Replace(oldChar: '.', newChar: ','));

        Console.Write(value: "Введите координату y второй точки B: ");
        double y2 = double.Parse(Console.ReadLine().Replace(oldChar: '.', newChar: ','));
   
        Console.WriteLine(value: $"Расстояние между двумя точками A и B: {r(x1, y1, x2, y2):F2}.");
        Console.ReadLine(); /**вывод с использованием знака $*/
    }
}