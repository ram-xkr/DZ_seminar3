// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

using static System.Console;

Clear();
Write("Введите число, до которого выхотите узнать кубы: ");
int num = int.Parse(ReadLine()!);
if (num < 1)
{
    WriteLine("Попробуй ещё раз.");
}
else
{
    int i = 1;
    while (i <= num)
    {
        Write($"{Math.Pow(i, 3)} ");
        i++;
        
    }

}