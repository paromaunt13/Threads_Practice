/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу, в котором организуйте асинхронный вызов метода.
Используя конструкцию BeginInvoke передайте в поток некоторую информацию (возможно, в
формате строки). Организуйте обработку переданных данных в callback методе.
*/

Action<string> printMessage = Console.WriteLine;

AsyncCallback callback = new AsyncCallback(SecondMessage);

Task.Run(() => { printMessage("First message"); }).Wait();
Thread.Sleep(1000);
Task.Run(() => { callback(null); }).Wait();

void SecondMessage(IAsyncResult asyncResult)
{
    Console.WriteLine("Second message");
}
