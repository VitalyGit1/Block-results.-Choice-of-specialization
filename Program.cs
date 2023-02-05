// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] array1 = new string[6] {"345", "11", "hi", "qwerty", "black", "jn"}; // Initial array data.
string[] array2 = new string[array1.Length]; // Create a second array to be output.
SecondArray(array1, array2);
PrintArray(array2);

void SecondArray(string[] array1, string[] array2) // The method checks the first array and writes elements equal to or less than 3 characters into the second array.
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

void PrintArray(string[] array) // The method prints an array to the console.
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
