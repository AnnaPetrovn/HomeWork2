/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/ 
void ThirdDigNumber()
{Console.WriteLine("Введите целое число:");
    string nu = Console.ReadLine();
    int number = Convert.ToInt32(nu);
    if(number>=1000 && number>99 || number<=-1000 && number < -99)
       {
       while(number>999 || number<-999)
       {
        number = number/10;
       }
       number = number%10;
       Console.WriteLine("Третья цифра числа " + number);
       }
       else
       Console.WriteLine("Третьей цифры нет");
}

ThirdDigNumber();
