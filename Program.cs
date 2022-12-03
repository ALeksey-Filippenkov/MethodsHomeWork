// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// void Number (int num1)
// {
//     int tenth = num1 / 10 % 10;   
//     System.Console.WriteLine();
//     System.Console.WriteLine(tenth);
// }
// System.Console.WriteLine("Введите любое трёхзначное число и мы покажем Вам вторую цифру в нем");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Number(num1);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// //Сопособ 1
// void Number (int num1)
// {
//     if (num1 > 99)
//     {
//         while (num1 > 999)
//         {
//             num1 = num1 / 10;
//         }
//         int unit = num1 % 10;
//         System.Console.WriteLine();
//         System.Console.WriteLine(unit);
//     }
//     else
//         System.Console.WriteLine("третьей цифры нет");
// }
// System.Console.WriteLine("Введите любое число и мы покажем Вам третью цифру в нем.");
// System.Console.WriteLine("Введите любое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Number(num1);

// // способ 2
// int Number(int num1)
// {
//     int result = -1;
//     if (num1 > 99)
//     {
//         while (num1 > 999)
//         {
//             num1 = num1 / 10;
//         }
//         result = num1 % 10;
//     }
//     return result;
// }
// System.Console.WriteLine("Введите любое число и мы покажем Вам третью цифру в нем.");
// System.Console.WriteLine("Введите любое число");
// int number = Convert.ToInt32(Console.ReadLine());
// if (Number(number) == -1)
//     System.Console.WriteLine("третьей цифры нет");
// else
//     System.Console.WriteLine(Number(number));

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void Week(int weekNumber)
{
    if (0 < weekNumber && weekNumber < 6)
        System.Console.WriteLine("Нет");
    else if (weekNumber == 6 || weekNumber == 7)
        System.Console.WriteLine("Да");
    else
    System.Console.WriteLine("Вы ввели несуществующий день недели");
}
System.Console.WriteLine("Программа которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным");
System.Console.WriteLine("Введите цифру, обозначающую день недели (1 - понедельник, 2 - вторник, 3 - среда, и т.д.");
int weekNumber = Convert.ToInt32 (Console.ReadLine());
Week(weekNumber);