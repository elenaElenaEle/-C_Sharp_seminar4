// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел 
// от 1 до N (факториал).
// 4 -> 24
// 5 -> 120
int func(int A)
{
    int prod = 1;
    for (int i = 1; i <= A; i++)
    {
        prod *= i;
    }
    return prod;
}

Console.WriteLine ("Введите число: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Произведение чисел от 1 до " + N + " равно " + func(N));