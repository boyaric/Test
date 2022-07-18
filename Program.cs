string[] NewArray (int count)
{
    return new string[count];
}
void FillNewArray (string[] inputArray)
{
    int count = inputArray.Length;
    Console.WriteLine("Введите строки");
    for (int i=0; i<count; i++)
    {
        inputArray [i] = Console.ReadLine();
    }
}
