string[] array = { "123", "Символ", "VSCode", ":-)" };
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) count++;        
}

string[] resultArr = new string[count];
int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {        
        resultArr[j] = array[i];
        j++;
    }
}
