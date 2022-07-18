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
string[] OutputArray (string[] inputArray)
{
    int count = inputArray.Length;
    string[] outputArray = new string[count];
    int index = 0;
    for (int i=0; i<count; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            outputArray[index]= inputArray[i];
            index +=1;
        }
    }
    Array.Resize(ref outputArray, index);
    return outputArray;
}
string PrintArray (string [] array)
{
    string output = String.Empty;
    int length = array.Length;
    for (int i=0 ; i < length ; i++)
    {
        output += array[i] + " ";
    }
    return output;
}
int count = 4;
string[] inputArray = NewArray(count);
FillNewArray(inputArray);
Console.WriteLine ($"[{PrintArray(inputArray)}]");
string[] outputArray = OutputArray (inputArray);
Console.Write($" -> [{PrintArray(outputArray)}]");