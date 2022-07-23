void OrderNumbersRecursion(int start, int end)
{
    if (start > end)
    {
        return;
    }
    Console.Write($"{start++} ");

    OrderNumbersRecursion(start, end);
}
int startNumber = 0;
int endNumber = 0;
string programmName = "|  ВЫВОД ПОРЯДКОВЫХ ЧИСЕЛ ОТ И ДО  |";
string intError = "ОШИБКА! ВЫ ВВЕЛИ НЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n";
string line = new string('=', programmName.Length);
string message1 = "Введите стартовое число: ";
string message2 = "Введите конечное число: ";
Console.Clear();//Очищаем консоль
/*ЗАГОЛОВОК (ДЛЯ КРАСОТЫ)*/
Console.WriteLine($"{line}\n{programmName}\n{line}\n");//Название
/*КОНЕЦ ЗАГОЛОВКА*/
Console.Write(message1);
while (!int.TryParse(Console.ReadLine(), out startNumber))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(intError);
    Console.ResetColor();
    Console.Write(message1);
}
Console.Write(message2);
while (!int.TryParse(Console.ReadLine(), out endNumber))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(intError);
    Console.ResetColor();
    Console.Write(message2);
}
Console.WriteLine("\n" + line);
Console.WriteLine($"Вывод порядковых номеров от {startNumber} до {endNumber}");
Console.ForegroundColor = ConsoleColor.Yellow;
OrderNumbersRecursion(startNumber, endNumber);
Console.ResetColor();
Console.WriteLine("\n" + line + "\n");
