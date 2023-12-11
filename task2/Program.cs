//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int akkerman(int mNumber, int nNumber)
{
    if (mNumber == 0) 
    {
        return nNumber + 1;
    }
    else if (nNumber == 0) 
    {
        return akkerman(mNumber - 1, 1);
    }
    else 
    {
    return akkerman(mNumber - 1, akkerman(mNumber, nNumber - 1));
    }
}

Console.Clear();
Console.Write("Введите первое неотрицательное целое число: ");
int firstNumber = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе неотрицательное целое число: ");
int secondNumber = int.Parse(Console.ReadLine()!);
while (firstNumber > 3 || secondNumber > 3) //у меня дальше не тянет уже...
{
    Console.WriteLine("Лучше выбрать числа поменьше");
    Console.Write("Введите первое неотрицательное целое число: ");
    firstNumber = int.Parse(Console.ReadLine()!);
    Console.Write("Введите второе неотрицательное целое число: ");
    secondNumber = int.Parse(Console.ReadLine()!);

}
Console.WriteLine($"Значение функции Аккермана для чисел {firstNumber} и {secondNumber} равно {akkerman(firstNumber, secondNumber)}");