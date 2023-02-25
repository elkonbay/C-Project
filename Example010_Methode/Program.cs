int[] array = {11,29,36,43,51,62,73,58,39};

int n = array.Length;
int find = 51;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}