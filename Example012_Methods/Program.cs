//Вид1 
/*
void Method ()
{
    Console.WriteLine("Автор...");
}
//Method();



//Вид2


void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21("текст", 4);
//Method21(count:4, msg: "новый текст"); // можно так записать


//Вид3

int Method3()
{
    return DateTime.Now.Month;
}

//int year = Method3();
//Console.WriteLine(year);

//Вид4

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

//string res = Method4(10, "Anna");
//Console.WriteLine(res);

string Method5(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;   
    }
    return result;
}
    
//string res = Method4(10, "Anna");
//Console.WriteLine(res);



//двойной цикл, пример с таблицей умножения
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i*j}");
    }
    Console.WriteLine();
}


string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
+ "ежели бы вас послали вместо нашего милого"
+ "Винценгероде, вы бы взяли приступом согласие"
+ "прусского короля. Вы так красноречивы. Вы"
+ "дадите мне чаю?";

// пояснения:
// strings = "qwerty"
//            012345
// s[3] // r можем обратиться к данным строковой перемнной

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '_');
Console.WriteLine(newText);

Console.WriteLine();

newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);


*/


//сортировка методом выбора

/*int [] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
            Console.Write($"{array[i]} ");
    }
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition])
            {
                minPosition = j;
            }   
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray (arr);
SelectionSort(arr);
Console.WriteLine();
PrintArray (arr);*/




void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
            Console.Write($"{array[i]} ");
    }
}


void FillArray(int[] collection)
{
    int length = collection.Length;
        for (int i = 0; i < length; i++)
        {
        collection[i] = new Random().Next(1, 50);
        }
}


void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[maxPosition])
            {
                maxPosition = j;
            }   
        }

        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

Console.WriteLine("введите размер массива");
int massiv = int.Parse(Console.ReadLine());

Console.WriteLine("сечас покажу какой массив получился");
int [] array = new int [massiv];

FillArray(array);
PrintArray(array);

Console.WriteLine(" ");

Console.Write("хотите отсортирую от большего к меньшему?");
string yn = Console.ReadLine();
if (yn.ToLower() == "да") // to.lower  нужно чтоб можно было "да" писать в с любой буквы, (yn == "да") - так тоже работает
{
    SelectionSort (array);
    PrintArray(array);
}
else
{
    Console.WriteLine("ну и не надо");
}







//PrintArray (arr);
//SelectionSort(arr);
//Console.WriteLine();
//PrintArray (arr);
