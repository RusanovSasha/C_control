//Задача 64: Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

//N = 5 -> "4, 2"
//N = 8 -> "8, 6, 4, 2,"

Console.Clear();
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

PrintChisla(n);

// функция вывода чётных чисел

void PrintChisla(int n)
{
    if (n > 0)
    {
        if (n % 2 == 0)
        {
            Console.Write(n);
            if (n > 2)
            {
                Console.Write(", ");
            }
        }
        n--;
        PrintChisla(n);
    }
}