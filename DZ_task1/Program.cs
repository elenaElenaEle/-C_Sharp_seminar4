// Написать цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.
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