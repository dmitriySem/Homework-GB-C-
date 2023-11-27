// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
/*
Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

if((number % 7 == 0) & (number % 23 == 0))
Console.WriteLine("Число кратно и 7 ,и 23");

if((number % 7 == 0) & (number % 23 != 0))
Console.WriteLine("Число кратно  7, но не  23");

if((number % 7 != 0) & (number % 23 == 0))
Console.WriteLine("Число не кратно 7, но кратно 23");

if((number % 7 != 0) & (number % 23 != 0))
Console.WriteLine("Число не краgiтно  ни 7, ни  23");
*/

//Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
/*
Console.Clear();

Console.WriteLine("Введите координату X точки: ");
int X = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y точки: ");
int Y = int.Parse(Console.ReadLine()!);

if((X>=0) & (Y>=0))
Console.WriteLine($"Точка с координатами ({X},{Y}) находится в 1-й четверте");
if((X<=0) & (Y>=0))
Console.WriteLine($"Точка с координатами ({X},{Y}) находится в 2-й четверте");
if((X<=0) & (Y<=0))
Console.WriteLine($"Точка с координатами ({X},{Y}) находится в 3-й четверте");
if((X>=0) & (Y<=0))
Console.WriteLine($"Точка с координатами ({X},{Y}) находится в 4-й четверте");
*/

//Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99]
// и показывает наибольшую цифру числа.
/*
Console.Clear();

Console.WriteLine("Введите число из отрезка [10, 99]: ");
int X = int.Parse(Console.ReadLine()!);
int x1 = X / 10;
int x2 = X % 10;

if(x1 == x2)
Console.WriteLine($"Цифры числа {X} равны ");
if ((x1 > x2) & (x1 != x2))
Console.WriteLine($"Наибольшая цифра числа {X} является '{x1}'");
if ((x1 < x2) & (x1 != x2))
Console.WriteLine($"Наибольшая цифра числа {X} является '{x2}'");
*/

// Задача 4: Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.
Console.Clear();

Console.WriteLine("Введите число: ");
string N = Console.ReadLine();
foreach(char ch in N)
    Console.Write($"{ch}, \t"); 
