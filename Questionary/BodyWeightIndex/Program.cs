//Студент Ales Gokhberg-Shidlovsky. Домашнее задание 1.2.
// Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(value: "Введите ваш рост, метры:");
        double height = Convert.ToDouble(value: Console.ReadLine().Replace(oldChar: '.', newChar: ','));

        Console.WriteLine(value: "Введите ваш вес, полных килограмм:");
        double weight = Convert.ToDouble(value: Console.ReadLine());

        double BWI = weight / (height * height);

        Console.WriteLine(value: $"Твой индекс массы тела (ИМТ) - {BWI:F2}.");
        Console.ReadKey(); /**вывод с использованием знака $*/

        Console.WriteLine(value: String.Format("Твой индекс массы тела (ИМТ) - {0:F2}.", BWI));
        Console.ReadKey(); /**вывод с использованием форматирования*/

        Console.WriteLine(value: "Твой индекс массы тела (ИМТ) - " + BWI + ".");
        Console.ReadKey(); /*вывод с использованием склеивания*/
    }
}