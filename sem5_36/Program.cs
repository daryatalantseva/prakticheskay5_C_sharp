/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */


Console.WriteLine("Введите количество элементов в массиве");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,100);
    if (i % 2 == 0)
    {
        sum = sum + array[i];
    }
    Console.Write(array[i] + " ");

}
Console.WriteLine();
Console.WriteLine("Сумма элементов стоящих на четных местах равна " + sum);