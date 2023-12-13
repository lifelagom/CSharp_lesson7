// Задайте произвольный массив. Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

// Ввод данных
int ReadInt(string text) {
    Console.Write(text);
    return int.Parse(Console.ReadLine()!);
}
// Генерация массива
int[] GenerateArray(int size) {
    int[] array = new int[size];
    Random rand = new();
    for(int i = 0; i < array.Length; i++) {
        array[i] = rand.Next(0, 100);
    }
    return array;
}
// Вывод всех элементов массива с конца
void PrintArray(int[] array, int index) {
    if (index>=0) {
        Console.Write(array[index]+" ");
        PrintArray(array, index-1);
    }
}
// основной код
int size = ReadInt("Введите размер массива: ");
int[] array = GenerateArray(size);
Console.Write("["+string.Join(", ",array)+"] => ");
PrintArray(array, array.Length-1);