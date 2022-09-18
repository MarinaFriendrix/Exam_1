// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] Array1;
string[] Array2;

Array1 = new string[] {"danmark", "rz", "2", "500", "moscow"};
Array2 = new string[5];

for (int i = 0; i < Array1.Length; i++)
{
    Console.Write(Array1[i]+ " ");
}
Console.WriteLine();

int j=0;
for (int i = 0; i < Array1.Length; i++)
{
    
    if (Array1[i].Length < 3)
    {
         Array2[j] = Array1[i];
        
         Console.Write(Array2[j]+ " ");
        j++;
    }

}

    
    
    

