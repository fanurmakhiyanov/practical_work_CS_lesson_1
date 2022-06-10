// Задача 4: Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
string number = Console.ReadLine();
int numberInt = int.Parse(number);
int i = 1;

while(i <= numberInt)

{
    if (i % 2 == 0)
    {
        Console.Write($"{i} ");
    }
    i++;
}