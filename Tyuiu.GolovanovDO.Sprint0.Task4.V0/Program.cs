﻿using Tyuiu.GolovanovDO.Sprint0.Task4.V0.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        //Пример линейной структуры программы 
        //вызов метода addition
        Console.WriteLine(DataService.Addition(1, 5));

        Console.WriteLine(DataService.Substraction(15, 5));

        Console.WriteLine(DataService.Multiplication(10, 10));

        Console.WriteLine(DataService.Division(5, 5));

        Console.ReadLine();
        
    }
}