// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


string[] workArray = FillArray();
string[] resultArray = GenerateNewArray(workArray);
string originalArray = PrintArray(workArray);
string sortedArray = PrintArray(resultArray);

Console.WriteLine("Ваш массив " + originalArray + " отсортирован: " + sortedArray);





// Methods:

string[] FillArray()
{
    Console.WriteLine("Введите желаемые элементы массива через пробел, затем нажмите Enter: ");

    string? enterSymbols = Console.ReadLine();

    if (enterSymbols == null) 
    { 
        enterSymbols = ""; 
    };

    char[] separators = new char[] { ',', ' ' };
    string[] workArray = enterSymbols.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    return workArray;
}

string PrintArray(string[] array)
{
    string stringArray = "[";
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            stringArray += $"\"{array[i]}\"";
            break;
        }
        stringArray += ($"\"{array[i]}\", ");
    }
    stringArray += "]";
    return stringArray;
}

int CountStringSymbols(string[] array)
{
    int counter = 0;
    foreach (string item in array)
    {
        if (item.Length <= 3)
        {
            counter++;
        }
    }
    return counter;
}

string[] GenerateNewArray(string[] array)
{
    int resultArrayLength = CountStringSymbols(workArray);
    string[] resultArray = new string[resultArrayLength];
    int i = 0;
    foreach (string item in array)
    {
        if (item.Length <= 3)
        {
            resultArray[i] = item;
            i++;
        }
    }
    return resultArray;
}