
/* Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */
Console.WriteLine("Введите количество элементов в массиве");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
int rez = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100,1000);
    if (array[i] % 2 == 0)
    {
        rez++;
    }
    Console.Write(array[i] + " ");

}
Console.WriteLine();
Console.WriteLine("Количество четных элементов равно " + rez);

