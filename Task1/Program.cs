// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();

Console.WriteLine("Введите число А : ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B : ");
int B = Convert.ToInt32(Console.ReadLine());

int deg = A;

for (int i = 0; i < B - 1; i++)
{
    deg = deg * A;
}
Console.WriteLine($"Число {A} в степени {B} равно {deg} .");