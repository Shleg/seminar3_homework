// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int CheckNum(string text)
{
    int result;
    if (int.TryParse(text, out result))
    {
        return result;
    }
    else
    {
        return 0;
    }
}

Console.Write("Введите целое число: ");
string num = Console.ReadLine();

if (CheckNum(num) != 0)
{
    Console.Write($"{num} ->");
    for(int i = 1; i <= CheckNum(num); i++)
    {
        Console.Write(", " +Math.Pow(i, 3));
    }
    Console.WriteLine();
}
else
{
    Console.WriteLine("Введены не верные данные, необходимо ввести целое число");
}
