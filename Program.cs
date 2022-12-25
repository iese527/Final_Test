string[] InputArray(string[] array)
{
    bool checkThisOut = true;
    string[] arrayResult = new string[] {};
    
    while (checkThisOut)
    {
        Console.Clear();
        Console.Write("WIll you input ARRAY from keyboard or not? (y/n) ");
        char inputAnswer = Console.ReadKey().KeyChar;
        Console.WriteLine();
        if (inputAnswer.Equals('y') | inputAnswer.Equals('Y'))
        {
            Console.WriteLine("Input your array, divide words with spaces:");
            arrayResult = Console.ReadLine().Split(' ');
            checkThisOut = false;
        }
        else if (inputAnswer.Equals('n') | inputAnswer.Equals('N'))
        {
            Console.Clear();
            checkThisOut = false;
            return array;
        }
    }
    Console.Clear();
    return arrayResult;
}

string[] SortArray(string[] array)
{
    string[] arraySorted = new string[array.Length];
    int j = 0;
    for (int i = 0; i < arraySorted.Length; i++)
    {
        if (array[i].Length <= 4)
        {
            arraySorted[j] = array[i];
            j++;
        }    
    }
    return arraySorted;
}

void PrintArray(string[] array)
{
    int i = 0;
    int arrayLength = array.Length;
    Console.WriteLine();
    while (i < arrayLength)
    {
        Console.Write(array[i] + " ");
        i++;
    }
    Console.WriteLine();
}

string[] arrayWordsInput = {"Apple", "-2", "Train", "Eve", "12", ":-)", "654", "Final Test", ">_>"};
string[] arrayWords;

arrayWords = InputArray(arrayWordsInput);
arrayWords = SortArray(arrayWords);
PrintArray(arrayWords);