// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// Создаем массив
double[] CreateArray(int n)
{
    double[] array = new double[n];
    return array;
}

// Заполняем массив
void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().Next(-9, 10) + new Random().NextDouble(), 3);
    }
}

// Печать массива
string PrintArray(double[] array)
{
    string value = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        value = value + $"{array[i]} ";
    }
    return value;
}

// Поиск максимального элемента массива
double FindMaxElement(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}


// Поиск минимального элемента массива
double FindMinElement(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

int Num = 10;
double[] Array = CreateArray(Num);
FillArray(Array);
Console.WriteLine(PrintArray(Array));
Console.WriteLine();
Console.WriteLine($"Максимальный элемент массива = {FindMaxElement(Array)}");
Console.WriteLine($"Минимальный элемент массива = {FindMinElement(Array)}");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {FindMaxElement(Array)-FindMinElement(Array)}");