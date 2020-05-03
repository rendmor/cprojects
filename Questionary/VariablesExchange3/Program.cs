//Студент Ales Gokhberg-Shidlovsky. Домашнее задание 1.4.a.
// 4.	Написать программу обмена значениями двух переменных:
//а) с использованием третьей переменной;

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(value: "Введите первое число a:");  // вводим значение a
        int a = Convert.ToInt32(value: Console.ReadLine()); 

        Console.WriteLine(value: "Введите второе число b:"); // вводим значение b
        int b = Convert.ToInt32(value: Console.ReadLine());

        int t = a;        // В t запоминаем значение a
        a = b;           // В a записываем b
        b = t;           // В b записываем сохраненное a

        Console.WriteLine(value: $"Замена произведена! Теперь a = {a}, а b = {b}!"); // вывод с использованием знака $
        Console.ReadKey(); 
    }
}