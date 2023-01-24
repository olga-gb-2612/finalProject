int CountNewElement(string[] array)
{
    int count = 0;
    foreach (string element in array)
    {
        if (element.Length < 4)
            count++;
    }
    return count;
}

void NewArray(string[] array, string[] array1)
{
    int index = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length < 4)
        {
            array1[index] = array[i];
            index++;
        }
}

Console.WriteLine("Введите массив строк через пробел:");
string[] mas1 = Console.ReadLine().Split(" ");
Console.WriteLine("Исходный массив:");
Console.WriteLine($"[{string.Join(", ", mas1)}]");
string[] mas2 = new string[CountNewElement(mas1)];
Console.WriteLine("Массив из строк, длина которых меньше либо равна 3 символам:");
NewArray(mas1, mas2);
Console.WriteLine($"[{string.Join(", ", mas2)}]");
