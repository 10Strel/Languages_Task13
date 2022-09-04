Console.WriteLine("Программа выводит третью цифру заданного числа или сообщает, что третьей цифры нет.\r\n");

Console.WriteLine("Введите целое число:");

bool res = int.TryParse(Console.ReadLine(), out int number);
if (!res)
{
    Console.WriteLine("Ошибка ввода.\r\nВыполнение программы будет остановлено.");
    return;
}

string tmp = Math.Abs(number).ToString();

if (tmp.Length < 3)
    Console.WriteLine($"{number}: третьей цифры нет.");
else
    Console.WriteLine($"Результат: {tmp[2]}");