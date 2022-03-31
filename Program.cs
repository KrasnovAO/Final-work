
string[] array = new string[] { "hello", "2", "world", ":-)" };

void DeletingElements(string[] arr)
{
    int n = 0;// для записи элементов массива соответствующих условию
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
         arr[n++] = arr[i];      
        }
    }
    Array.Resize(ref arr, n);
    PrintArray(arr);
}

void PrintArray(string[] matr)
{
    for (int i = 0; i < matr.Length; i++)
    {
        Console.Write($" {matr[i]}");
    }
    Console.WriteLine();
}

DeletingElements(array);
