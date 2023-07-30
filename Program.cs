// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Введите трехзначное число : ");
// int numberA = Convert.ToInt32(Console.ReadLine());

// int numberB =(numberA / 10) % 10;

// Console.WriteLine("Вторая цифра числа :");
// Console.WriteLine(numberB);

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Write("Введите число : ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number == 1)
// {
//     Console.WriteLine("Нет");
// }

// else if (number == 2)
// {
//     Console.WriteLine("Нет");
// }

// else if (number == 3)
// {
//     Console.WriteLine("Нет");
// }

// else if (number == 4)
// {
//     Console.WriteLine("Нет");
// }

// else if (number == 5)
// {
//     Console.WriteLine("Нет");
// }

// else if (number == 6)
// {
//     Console.WriteLine("Да");
// }

// else if (number == 7)
// {
//     Console.WriteLine("Да");
// }

// else 
// {
//     Console.WriteLine ("Такого дня нет");
// }

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введи число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2){
  Console.WriteLine("третья цифра -> " + anyNumberText[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}