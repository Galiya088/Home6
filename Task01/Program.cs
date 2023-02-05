// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int NumPlus(int[] array)
{
    int count = 0;
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] > 0) count++;
    }
 return count;
}

int[] GetArray(int len)
{
    int[] array = new int[len];
    for (int index = 0; index < len; index++)
    {
        Console.Write($"Введите число: ");
        array[index] = int.Parse(Console.ReadLine());
    }
    return array;
}

int GetNum(string text)
{
    Console.WriteLine(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int num = GetNum("Количество цифр для ввода: ");
int[] array = GetArray(num);
int count = NumPlus(array);
Console.Write(String.Join(", ", array));

Console.WriteLine($" -> {count}");
