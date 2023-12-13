// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

// Ввод данных
int ReadInt(string text) {
    Console.Write(text);
    return int.Parse(Console.ReadLine()!);
}
// Вывод всех натуральных чисел от M до N
void ShowRealNumbers(int currentNumber, int number)
{   
    if (currentNumber < number) {
        Console.Write(currentNumber + ", ");
        ShowRealNumbers(currentNumber + 1, number);
    }
    if (currentNumber == number) {
        Console.Write(currentNumber);
    }
}
// основной код
int m = ReadInt("Введите число M: ");
int n = ReadInt("Введите число N: ");
if (m < n) {
    Console.Write($"M = {m}; N = {n} -> ");
    ShowRealNumbers(m, n);
} else {Console.WriteLine("Число M должно быть меньше числа N");}