// Задача из итоговой контрольной работы

string[] numbers1 = new string[7] {"Geek", "Brains", "Product", "Manager", ":-)", "Super", "Class"};
string[] numbers2 = new string[numbers1.Length];
void Processing(string[] numbers1, string[] numbers2)
{
    int count = 0;
    for (int i = 0; i < numbers1.Length; i++)
    {
    if(numbers1[i].Length <= 3)
        {
        numbers2[count] = numbers1[i];
        count++;
        }
    }
}
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
Processing(numbers1, numbers2);
PrintArray(numbers2);

