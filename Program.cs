Console.Clear();

// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());
int numberStraith = number;
int numberReverse = 0;

while (numberStraith > 0)
{
numberReverse *= 10;
numberReverse += numberStraith % 10;
numberStraith /= 10;
}
if (numberReverse == number)
{
Console.Write("The Number is Polindrom");
}
else
{
Console.Write("The Number is NOT Polindrom ");
}