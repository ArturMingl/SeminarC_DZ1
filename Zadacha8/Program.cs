//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите целое число");
int numA = Convert.ToInt32(Console.ReadLine());
int even = 2;
while(even < numA)
{
    int remains = even % 2;
    if(remains == 0) Console.Write($"{even} ");
    even++;
}