//Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
int [] FillArray (int size)
{
    int [] newArray = new int [size];
    for(int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = new Random().Next(0, 101);
    }
    return newArray;
}
void PrintArray (int [] madeUpArray)
{
    for (int i = 0; i < madeUpArray.Length; i++)
    {
        Console.Write(madeUpArray[i] + " ");
    }
    Console.WriteLine();
}

void PrintArrayReverse(int [] madeUpArray, int i = 0)
{
    if (i != madeUpArray.Length)
    {
        PrintArrayReverse(madeUpArray, i+1);
        Console.Write($"{madeUpArray[i]} ");
    }
}
Console.Clear();
Console.WriteLine("Введите размер массива, который будем переворачивать: ");
int sizeOfArray = int.Parse(Console.ReadLine()!);
int [] arrayWeHave = FillArray(sizeOfArray);
Console.WriteLine("Начальный массив: ");
PrintArray(arrayWeHave);
Console.WriteLine("Перевёрнутый массив: ");
PrintArrayReverse(arrayWeHave);