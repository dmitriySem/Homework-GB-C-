// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


Console.Clear();
// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

if((number % 7 == 0) & (number % 23 == 0))
Console.WriteLine("Число кратно и 7 ,и 23");

if((number % 7 == 0) & (number % 23 != 0))
Console.WriteLine("Число кратно  7, но не  23");

if((number % 7 != 0) & (number % 23 == 0))
Console.WriteLine("Число не кратно 7, но кратно 23");

if((number % 7 != 0) & (number % 23 != 0))
Console.WriteLine("Число не кратно  ни 7, ни  23");
