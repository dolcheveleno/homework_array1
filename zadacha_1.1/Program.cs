/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

void FillArray(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
}

void PrintArray(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j], 4}");
        }
        System.Console.WriteLine();
    }
}

System.Console.WriteLine("Введите номер строки элемента: ");
int X = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите номер столбца элемента: ");
int Y = Convert.ToInt32(Console.ReadLine());

void FindValue(int[,]array)
{
    if (X <= array.GetLength(0) && Y <= array.GetLength(1))
    System.Console.WriteLine($"Значением элемента в строке {X} столбце {Y} является {array[X-1, Y-1]}");
    else    
    System.Console.WriteLine("Такого элемента в массиве нет");
}

int[,] array = new int[3, 4];
FillArray(array);
PrintArray(array);
FindValue(array);