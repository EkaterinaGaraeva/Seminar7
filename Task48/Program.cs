/*
Задача 48: Задайте двумерный массив размера m на n, 
каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/

int[,] Generate2DArray(int higth, int weigth, int delta)
{
    int[,] _return = new int[higth, weigth];
    for (int i = 0; i < higth; i++)
    {
        for (int j = 0; j < weigth; j++)
        {
            _return[i, j] = i + j;
        }
    }
    return _return;
}

void PrintArray2DArray(int[,] arrayToPrint)
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

Console.WriteLine("Введите m: ");
int higth = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n: ");
int weigth = Convert.ToInt32(Console.ReadLine());

int[,] generatedArray = Generate2DArray(higth, weigth, 200);

PrintArray2DArray(generatedArray);
