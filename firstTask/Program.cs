/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

int GetNumber()
{
    int number;
    
    Console.WriteLine("Введите число: ");
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out number))
        {
            break;
        }
        else 
        {
            Console.WriteLine("Вы должны ввести число!");
        }
    }

    return number;

}

void IsNumberPalindrome(int number)
{
    int numberCopy = number;
    int reverseNumber = 0;
    
    while (numberCopy > 0)
    {
        reverseNumber *= 10;
        reverseNumber += numberCopy % 10;
        numberCopy /= 10;
    }

    if (number == reverseNumber)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}

int number = GetNumber();
Console.WriteLine("Exit ");
IsNumberPalindrome(number);