/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/
void NumOfWeek()
{
    Console.WriteLine("Введите целое число:");
    string nu = Console.ReadLine();
    int number = Convert.ToInt32(nu);
    if(number>0 && number<6)
    {
        Console.WriteLine("День недели является будним днём");
    }
    else if(number>5 && number<8)
    {
        Console.WriteLine("День недели является выходным днём.");
    }
    else
    {
        Console.WriteLine("Данное число нельзя отнести ко дню недели");
    }
}
NumOfWeek();