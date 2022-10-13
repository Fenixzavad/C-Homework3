// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не применять строки!

// 14212 -> нет

// 12821 -> да

// 23432 -> да

int InputNumber(string message)
{
    System.Console.WriteLine(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}




bool ValidateNumber(int value)
{
    if (value <= 9999 || value >= 100000)
    {
        System.Console.WriteLine("Число не пятизначное!");
        return false;
    }
    return true;
}
int value = InputNumber("Введите пятизначное число: ");

if (!ValidateNumber(value))
{
    return;
}

int n1 = value;
int n2 = 0;

while (value > 0)
{
    int ost = value % 10;
    n2 = n2*10 + ost;
    value = value/10;
}
    if (n1==n2)
    {
        System.Console.WriteLine("Число является палиндромом");
    }
    else 
    {
        System.Console.WriteLine("Число не является палиндромом");
    }


