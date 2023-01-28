/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int GetNumber()
{
    int number;
    
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

void Show3DegreeNumbers(int highLimit)
{
    for (int i = 1; i <= highLimit; i++)
    {
        if (i == highLimit)
        {
            Console.Write($"{Math.Pow(i, 3)} ");
        }
        else
        {
            Console.Write($"{Math.Pow(i, 3)}, ");
        }
        
    }
}

Console.WriteLine("Введите число: ");
int highLimit = GetNumber();
Show3DegreeNumbers(highLimit);