// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
 //Использовать рекурсию, не использовать циклы.
Console.Clear();
string printNumbersIn(int mNumber, int nNumber)
{
    if(mNumber < nNumber)
    {
        if (mNumber == nNumber)
        {
            return $"{nNumber} ";
        }
        return printNumbersIn(mNumber, nNumber - 1) + $"{nNumber} "; 
    }
    else{

        if (mNumber == nNumber)
            {
                return $"{mNumber} ";
            }
        return printNumbersIn(mNumber - 1, nNumber) + $"{mNumber} "; 
    }
}

Console.WriteLine("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число(постарайтесь сделать так, чтобы второе число было больше): ");
int secondNumber = int.Parse(Console.ReadLine()!);
if(firstNumber > secondNumber)
{
    Console.WriteLine("Эх, ладно придётся дописать код");
}
Console.WriteLine($"числа лежащие между введёнными Вами числами {printNumbersIn(firstNumber, secondNumber)}");

