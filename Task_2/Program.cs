// По двум заданным числам проверять является ли одно квадратом другого

Console.Clear();

Console.Write("Enter the first number: ");

double numA = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Enter the second number: ");

double numB = double.Parse(Console.ReadLine() ?? "0");

if(numA < numB)
{
 
    if(numB / numA == numA)
        Console.WriteLine($"{numB} is square of {numA}");
    else
        Console.WriteLine($"{numB} is not square of {numA}");

}
else
{
    if (numA > numB)
    {
        if (numA / numB == numB)
            Console.WriteLine($"{numA} is square of {numB}");
        else
            Console.WriteLine($"{numA} is not square of {numB}");
    }
    else
        Console.WriteLine("The numbers are equal");

}

