// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
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

/* int SUM(string str)
{
    int sum3 = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (char.IsDigit(str[i]))
        {
            sum3 = sum3 + (int)char.GetNumericValue (str[i]);
        }
    }
        return sum3;
} */

Console.Write("Введите число: ");
int N = Math.Abs(int.Parse(Console.ReadLine()));
Console.Write("Сумма цифр в числе " + N + ": " + sum(N));
//string K = Console.ReadLine();
//Console.Write(SUM(K));