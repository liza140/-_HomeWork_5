// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


// Создаем массив
int[] CreateArray(int n)
{
    int[] array = new int[n];
    return array;
}

// Заполняем массив
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

// Печать массива
string PrintArray(int[] array)
{
    string value = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        value = value + $"{array[i]} ";
    }
    return value;
}

// Определение количества четных элементов
int CountEvenNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

int Num =10;
int[] Array = CreateArray(Num);
FillArray(Array);
Console.WriteLine(PrintArray(Array));
Console.WriteLine();
Console.WriteLine($"Количество четных элементов массива = {CountEvenNumber(Array)}");


