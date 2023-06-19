﻿int Prompt(string message)
{
    System.Console.Write( message );
    int value= Convert.ToInt32(Console.ReadLine());
    return value ;
}
int GTR(int number)
{
    while (number>999)
    {
        number/=10;

    }
    return  number % 10;
}

bool VN(int number)
{
    if (number<100)
    {
        Console.WriteLine ("Третьей цифры нет");
        return false;
    }
    return true;
}
int number =Prompt ("Введите число > ");
if ( VN(number))
{
    Console.WriteLine(GTR(number));
}