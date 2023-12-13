// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// ввод данных
int ReadInt(string text) {
    Console.Write(text);
    return int.Parse(Console.ReadLine()!);
}
// рассчет функции Аккермана
int Akkerman(int m, int n)
{   
    if (m == 0) {return n+1;}
    if (m > 0 && n == 0) {
        return Akkerman(m-1, 1);} else {
        return Akkerman(m-1, Akkerman(m,n-1));
    }
}
// основной код
int m = ReadInt("Введите число M: ");
int n = ReadInt("Введите число N: ");
while (m<0 | n<0) {
    Console.WriteLine("Числа M и N должны быть положительными");
    m = ReadInt("Введите число M: ");
    n = ReadInt("Введите число N: ");    
}
Console.Write($"m = {m}, n = {n} -> A(m,n) = {Akkerman(m, n)}");