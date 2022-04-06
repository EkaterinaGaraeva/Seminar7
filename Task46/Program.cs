/*
Задача 46: Задайте двумерный массив размером m×n, 
заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8
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



