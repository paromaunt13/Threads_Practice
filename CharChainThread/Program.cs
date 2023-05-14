/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу, которая будет выводить на экран цепочки падающих символов. Длина каждой
цепочки задается случайно. Первый символ цепочки – белый, второй символ – светло-зеленый,
остальные символы темно-зеленые. Во время падения цепочки, на каждом шаге, все символы меняют
свое значение. Дойдя до конца, цепочка исчезает и сверху формируется новая цепочка. Смотрите ниже
снимок экрана, представленный как образец.
*/

var chars = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";
new Thread(() => CharChain(0)).Start();

void CharChain(int a)
{
    int counter = 0;
    while (true)
    {
        for (int i = 0; i <= 10; i++)
        {
            ShowWhiteSign(GetRandomNum(), a);
            ShowGreenSign(GetRandomNum(), a);
            ShowDarkGreenSign(GetRandomNum(), a, i);
        }
        Thread.Sleep(30);

        counter++;
        if (counter == 10)
        {
            Console.Clear();
            new Thread(() => CharChain(10)).Start();
        }
    }
}

void ShowWhiteSign(int num, int a)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.SetCursorPosition(0, 0);
    Console.CursorVisible = false;
    Console.WriteLine(new string(' ', a) + chars[num]);
}
void ShowGreenSign(int num, int a)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.SetCursorPosition(0, 1);
    Console.CursorVisible = false;
    Console.WriteLine(new string(' ', a) + chars[num]);
}
void ShowDarkGreenSign(int num, int a, int y)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.SetCursorPosition(0, y);
    Console.CursorVisible = false;   
    Console.WriteLine(new string(' ', a) + chars[num]);
}

int GetRandomNum()
{
    Random random = new ();
    int charNum = random.Next(chars.Length);
    return charNum;
}
