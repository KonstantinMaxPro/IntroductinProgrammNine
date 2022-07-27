int Akkerman(int m, int n)
{
    if (m == 0)
        return (n + 1);
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    return Akkerman(m - 1, Akkerman(m, n - 1));
}

int firstNumber = 0;
int secondNumber = 0;
string programmName = "|  ВЫЧЕСЛЕНИЕ ПО ФУНКЦИИ АККЕРМАНА |";
string intError = "ОШИБКА! ВЫ ВВЕЛИ НЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n";
string line = new string('=', programmName.Length);
string message1 = "Введите первое число: ";
string message2 = "Введите второе число: ";
Console.Clear();//Очищаем консоль
/*ЗАГОЛОВОК (ДЛЯ КРАСОТЫ)*/
Console.WriteLine($"{line}\n{programmName}\n{line}\n");//Название
/*КОНЕЦ ЗАГОЛОВКА*/
Console.Write(message1);
while (!int.TryParse(Console.ReadLine(), out firstNumber))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(intError);
    Console.ResetColor();
    Console.Write(message1);
}
Console.Write(message2);
while (!int.TryParse(Console.ReadLine(), out secondNumber))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(intError);
    Console.ResetColor();
    Console.Write(message2);
}
Console.WriteLine("\n" + line);
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"Результат: {Akkerman(firstNumber, secondNumber)}");
Console.ResetColor();
Console.WriteLine(line + "\n");


