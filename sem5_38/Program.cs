/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */
Console.WriteLine("Введите количество элементов в массиве");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
int rez = 0;
int max = 1;
int min = 100;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,100);
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
    Console.Write(array[i] + " ");

}
rez = max - min;
Console.WriteLine();
Console.WriteLine(" Минимальное значение равно " + min + " Максимальное значение равно " + max);
Console.WriteLine("Разница между максимальным и минимальным равна " + rez);