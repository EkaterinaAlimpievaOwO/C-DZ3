// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите число:");
// int number = int.Parse(Console.ReadLine());
// int reverse_number = 0;
// int variable = number;

// while (variable != 0)
// {
//     reverse_number = reverse_number * 10 + variable % 10;
//     variable = variable / 10;
// }

// if(reverse_number == number)
//     Console.WriteLine("Да");
// else
//     Console.WriteLine("Нет");



//------------------------------------>


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние
// между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// using PointNs;

// Point a = new Point();
// Point b = new Point();
// Console.WriteLine("Введите Х координату точки А");
// a.x = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите Y координату точки А");
// a.y = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите Z координату точки А");
// a.z = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите Х координату точки B");
// b.x = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите Y координату точки B");
// b.y = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите Z координату точки B");
// b.z = int.Parse(Console.ReadLine());

// Console.WriteLine(CalculateDistance(a, b));



// double CalculateDistance(Point a, Point b)
// {
//     return Math.Sqrt((b.x - a.x) * (b.x - a.x) + (b.y - a.y) * (b.y - a.y) + (b.z - a.z) * (b.z - a.z));
// }


//------------------------------------>



// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// Console.WriteLine("Введите число");
// int number = int.Parse(Console.ReadLine());

// for(int i = 1; i <= number; i++){
//     Console.Write(Cube(i) + " ");
// }


// int Cube(int variable){
//     return variable * variable * variable;
// }


//------------------------------------>