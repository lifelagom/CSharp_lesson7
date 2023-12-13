// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void ShowRealNumbers(int currentNumber, int number)
{   
    if (currentNumber < number)
    {
        Console.Write(currentNumber + ", ");
        ShowRealNumbers(currentNumber + 1, number);
    }
    if (currentNumber == number)
    {
        Console.Write(currentNumber);
    }
}

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m<n) {
    Console.Write($"M = {m}; N = {n} -> ");
    ShowRealNumbers(m, n);
} else { Console.WriteLine("Число M должно быть меньше числа N"); }