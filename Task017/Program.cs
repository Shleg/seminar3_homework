// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool Palindrome(string text)
{
    string newText = string.Empty;
    for (int i = 1; i <= text.Length; i++)
    {
        newText += text[text.Length - i];
    }

    if (newText == text)
    {
        return true;
    }
    else
    {
        return false;
    }

}

bool CheckFiveDigit(string text)
{
    char zero = '0';
    if (text.Length == 5 && text[0] !=  zero)
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool CheckNum(string text)
{
    int result;
    if (int.TryParse(text, out result))
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Write("Введите целое пятизначное число: ");
string userInput = Console.ReadLine();

if (CheckNum(userInput))
{
    if (CheckFiveDigit(userInput))
    {
        if (Palindrome(userInput))
        {
            Console.WriteLine($"{userInput} -> является палиндромом");
        }
        else
        {
            Console.WriteLine($"{userInput} -> не является палиндромом");
        }

    }
    else
    {
        Console.WriteLine("Необходимо ввести пятизначное число!");
    }
}
else
{
    Console.WriteLine("Введенные данные не являются числом!");
}