string[] CreateInitialArray(string[] array, int size, int min, int max)
{
    string[] initialArray = new string[size];

    for (int i = 0; i < size; i++)              // "i++" means the same as "i += 1" or "i = i + 1"
    {
        initialArray[i] = array[new Random().Next(min, max)];
    }

    return initialArray;
}

string[] NewArray(string[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)      // "i++" means the same as "i += 1" or "i = i + 1"
    {
        if (array[i].Length <= 3)
            count++;
    }

    if (count > 0)
    {
        string[] newArray = new string[count];
        int lessthree = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                newArray[lessthree] = array[i];
                lessthree++;
            }
        }
        return newArray;
    }
    else
        return new string[0];
}

void PrintArrayVar1(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)          // "i++" means the same as "i += 1" or "i = i + 1"
        Console.Write(array[i] + " ");
    Console.WriteLine("]");
}

string PrintArrayVar2(string[] array)
{
    string result = string.Empty;

    result += "[ ";
    for (int i = 0; i < array.Length; i++)
        result += $"{array[i]} ";
    result += "]";

    return result;
}

string[] startStrings = {"IT", "is", "the", "future!", "AI", "BI", "Cyber", "Security", "Drones", "Space", 
"Bot", "Block", "Chain", "Dot", "Net", "Run", "Sky", "Data", "Science", "Hi!"};

Console.WriteLine("Select the length of the initial array: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] initialArr = CreateInitialArray(startStrings, size, 0, startStrings.Length);
PrintArrayVar1(initialArr);
string[] newArr = NewArray(initialArr);
PrintArrayVar1(newArr);
Console.WriteLine(PrintArrayVar2(newArr));