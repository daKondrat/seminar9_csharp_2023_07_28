// Задача 1: Задайте значение N. Напишите программу, которая выведет все ЧЕТНЫЕ натуральные числа в промежутке от 1 до N. Выполнить с помощью рекурсии.
// N = 5, M = 9 -> "6, 8"
// N = 2, M = 10 -> "2, 4, 6, 8, 10"

Console.Write("Введите значение N: ");

int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение M: ");

int m = Convert.ToInt32(Console.ReadLine());

void even(int n, int m)
{
    if (n > m)
        return;
    if (n % 2 == 0)
    {
        Console.Write($"{n} ");
    }
    even(n + 1, m);
}
even(n, m);