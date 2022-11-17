//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

// делаем возможным введение M = 15; N = 1 и нахождения при этом нужной нам суммы

if (m > n)
{
    int i = m;
    m = n;
    n = i;
}

Console.WriteLine($"Сумма натуальных элементов в промежутке между M и N равна {Summa(m, n, 0)}");

// функция нахождения суммы

int Summa(int m, int n, int sum)
{
    if (m <= n) { sum = sum + m; m++; sum = Summa(m, n, sum); }
    return sum;
}