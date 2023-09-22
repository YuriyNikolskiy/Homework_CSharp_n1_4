Console.Write("Enter the first number: ");
string number_1 = Console.ReadLine();
Console.Write("Enter the second number: ");
string number_2 = Console.ReadLine();
Console.Write("Enter the 3rd number: ");
string number_3 = Console.ReadLine();
int number1 = Int32.Parse(number_1);
int number2 = Int32.Parse(number_2);
int number3 = Int32.Parse(number_3);

if(number1>number2 && number1>number3)
{
    Console.Write("Max number: ");
    Console.WriteLine(number1);
}
else if(number2>number1 && number2>number3)
{
    Console.Write("Max number: ");
    Console.WriteLine(number2);
}
else
{
    Console.Write("Max number: ");
    Console.WriteLine(number3);
}