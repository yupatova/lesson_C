void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 50);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]+ " ");
        position++;
    }
}

Console.WriteLine("введите количество значений в массиве");
int massiv = int.Parse(Console.ReadLine());

Console.WriteLine("сечас покажу какой массив получился");

int [] array = new int [massiv];

FillArray(array);
PrintArray(array);

Console.WriteLine();

Console.WriteLine("введите число от 1 до 50, индекс в массиве которого, вы хотите узнать");
int find = int.Parse(Console.ReadLine());

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
        return position;
}

int pos = IndexOf(array, find);
Console.WriteLine("индекс числа "+ find + " - " + pos);