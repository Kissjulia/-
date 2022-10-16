// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

string[] arr = new string[5] {"I", "love", "study", "in", "GB"};
string[] arr1 = new string[arr.Length];
void ArrayWith2(string[] arr, string[] arr1)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
    if(arr[i].Length <= 3)
        {
        arr1[count] = arr[i];
        count++;
        }
    }
}
void PrintArr(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
ArrayWith2(arr, arr1);
PrintArr(arr1);