void FillterOfArray(string[] arrFiller, string[] arrFilled)
{
    int temp = 0;
    for (int i = 0; i < arrFiller.GetLength(0); i++)
    {
        if (arrFiller[i].Length <= 3)
        {
            arrFilled[temp] = arrFiller[i];
            temp++;
        }
    }
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write(arr[i] + " ");
    }
}


string[] arrayString = {"hello", "2", "world", ":-)"};
string[] arrayFinish = {"", "", "", ""};
FillterOfArray(arrayString, arrayFinish);
PrintArray(arrayFinish);
