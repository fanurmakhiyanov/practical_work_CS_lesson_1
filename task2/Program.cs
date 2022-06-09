// Задача 2: Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 7

Console.Write("Введите первое сравниваемое число: ");
string paramString1 = Console.ReadLine();
int paramInt1 = int.Parse(paramString1); // int.Parse преобразует строку в число
Console.Write("Введите второе сравниваемое число: ");
string paramString2 = Console.ReadLine();
int paramInt2 = int.Parse(paramString2);
Console.Write("Введите третье сравниваемое число: ");
string paramString3 = Console.ReadLine();
int paramInt3 = int.Parse(paramString3);
Console.WriteLine($"Вы сравниваете числа {paramInt1}, {paramInt2} и {paramInt3}");

int Max(int paramInt1, int paramInt2, int paramInt3)
{
    int result = paramInt1;
    if(paramInt2 > result) result = paramInt2;
    if(paramInt3 > result) result = paramInt3;
    return result;
}

int max = Max(paramInt1, paramInt2, paramInt3);

Console.WriteLine($"Число {max} является максимальным среди введенных чисел");
Console.WriteLine($"({paramInt1}, {paramInt2}, {paramInt3} -> {max})");