/*
Задача 51: Задайте двумерный массив. 
Найдите сумму элементов, находящихся на главной диагонали 
(с индексами (0,0); (1;1) и т.д:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
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

int FindSumOfElements(int[,] arrayToFind)
{
    int sumOfElements = 0;
    Console.Write("Сумма элементов главной диагонали: ");
    for (int i = 0; i < arrayToFind.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToFind.GetLength(1); j++)
        {
            if (i == j)
            {
                sumOfElements += arrayToFind[i,j];
                Console.Write(arrayToFind[i,j]);
                if (i < arrayToFind.GetLength(0) - 1 && j < arrayToFind.GetLength(1) - 1)
                {
                    Console.Write(" + ");
                }
            }
        }
    }
    return sumOfElements;
}

int[,] newArray = Generate2DArray(3, 4, 10);
Print2DArray(newArray);
Console.WriteLine();
int sum = FindSumOfElements(newArray);
Console.Write($" = {sum}");