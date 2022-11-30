// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void FillArrayRandomNumbers(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            Random rand = new Random();
            array[i] = Math.Round(rand.Next(0, 100) + rand.NextDouble(), 2);

        }
}

Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
double[] array = new double[num];
FillArrayRandomNumbers(array);
Console.WriteLine("Ваш массив: ");
{   Console.Write("[");
    for(int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
    Console.Write("]");
    Console.WriteLine();
}
double min = Int32.MaxValue;
double max = Int32.MinValue;
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
}

Console.Write($"Разница между максимальным и минимальным значением массива равна {max - min}");
