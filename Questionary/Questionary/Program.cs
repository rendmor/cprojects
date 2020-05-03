//Студент Ales Gokhberg-Shidlovsky. Домашнее задание 1.1.
//Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку.
//а) /*используя склеивание;*/
//б) используя форматированный вывод;
//в) * используя вывод со знаком $.
using System;

    class Program
    {
    static void Main()
    {
        Console.WriteLine(value: "Введите ваше имя:");
        string name = Console.ReadLine();

        Console.WriteLine(value: "Введите вашу фамилию:");
        string surname = Console.ReadLine();

        Console.WriteLine(value: "Введите ваш возраст, полных лет:");
        int age = Convert.ToByte(value: Console.ReadLine());

        Console.WriteLine(value: "Введите ваш рост, метры:");
        double height = Convert.ToDouble(value: Console.ReadLine().Replace(oldChar: '.', newChar: ','));

        Console.WriteLine(value: "Введите ваш вес, полных килограмм:");
        int weight = Convert.ToUInt16(value: Console.ReadLine());

        Console.WriteLine(value:$"Привет, {name} {surname}! Твой возраст - {age}. Вес - {weight} килограмм, а рост - {height} метров.");
        Console.ReadKey(); /**вывод с использованием знака $*/

        Console.WriteLine(value:String.Format("Привет, {0} {1}! Твой возраст - {2}. Вес - {3} килограмм, а рост - {4} метров.", name, surname, age, weight, height));
        Console.ReadKey(); /**вывод с использованием форматирования*/

        Console.WriteLine(value: "Привет, " + name + " " + surname + "! Твой возраст - " + age + ". Вес - " + weight + " килограмм, а рост - " + height + " метров.");
        Console.ReadKey(); /*вывод с использованием склеивания*/
    }
    }