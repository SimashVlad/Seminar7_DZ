// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


Console.Write("Введите значение m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите значение n: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"При значениях m = {m}, n = {n}. массив будет следующий");
Console.WriteLine();

double[,] array = new double[m, n];

void rndArrayDouble(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().NextDouble() * 20 - 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double alignNumber = Math.Round(array[i, j], 1);
            Console.Write(alignNumber + " ");
        }
        Console.WriteLine();
    }
}

rndArrayDouble(array);
PrintArray(array);