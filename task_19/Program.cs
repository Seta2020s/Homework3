//Напишите программу,которая принимает на вход пятизначное число и проверяет,
//является ли оно палиндромом

bool IsPalindrome(int number)
{
    string numberString = number.ToString();
    int length = numberString.Length;

    for (int i = 0; i < length / 2; i++)
    {
        if (numberString[i] != numberString[length - i - 1])
        {
            return false;
        }
    }

    return true;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetInput("Введите пятизначное число: ");

if (number >= 10000 && number <= 99999)
{
    if (IsPalindrome(number))
    {
        Console.WriteLine("Число является палиндромом.");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом.");
    }
}
else
{
    Console.WriteLine("Введенное число не является пятизначным.");
}
