// Напишите программу. которая выводит массив из 8 элементов, заполненный нулями 
// и единицами в случайном порядке.

void Massiv(int[] arr1)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        arr1[i] = new Random().Next(0,2);
    }
   }

void Print(int[] arr2)
{
    for (int pos = 0; pos < arr2.Length; pos++)
    {
         Console.Write($"{arr2[pos]} ");
    }
   }

int[] array = new int[8];
Massiv(array);
Print(array);
Console.WriteLine();

/* int[] array = new int [8];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random ().Next(0,2);
}
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
} */
