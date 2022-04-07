/*
Задача 49: Задайте двумерный массив. 
Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты.
Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
Новый массив будет выглядеть
вот так:
1 4 7 2
5 81 2 9
8 4 2 4
*/

int[,] Generate2DArray(int higth, int weigth, int delta)
{
    int[,] _return = new int[higth, weigth];
    for (int i = 0; i < higth; i++)
    {
        for (int j = 0; j < weigth; j++)
        {
            _return[i, j] = new Random().Next(delta * -1, delta);
        }
    }
    return _return;
}

void Print2DArray(int[,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write($"{arrayToPrint[i,j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] FindEvenElements(int[,] arrayToFind)
{
    for (int i = 0; i < arrayToFind.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToFind.GetLength(1); j++)
        {
            if (i != 0 && j != 0 && (i - 1) % 2 == 0 && (j - 1) % 2 == 0)
            {
                arrayToFind[i,j] = arrayToFind[i,j] * arrayToFind[i,j];
            }
        }
    }
    return arrayToFind;
}

int[,] newArray = Generate2DArray(3, 4, 9);
Print2DArray(newArray);
Console.WriteLine();
int[,] modifiedArray = FindEvenElements(newArray);
Print2DArray(modifiedArray);
