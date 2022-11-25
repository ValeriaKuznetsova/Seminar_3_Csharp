Console.Clear();

// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Console.WriteLine("Enter the number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int numberStraith = number;
// int numberReverse = 0;

// while (numberStraith > 0)
// {
// numberReverse *= 10;
// numberReverse += numberStraith % 10;
// numberStraith /= 10;
// }
// if (numberReverse == number)
// {
// Console.Write("The Number is Polindrom");
// }
// else
// {
// Console.Write("The Number is NOT Polindrom ");
// }

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Enter coordinates point A: ");
Console.WriteLine("Enter Xa: ");
double Xa = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Ya: ");
double Ya = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Za: ");
double Za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter coordinates point B: ");
Console.WriteLine("Enter Xb: ");
double Xb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Yb: ");
double Yb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Zb: ");
double Zb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A: ({Xa},{Ya},{Za}), B: ({Xb},{Yb},{Zb})");

double Lenth = Math.Sqrt((Xa-Xb)*(Xa-Xb) + (Ya-Yb)*(Ya-Yb) +
(Za-Zb)*(Za-Zb));
Console.WriteLine($"Lenth AB = {Lenth} ");