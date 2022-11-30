// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArray(int size)
{
int[] arr = new int[size];
for(int i = 0; i < arr.Length; i++)
{
arr[i] = new Random().Next(-99,100);
}
return arr;
}
Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(num);
Console.WriteLine("Ваш массив: "+ string.Join(", ", array));
int sum = 0;
for(int i = 0; i < array.Length; i++)
{
    if(i%2!=0)
    {
       sum = sum + array[i]; 
    }
}

    Console.Write($"Cумма элементов массива, стоящих на нечётных позициях, равна {sum}");