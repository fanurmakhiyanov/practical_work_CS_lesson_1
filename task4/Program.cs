// Задача 4: Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
string paramString = Console.ReadLine();
int paramInt1 = int.Parse(paramString);
int paramInt2 = (paramInt1-paramInt1) + 1;
Console.Write($"{paramInt1} -> ");

while(paramInt2 < paramInt1)

{
    Console.Write($"{paramInt2}, ");
    paramInt2 = paramInt2 + 1;

}
Console.Write($"{paramInt1}");