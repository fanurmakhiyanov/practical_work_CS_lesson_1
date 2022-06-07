// Задача 2: Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 7

Console.Write("Введите первое сравниваемое число: ");
string paramString1 = Console.ReadLine();
int paramInt1 = int.Parse(paramString1);
Console.Write("Введите второе сравниваемое число: ");
string paramString2 = Console.ReadLine();
int paramInt2 = int.Parse(paramString2);
Console.Write("Введите третье сравниваемое число: ");
string paramString3 = Console.ReadLine();
int paramInt3 = int.Parse(paramString3);
Console.WriteLine($"Вы сравниваете числа {paramInt1}, {paramInt2} и {paramInt3}");

if ((paramInt1 > paramInt2) || (paramInt1 > paramInt3))

{
    Console.WriteLine($"Из этих чисел максимальным является {paramInt1}");
}
else if ((paramInt2 > paramInt1) || (paramInt2 > paramInt3))
{
    Console.WriteLine($"Из этих чисел максимальным является {paramInt2}");
}
else
{
    Console.WriteLine($"Из этих чисел максимальным является {paramInt3}");
}