// Напишите программу,которая принимает на вход число (N)
 //и выдает таблицу кубов чисел от 1 до (N)

void PrintCubeTable(int N)
{
    for (int i = 1; i <= N; i++)
    {
        int cube = i * i * i;
        Console.WriteLine($"{i}^3 = {cube}");
    }
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int N = GetInput("Введите число N: ");
PrintCubeTable(N);