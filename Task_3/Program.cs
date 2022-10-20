// Задать номер четверти, показать диапазоны для возможных координат

Console.Clear();

Console.Write("Enter the number of the quarter:  ");
int num = int.Parse(Console.ReadLine() ?? "0");

while(num < 1 || num > 4)
{
    Console.Clear();
    Console.WriteLine("The number is to be in the range from 1 to 4");
    Console.Write("Enter the number of the quarter:  ");
    num = int.Parse(Console.ReadLine() ?? "0");
}
Console.WriteLine(" ");

if(num == 1) Console.Write("coordinates: x (0; + Inf), y (0; + Inf)");
if(num == 2) Console.Write("coordinates: x (0; - Inf), y (0; + Inf)");
if(num == 3) Console.Write("coordinates: x (0; - Inf), y (0; - Inf)");
if(num == 4) Console.Write("coordinates: x (0; + Inf); y (0; - Inf)");