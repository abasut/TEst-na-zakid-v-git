using System;

class Program
{
    static void Main()
    {
        Console.Write("Сколько чисел Фибоначчи вывести? ");

        // Читаем ввод пользователя
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Ошибка: введите положительное целое число.");
            return;
        }

        Console.WriteLine($"\nПервые {n} чисел Фибоначчи:");

        long a = 0; // F(0)
        long b = 1; // F(1)

        for (int i = 0; i < n; i++)
        {
            Console.Write(a);

            if (i < n - 1)
                Console.Write(", ");

            // Вычисляем следующее число
            long next = a + b;
            a = b;
            b = next;
        }

        Console.WriteLine();
    }
}