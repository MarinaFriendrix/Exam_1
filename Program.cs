﻿// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// var resultArr = existArr.Where(x=>x.Length < 4).ToArray();


string[] Array1;
Array1 = new string[] {"danmark", "rz", "2", "500", "moscow"};

for (int i = 0; i < Array1.Length; i++)
    {
        Console.Write(Array1[i]+ " ");

    }
    Console.WriteLine();
for (int i = 0; i < Array1.Length; i++)
{
    if (Array1[i].Length < 3)
    {
        Console.WriteLine(Array1[i]);
    }
    
}

    
    
    

