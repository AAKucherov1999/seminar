System.Console.Write("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int numberNegative = -number;
while(numberNegative <= number);
{
    System.Console.Write($"{numberNegative} ");
    numberNegative++;

}