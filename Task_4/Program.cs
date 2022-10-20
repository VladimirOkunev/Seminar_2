// Найти расстояние между точками в пространстве 2D/3D

Console.Clear();

double result = 0;
double x1 = 0, y1 = 0, z1 = 0, x2 = 0, y2 = 0, z2 = 0;

Console.Write("Select 2- or 3- dimensional space: ");

int dim = int.Parse(Console.ReadLine() ?? "0");

while (dim < 2 || dim > 3) // check the correctness of the value
{
    Console.Clear();
    Console.WriteLine("Incorrect value");
    Console.Write("Select 2- or 3- dimensional space:  ");
    dim = int.Parse(Console.ReadLine() ?? "0");
}
Console.WriteLine(" ");

if (dim == 2) // calculate the distance for 2D space:
{
    Console.WriteLine("Enter coordinate of the first point");
    Console.WriteLine("");

    Console.Write("Enter coordinate X1:  ");
    x1 = double.Parse(Console.ReadLine() ?? "0");
    Console.Write("Enter coordinate Y1:  ");
    y1 = double.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("");

    Console.WriteLine("Enter coordinate of the second point");
    Console.WriteLine("");

    Console.Write("Enter coordinate X2:  ");
    x2 = double.Parse(Console.ReadLine() ?? "0");
    Console.Write("Enter coordinate Y2:  ");
    y2 = double.Parse(Console.ReadLine() ?? "0");

    result = Math.Sqrt((x1 - x2)*(x1 - x2) + (y1 - y2)*(y1 - y2));
}

else // calculate the distance for 3D space:
{
    Console.WriteLine("Enter coordinate of the first point");
    Console.WriteLine("");

    Console.Write("Enter coordinate X1:  ");
    x1 = double.Parse(Console.ReadLine() ?? "0");
    Console.Write("Enter coordinate Y1:  ");
    y1 = double.Parse(Console.ReadLine() ?? "0");
    Console.Write("Enter coordinate Z1:  ");
    z1 = double.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("");

    Console.WriteLine("Enter coordinate of the second point");
    Console.WriteLine("");

    Console.Write("Enter coordinate X2:  ");
    x2 = double.Parse(Console.ReadLine() ?? "0");
    Console.Write("Enter coordinate Y2:  ");
    y2 = double.Parse(Console.ReadLine() ?? "0");
    Console.Write("Enter coordinate Z3:  ");
    z2 = double.Parse(Console.ReadLine() ?? "0");

    result = Math.Sqrt((x1 - x2)*(x1 - x2) + (y1 - y2)*(y1 - y2) + (z1 - z2)*(z1 - z2));
}


Console.WriteLine("");
Console.Write($"The distance between two points is: {result}");