using static System.Console;

string[] array = {"hello", "2", "world", ":-)"};
int count = 3;
int resultArrayLength = GetAmountOfElements(array);
string [] resultArray = GetElements(array);
PrintArray(array);
WriteLine("-------------");
WriteLine(resultArrayLength);
WriteLine("-------------");


PrintArray(resultArray);


int GetAmountOfElements(string[] searchAmountinArray)
{
    int amount = 0;
    for(int i = 0; i < searchAmountinArray.Length; i++)
    {
        if(searchAmountinArray[i].Length <= count)
        {
            amount++;
        }
    }
    return amount;

}

string[] GetElements(string[] searchInArray)
{
    int resultLength = 0;
    string [] result = new string[resultArrayLength];
    for(int i = 0; i < searchInArray.Length; i++)
    {
        if(searchInArray[i].Length <= count)
        {
            result[resultLength] = searchInArray[i];
            resultLength++;
        }
        


    }
    return result;
}

void PrintArray(string[] arrayToPrint)
{
    for(int i = 0; i < arrayToPrint.Length; i++)
    {
        if(i < arrayToPrint.Length - 1)
        {
            Write($"{arrayToPrint[i]},  ");     
        }
        else
        {
            Write($"{arrayToPrint[i]}  ");
        }
            
        
        
    }
    WriteLine();
}