﻿/*Задача 8: Напишите программу, которая на вход
принимает число (N), а на выходе показывает все чётные
числа от 1 до N.*/

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (count <= number) //выводит все четные числа до N, не включаяя его самого. Если надо включая, то while (count <= number)
{
    Console.Write (count + " ");
    count = count + 2;
}