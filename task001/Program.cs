// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10

/* int func(int d)
{
    
    d = d * d;
    Console.WriteLine("Вызов функции!");
    return d;
}
int m = 5;
int n = func(m);
Console.WriteLine("Результат функции: " + n); */

/* string func(int d, string s, double c)
{
    Console.WriteLine("Вызов функции!");
    return "Результат " + d + s + c;
}
int m = 5;
string n = func(15 , " строка ", 56.01);
Console.WriteLine("Результат функции: " + n); */

/* Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine());

if (A < 0)
{
    Console.WriteLine("Нужно ввести положительное число");
    return; //в этом сл. программа столкнувшись с отрицат.числом завершит работу
}
else 
{
    int sum = 0;
    for (int i = 0; i <= A; i++)
    {
        sum += i;
    }
    Console.WriteLine(sum);
} */

int func(int size)
{
    int sum = 0;
    for (int i = 0; i <= size; i++)
    {
        sum += i;
    }
    return sum;
}

Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Результат " + A + ": " + func(A));
/* Console.WriteLine("Результат 4: " + func(4));
Console.WriteLine("Результат 8: " + func(8)); */