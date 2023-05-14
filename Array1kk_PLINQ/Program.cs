/*
Используя Visual Studio, создайте проект по шаблону Console Application
Создайте программу, в которой создайте массив чисел размерностью в 1 000 000 или более.
Используя генератор случайных чисел, проинициализируйте этот массив значениями. Создайте
PLINQ запрос, который позволит получить все нечетные числа из исходного массива.
*/

int[] array = new int[1000000];

Random random = new ();
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(0, 1000);
}


ParallelQuery<int> oddNumbers = from num in array.AsParallel()
                               where num % 2 != 0
                               select num;

foreach (var item in oddNumbers)
{
    Console.WriteLine(item);
}