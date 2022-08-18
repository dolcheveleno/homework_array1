/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.WriteLine("Введите количество строк:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[n, m];
double[] summ = new double[m];
for (int i = 0; i < n; i++) 
{
    for (int j = 0; j < m; j++) 
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
for (int i = 0; i < m; i++) 
{
    for (int j = 0; j < n; j++) 
    {
        summ[i] = summ[i] + array[j, i]; 
    }
}
Console.Write($"Среднее арифметическое элементов в каждом столбце: ");
for (int i = 0; i < m; i++)
{
    Console.Write($" {Math.Round(summ[i] / n,1)}; ");
}
Console.WriteLine();