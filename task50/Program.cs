﻿/*Напишите программу, которая на вход принимает позиции элемента в 
двумерном массиве, и возвращает значение этого элемента или же 
указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого числа в массиве нет */


int m = 3;
int n = 4;
int[,] array = new int[m, n];
Random rnd = new Random();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = rnd.Next(0, 100);
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write($"{array[i, j]}  ");
    Console.WriteLine();
}

Console.WriteLine("Введите индекс строки a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца b: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > n || b > m)
    Console.WriteLine("такого числа нет");
else
{
    object c = array.GetValue(a, b);
    Console.WriteLine(c);
}

