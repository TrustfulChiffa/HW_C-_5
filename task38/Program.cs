// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

float[] CreateArray(int len)
{
    float[] arr = new float[len];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-99, 100); //Можно не ограничивать, но тогда выдача некрасивая
    }
    return arr;
}

void PrintArray(float[] arr)
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
            Console.Write($" {arr[position]}");
            position++;
        }
        Console.Write("]");
    }
}

float DiffMaxMin (float[] arr)
{
    float min = arr[0];
    float max = 0;
foreach (var i in arr)
{
    if (min > i) min = i;
if (max < i) max = i;
}
float dif = max - min;
return dif;
}


Console.WriteLine("Введите количество чисел в массиве ");
int length = Convert.ToInt32(Console.ReadLine());

Console.Clear();

float[] array = CreateArray(length);

PrintArray(array);

float difference = DiffMaxMin(array);

Console.Write($" -> {difference}");
