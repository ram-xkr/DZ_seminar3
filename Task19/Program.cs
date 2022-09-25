// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

using static System.Console;

Clear();
Write("Введите пятизначное число: ");
int chislo = int.Parse(ReadLine()!);
int num = chislo;
int num1 = 0;
int num2 = 0;
int num3 = 0;
int num4 = 0;
int num5 = 0;

if (chislo < 9999 || chislo > 99999)
{
    WriteLine("Введено некорректное число.");
    return;
}
else
{
    num1 = num%10;
    num = num/10;
    num2 = num%10;
    num = num/10;
    num3 = num%10;
    num = num/10;
    num4 = num%10;
    num = num/10;
    num5 = num%10;
}

if (num1 == num5 && num2 == num4)
{
    WriteLine($"Число {chislo} является палиндромом.");
}
else
{
    WriteLine($"Число {chislo} не является палиндромом.");
}


   