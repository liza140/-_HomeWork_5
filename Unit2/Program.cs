// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

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
        array[i] = new Random().Next(-9, 10);
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

// Определение суммы элементов, стоящих на нечетных позициях.
// В данном случае считается, что нулевой элемент массива находится на первой позиции и так далее.
int SumOddPositionElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

int Num = 11;
int[] Array = CreateArray(Num);
FillArray(Array);
Console.WriteLine(PrintArray(Array));
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях массива = {SumOddPositionElements(Array)}");