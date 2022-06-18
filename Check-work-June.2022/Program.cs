string[] CreateInitialArray(string[] array, int size)
{
    string[] initialArray = new string[size];

    for (int i = 0; i < size; i++)              // "i++" means the same as "i += 1" or "i = i + 1"
    {
        initialArray[i] = array[new Random().Next(0, initialArray.Length + 1)];
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

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)          // "i++" means the same as "i += 1" or "i = i + 1"
        Console.Write(array[i] + ", ");
    Console.WriteLine("]");
}

string[] startStrings = {"IT", "is", "the", "future!", "AI", "BI", "Cyber", "Security", "Drones", "Space", 
"Bot", "Block", "Chain", "Dot", "Net", "Run", "Sky", "Data", "Science", "Hi!"};

Console.WriteLine("Select the length of the initial array in range from 1 to 20: ");
int size = Convert.ToInt32(Console.ReadLine());

PrintArray(CreateInitialArray(startStrings, size));
Console.WriteLine();
PrintArray(NewArray(CreateInitialArray(startStrings, size)));