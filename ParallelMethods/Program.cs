/*
Используя Visual Studio, создайте проект по шаблону Console Application
Создайте два метода, которые будут выполняться в рамках параллельных задач. Организуйте
вызов этих методов при помощи Invoke таким образом, чтобы основной поток программы
(метод Main) не остановил свое выполнение
*/

Parallel.Invoke(
    PrintMessage,
    () =>
    {
        Console.WriteLine($"Текущая задача {Task.CurrentId}");
        Thread.Sleep(500);
    },
    () => SquareNumber(5, 10)
);

void PrintMessage()
{
    Console.WriteLine($"Текущая задача {Task.CurrentId}");
    Thread.Sleep(500);
}
void SquareNumber(int number, int power)
{
    Console.WriteLine($"Текущая задача {Task.CurrentId}");
    Thread.Sleep(500);
    Console.WriteLine($"Результат: {number} в степени {power} = {Math.Pow(number, power)}");
}