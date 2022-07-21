// Написать цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.**************************************
// 3, 5 -> 243 (3^5)
// 2, 4 -> 16 (2^4)
int init (string str)
{
    Console.Write("Введите число " + str+": ");
    return int.Parse(Console.ReadLine());
}

int pow1 (int num, int count)
{
    int proizv = 1;
    for (int i = 1; i <= count; i++)
    {
        proizv = proizv * num;
    }
    return proizv;
}

int A = init ("A");
int B = init ("B");
Console.WriteLine(A + " в степени " + B + " равно " + pow1(A, B));

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.*******************************************************
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int sum(int num)
{
    int A = num % 10;
    int B = num / 10;
    int sum1 = A + 0;
    while ( B > 0)
    {
        sum1 = sum1 + B % 10;
        B = B / 10;
    }
      return sum1;
}
Console.Write("Введите число: ");
int N = Math.Abs(int.Parse(Console.ReadLine()));
Console.Write("Сумма цифр в числе " + N + ": " + sum(N));

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.***********************************************************

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
