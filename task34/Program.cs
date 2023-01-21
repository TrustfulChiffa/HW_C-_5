// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


void PrintArray(int[] arr)
{
    Console.Write($"[{arr[0]}");
    if (arr.Length == 1)
    {
        Console.Write("]");
    }
    else
    {
        int position = 1;
        while (position < arr.Length)
        {
            Console.Write($", {arr[position]}");
            position++;
        }
        Console.Write("]");
    }
}

int[] CreateArray(int len)
{
    int[] arr = new int[len];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}

int EvenNumber(int[] arr)
{
    int count = 0;
    foreach (int i in arr)
    {
        if (i % 2 == 0) count++;
    }
    return count;
}

Console.WriteLine("Введите количество чисел в массиве ");
int length = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(length);

PrintArray(array);

int count = EvenNumber(array);

Console.Write($" -> {count}");