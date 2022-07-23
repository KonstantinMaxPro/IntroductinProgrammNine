int SumNumbersRecursion(int start, int end, int sum = 0)
{
    if (start > end)
    {
        return sum;
    }
    sum += start;
    start++;
    return SumNumbersRecursion(start, end, sum);
}
int startNumber = 0;
int endNumber = 0;
string programmName = "|  СУММА ПОРЯДКОВЫХ ЧИСЕЛ ОТ И ДО  |";
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
Console.Write($"Сумма порядковых номеров от {startNumber} до {endNumber}\nРавна: ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(SumNumbersRecursion(startNumber, endNumber));
Console.ResetColor();
Console.WriteLine(line + "\n");
