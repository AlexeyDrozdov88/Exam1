//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
//либо задать на старте выполнения алгоритма. 

//ввод целых чисел
int Input(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine());
    return num;
}

// ввод массива 
string[] Fillarray(int m)
{
    string[] array = new string[m];
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введите {i + 1}-й элемент массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

// вывод массива
void Printarray(string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

//Метод для создания массива с элементами 3- символов
String[] СutArray(string[] array)
{
    string[] arrayNew = new string[array.GetLength(0)];
    int j = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i].Length <= 3)
        {
            arrayNew[j] = array[i];
            j++;
        }
    }
    return arrayNew;
}

int count = Input("Введи кол-во элементов массива : ");
string[] arr = Fillarray(count);
Printarray(СutArray(arr));