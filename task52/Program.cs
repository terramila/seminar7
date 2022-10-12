/* Задайте двумерный массив из целых чисел. Найдите среднее 
арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */




int[,] array = new int[3, 3];
Random rnd = new Random();
for (int i = 0; i < 3; i++)
{
    int averageArray = 0;

    for (int j = 0; j < 3; j++)
    {
        array[i, j] = rnd.Next(0, 100);
        averageArray += array[i, j];
        /*averageArray = averageArray + array[j,i];*/
        Console.WriteLine($"{array[i, j]}  ");
    }

    Console.WriteLine($"Cред. арифмет. элем. столбца {i + 1} = {(float)averageArray / 3}");

}

