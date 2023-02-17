/*Написать программу, которая из имеющегося массива строк
формирует массив из строк, длина которых меньше или равна 3 символа*/

int getUserData(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

string[] Array(int length)
{   string[] result = new string[length];
    for(int i = 0; i < length; i++)
    {
        Console.Write("Введите строку №{0} и нажмите Enter:\r\n", i + 1);
        result[i] = Console.ReadLine();
    }
    return result;
}

void printArray(string[] Array)
{
    Console.Write("[");
    for(int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i]);
        if(i < Array.Length - 1)
        {
            Console.Write(", ");
        }
        else
        {
            Console.WriteLine("]");
        }
    }
}

int length = getUserData("Введите длину массива: ");
string[] array = Array(length);
Console.WriteLine("Введенный массив: ");
printArray(array);
string[] FinalArray = new string[array.Length];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i].Length <= 3)
    {
        FinalArray[count] = array[i];
        count++;
    }
}
Console.WriteLine("Массив из 3 и менее символов равен: ");
printArray(FinalArray);


