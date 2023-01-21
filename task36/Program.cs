// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int[] CreateArray(int len)
{
    int[] arr = new int[len];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-99, 100); //Можно не ограничивать, но тогда выдача некрасивая
    }
    return arr;
}

int SumOfOddElements(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}

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


Console.WriteLine("Введите количество чисел в массиве ");
int length = Convert.ToInt32(Console.ReadLine());

Console.Clear();

int[] array = CreateArray(length);

int result = SumOfOddElements(array);

PrintArray(array);

Console.Write($" -> {result}");