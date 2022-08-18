/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */
double[] array = new double[10] { 1.05, 2.5, 2.3, 8.5, 6.5, 7.2, 4.3, 7.6, 4.2, 5.1 };

double rez = 0;
double max = array[0];
double min = array[0];
for (int i = 0; i < array.Length; i++)
{
  
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