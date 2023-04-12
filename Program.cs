// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[] array = new int[10];
// FillArray(array);
// PrintArray(array);
// int count = EvenNumbers(array);
// Console.WriteLine(count);

// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     for (int i = 0; i < length; i++)
//     {
//         collection[i] = new Random().Next(100, 1000);
//     }
// }

// void PrintArray(int[] array)
// {
//     Console.Write("{");
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write($"{array[i]}, ");
//     }
//     Console.WriteLine(array[^1] + "}");
// }
// int EvenNumbers(int [] array)
// {
//     int counter = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] % 2 == 0)
//         {
//              counter ++;
//         }
       
//     }
//     return counter;
// }


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] array = new int[10];
// FillArray(array);
// PrintArray(array);
// int count = SumOddNumbers(array);
// Console.WriteLine(count);

// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     for (int i = 0; i < length; i++)
//     {
//         collection[i] = new Random().Next(1, 10);
//     }
// }

// void PrintArray(int[] array)
// {
//     Console.Write("{");
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write($"{array[i]}, ");
//     }
//     Console.WriteLine(array[^1] + "}");
// }
// int SumOddNumbers(int [] array)
// {
//     int counter = 0;
//     for (int i = 0; i < array.Length; i = i + 2)
//     {
//         counter = array[i] + counter;
//     }
//     return counter;
// }


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между
//  максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] array = new double[10];
FillArray(array);
PrintArray(array);
double count = Difference(array);
Console.WriteLine(count);

void FillArray(double[] collection)
{
    int length = collection.Length;
    for (int i = 0; i < length; i++)
    {
        collection[i] = new Random().Next(1, 10) + new Random().NextDouble();
    }
}

void PrintArray(double[] array)
{
    Console.Write("{");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine(array[^1] + "}");
}
double Difference(double [] array)
{
    double count = 0;
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
        if(array[i] < min) min = array[i];
    }
    count = max - min;
    return count;
}