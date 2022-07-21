// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void massiv(int []arr1)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        arr1[i] = new Random().Next(0, 1000);
    }
}

void Print(int [] arr2)
{
    for (int pos = 0; pos < arr2.Length; pos++)
    {
        Console.Write($"{arr2[pos]} ");
    }
}

int [] array = new int[8];
massiv(array);
Print(array);
Console.WriteLine();
