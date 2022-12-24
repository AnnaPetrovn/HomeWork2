/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/
void SecondOfThree()
{
    Console.WriteLine("Введите целое трехзначное число:");
    string nu = Console.ReadLine();
    int number = Convert.ToInt32(nu);
    number = number/10;
    number = number%10;
    Console.WriteLine("Вторая цифра трехзначеного числа " + number);
}
SecondOfThree();