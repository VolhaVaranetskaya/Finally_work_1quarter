// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//  длина которых меньше, либо равна 3 символам. 
//  Первоначальный массив можно ввести с клавиатуры, 
//  либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//  лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.WriteLine("Введите длину массива: "); // запрашиваем длину массива
int size = Convert.ToInt32(Console.ReadLine());
string[] array = new string[size]; // создаем массив указанной длины
LineArray(array);  
PrintArray(array);
Console.WriteLine();
string[] newLineArray = NewLineArray(array);
PrintArray(newLineArray);

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]} ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

void LineArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{i + 1}. Введите значение массива");
        array[i] = Console.ReadLine();
    }
}

string[] NewLineArray(string[] array)
{
    string[] newArray = new string[size];
    for (int i = 0; i < array.Length; i++) // выполняем проверку введенных пользоателем слов на количество символов
    {
        if(array[i].Length <= 3)  // ели кол во символов меньше или равно 3, то символы записываем в новый массив
        {
            newArray[i] = array[i];
        }
    }
    return newArray; // возвращаем новый массив
}

