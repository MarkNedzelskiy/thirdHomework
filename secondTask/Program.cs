/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int[] get3DimensionalPoint()
{
    int[] point = new int[3];
    
    Console.WriteLine("Введите координату x:");
    point[0] = GetNumber();

    Console.WriteLine("Введите координату y:");
    point[1] = GetNumber();

    Console.WriteLine("Введите координату z:");
    point[2] = GetNumber();

    return point;

}

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

double calcDistance(int[] firstPoint, int[] secondPoint)
{
    double distance;
    distance = Math.Sqrt(Math.Pow(firstPoint[0] - secondPoint[0], 2) + Math.Pow(firstPoint[1] - secondPoint[1], 2) + Math.Pow(firstPoint[2] - secondPoint[2], 2));
    return distance;
}

Console.WriteLine("Введите координаты первой точки.");
int[] firstPoint = get3DimensionalPoint();

Console.WriteLine("Введите координаты второй точки.");
int[] secondPoint = get3DimensionalPoint();

double distanceBetweenPoints = calcDistance(firstPoint, secondPoint);

Console.WriteLine($"Расстояние между двумя точками с координатами {firstPoint[0]}, {firstPoint[1]}, {firstPoint[2]}, и {secondPoint[0]}, {secondPoint[1]}, {secondPoint[2]}, равно {Math.Round(distanceBetweenPoints, 2)}");