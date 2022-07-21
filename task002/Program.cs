// Напишите программу, которая принимает на вход число и выдаёт кол-во цифр в числе.

/* Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());

int i = 0;
while (N != 0)
{
    i++;
    N /= 10;
}
Console.WriteLine("Количество цифр в числе  " + i); */
int dig(int A)
{
    int result = 0;
    while (A != 0)
    {
        result++;
        A /= 10;
    }
    return result;
}

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Количество цифр в числе  " + dig(N));