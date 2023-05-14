/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите программу, в которой метод будет вызываться рекурсивно. Каждый новый вызов метода
выполняется в отдельном потоке.
*/

Method();

void Method()
{
    Thread thread = new(Method);
    Console.WriteLine($"Этот метод вызван в новом потоке | Номер потока: {thread.ManagedThreadId}");
    Thread.Sleep(10);
    thread.Start();     
}
