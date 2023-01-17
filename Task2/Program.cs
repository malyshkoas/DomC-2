//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num / 100;

if (num1 >= 1)
{
    int result = num % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}