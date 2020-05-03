//Студент Ales Gokhberg-Shidlovsky. Домашнее задание 1.4.b.
// 4.	Написать программу обмена значениями двух переменных:
//а) без использования третьей переменной;

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(value: "Введите первое число a:");  // вводим значение a
        int a = Convert.ToInt32(value: Console.ReadLine()); 

        Console.WriteLine(value: "Введите второе число b:"); // вводим значение b
        int b = Convert.ToInt32(value: Console.ReadLine());

        b=a+b;        // В b запоминаем сумму a и b
        a=b-a;           // В a записываем разницу нового b и a (или старое b = старым a+b-a)
        b=b-a;           // В b записываем нового b и нового a (или старое a = старым a+b-((a+b)-a) = a+b-a-b+a)

        Console.WriteLine(value: $"Замена произведена! Теперь a = {a}, а b = {b}!"); // вывод с использованием знака $
        Console.ReadKey();
    }
}