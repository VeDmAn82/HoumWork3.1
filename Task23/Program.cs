// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

Console.Write("Введите число N: ");
bool isNum_x = int.TryParse(Console.ReadLine(), out int x);

if (!isNum_x || x <= 0)
{
    Console.WriteLine("Ошибка ввода");
    return;
}

int[] GetCube(int y)
{
    int i = 1;
    int[] array = new int[y];
    while (i <= y)
    {
        array[i - 1] = (int)Math.Pow(i, 3);
        i++;
    }
    return array;
}

void PrintArray(int[] array)
{
    int i = 0;
    int lenght = array.Length;
    while (i < lenght)
    {
        Console.Write($"{array[i]} ");
        i++;
    }
}

PrintArray(GetCube(x));