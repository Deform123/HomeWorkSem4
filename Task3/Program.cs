//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();

Console.WriteLine("Введите воличество чисел в массиве : ");
int n = Convert.ToInt32(Console.ReadLine());

int [] array = new int [n];

for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next();
        Console.Write($"{array [i] + " "}");
    }
