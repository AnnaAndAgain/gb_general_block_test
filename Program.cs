/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/


void PrintArray(string[] tmpArray)
{
    for (int i = 0; i < tmpArray.GetLength(0); i++)
    {
        Console.Write(tmpArray[i] + "\t");
    }
}

string[] ReadStringArray(string text)
{
    Console.WriteLine(text);
    string[] result = Console.ReadLine()!.Split(", ");
    return result;
}

string[] ShortOnly(string[] tmpArray, int desLength)
{
    int count = 0;
    foreach (string tmpStr in tmpArray){if (tmpStr.Length <= desLength){count++;}}
    string[] result = new string[count];

    count = 0;
    foreach (string tmpStr in tmpArray)
    {
        if (tmpStr.Length <= desLength)
        {
            result[count] = tmpStr;
            count++;    
        }
    }
    return result;
}

void Main()
{
    string[] arrInput = ReadStringArray("Введите слова через запятую:");
    // PrintArray(arrInput);
    // Console.WriteLine();

    string[] arrResult = ShortOnly(arrInput, 3);
    PrintArray(arrResult);
    Console.WriteLine();
}

Main();

