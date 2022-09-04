Console.WriteLine("ВВедите число от 1 до 10 ");
string name = Console.ReadLine();
int number = Convert.ToInt32(name);
if(number % 2 == 0)
{
    Console.WriteLine("Четное число");
}
else 
{
    Console.WriteLine("Нечетное число");
}
