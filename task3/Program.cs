// Задача 3: Напишите программу, которая на вход
// принимает число и выдаёт, является ли число чётным
// (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> не

Console.Write("Введите число: ");
string paramString = Console.ReadLine();
int paramInt = int.Parse(paramString);
Console.WriteLine($"Вы ввели число {paramInt}");


if (paramInt % 2==1)
{
    Console.WriteLine($"Число {paramInt} нечетное");
}
else
{
    Console.WriteLine($"Число {paramInt} четное");
}