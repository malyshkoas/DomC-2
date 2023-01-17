// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());

 if (num > 0 && num < 6)
 {
    System.Console.WriteLine("нет");
 }
else if (num > 5 && num < 8)
{ 
    System.Console.WriteLine("да");
}