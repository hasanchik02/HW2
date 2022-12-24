//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//int number = new Random().Next (100,1000);

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int firstDigit = number / 100 * 100;
int secondDigit = number - firstDigit;
int thirdDigit = number % 10; 
int finalDigit = (secondDigit - thirdDigit)/10; 

Console.WriteLine("Вторая цифра в числе");
Console.WriteLine(finalDigit);