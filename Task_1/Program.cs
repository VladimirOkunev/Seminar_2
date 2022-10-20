//Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.Clear();

string [] week = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"}; // add array of the days

int day = new Random().Next(0, 7); // generate a number of the day of the week

Console.WriteLine($"Number of the day: {day+1}"); //display a generated number of the day

Console.WriteLine($"Day of the week: {week[day]}"); // display day corresponding to the number 

if(day==5 || day==6) // define the day is weekend or not
    Console.WriteLine($"{week[day]} is weekend");
else
    Console.WriteLine($"{week[day]} is not weekend");

