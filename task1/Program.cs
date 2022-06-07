// Задача 1: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.

Console.Write("Введите первое сравниваемое число: ");
string paramString1 = Console.ReadLine();
int paramInt1 = int.Parse(paramString1);
Console.Write("Введите второе сравниваемое число: ");
string paramString2 = Console.ReadLine();
int paramInt2 = int.Parse(paramString2);
Console.WriteLine($"Вы сравниваете числа {paramInt1} и {paramInt2}");

if (paramInt1 > paramInt2)
{
    Console.WriteLine($"Число {paramInt1} больше числа {paramInt2}");
}
else if (paramInt1 == paramInt2)
{
    Console.WriteLine($"Числа {paramInt1} и {paramInt2} равны");
}
else
{
    Console.WriteLine($"Число {paramInt2} больше числа {paramInt1}");
}