// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int N = Prompt("Введите число N: ");
int s = 1;
while (s <= N)
{
    System.Console.WriteLine(s*s*s);
    s=s+1;
}
