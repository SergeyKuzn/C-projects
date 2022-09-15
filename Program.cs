using static System.Console;

// Console.Clear(); 
// Console.Write("Введите число: ");
// int num1=Convert.ToInt32(Console.ReadLine());
// int num2=int.Parse(Console.ReadLine()!);
// int sqr1=num1*num1;
// int sqr2=Convert.ToInt32(Math.Pow(num2,2));
// Console.WriteLine($"Квадрат числа {num1} = {sqr1}");
// Console.WriteLine($"Квадрат числа {num2} = {sqr2}");




// Вывод дня недели

// Clear();
// Write("Введеите число от 1 до 7: ");
// int num1=Convert.ToInt32(ReadLine());
// if (num1==1){
//     WriteLine("monday");}
// if (num1==2){
//     WriteLine("Tuesday");}
// if (num1==3){
//     WriteLine("Wednesday");}
// if (num1==4){
//     WriteLine("Thursday");}
// if (num1==5){
//     WriteLine("Friday");}
// if (num1==6){
//     WriteLine("Saturday");}
// if (num1==7){
//     WriteLine("Sunday");}
// if (num1>7 || num1<1){
//     WriteLine("Такого дня недели не существует!");}


// Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.

// Clear();
// Write("Введеите число: ");
// int num1=Convert.ToInt32(ReadLine());
// int num2=-num1;

// while(num2<=num1)
// {
//     Write($"{num2}");
//     num2++;
// }


// 1. Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает **последнюю** цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8


Clear();
Write("Введеите число: ");
int num1=Convert.ToInt32(ReadLine());

WriteLine(num1%10);
