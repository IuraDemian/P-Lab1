
using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //Задача 1

        //Дано структуру даних.
        //Додати зазначену кількість елементів, які описують відповідну предметну область.
        //Вивести всі елементи на консоль в прямому та зворотному порядку.
        //Вивести кількість елементів у колекції.Очистити колекцію

        // 5 | ArrayList | Назви хімічних елементів | 9

        Console.WriteLine("Задача 1\n");
        List<string> elements = new List<string>();

        elements.Add("1 - Гiдроген");
        elements.Add("2 - Гелiй");
        elements.Add("3 - Лiтiй");
        elements.Add("4 - Берилiй");
        elements.Add("5 - Бор");
        elements.Add("6 - Карбон");
        elements.Add("7 - Нiтроген");
        elements.Add("8 - Оксиген");
        elements.Add("9 - Флуор");

        Console.WriteLine("Елементи у прямому порядку:");
        foreach (var element in elements)
        {
            Console.WriteLine(element);
        }

        Console.WriteLine("\nЕлементи у зворотному порядку:");
        var reverseElements = new List<string>(elements);
        reverseElements.Reverse();

        foreach (var element in reverseElements)
        {
            Console.WriteLine(element);
        }

        Console.WriteLine($"\nКiлькiсть елементiв у колекцiї: {elements.Count}");

        elements.Clear();

        Console.WriteLine("Колекцiя очищена.");
        Console.WriteLine($"Кiлькiсть елементiв пiсля очищення: {elements.Count} \n \n");


        //Задача 2
        //Дано список цілих чисел, який складається з n елементів.
        //Визначити суму додатних елементів списку, що стоять на позиціях, кратних трьом.
        Console.WriteLine("Задача 2\n");

        List<int> numbers = new List<int>{1, -5, 2, 3, -3, 7, 11, 4, 7, -2, 15};

        int sum = 0;

        for (int n = 0; n < numbers.Count; n++)
        {
            if (n % 3 == 0 && numbers[n] > 0)
            {
                sum += numbers[n];
            }
        }

        Console.WriteLine($"Сума додатних елементів на позиціях, кратних трьом: {sum}");
    }
}