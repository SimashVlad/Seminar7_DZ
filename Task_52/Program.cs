Console.Write("Введите значение m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите значение n: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"При значениях m = {m}, n = {n}. массив будет следующий");
Console.WriteLine();

Double[,] array = new Double[m, n];

void rndArray(Double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(10);
        }
    }
}

void PrintArray(Double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

rndArray(array);
// PrintArray(array);
Console.WriteLine();

Double[,] arrayWhole = new Double[m, n];
arrayWhole = TransformationArrayWhole(array);

WriteArrayInt(arrayWhole);

Console.Write($"Cреднее арифметическое:\n");
for (int i = 0; i < n; i++)
{
  Double arithmeticMean = 0;
  for (int j = 0; j < m; j++)
  {
    arithmeticMean += arrayWhole[j, i];
  }
  arithmeticMean = arithmeticMean / m;
  Console.WriteLine($"столбца № {i+1}    {arithmeticMean}");
}

Double[,] TransformationArrayWhole (Double[,] array)
{
  Double[,] arrayWhole = new Double[array.GetLength(0), array.GetLength(1)];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      arrayWhole[i, j] = Convert.ToDouble(array[i, j]);
    }
  }
  return arrayWhole;
}

void WriteArrayInt (Double[,] arrayWhole){
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        Console.Write(arrayWhole[i, j] + " ");
      }
      Console.WriteLine();
  }
}