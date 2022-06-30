// Вывести случайное число из отрезка [10, 99] и показывает наибольшую цифру числа
// void randomNumber(int min, int max){
//     int number = new Random().Next(min, max+1);
//     Console.Write(number + "->");
//     if (number / 10 > number % 10)
//         {
//         Console.WriteLine(number / 10);
//         }
//     else
//         {
//         Console.WriteLine(number % 10);
//         }
// }
// Console.WriteLine("Введите минимальное число диапазона: ");
// int start = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное число диапазона: ");
// int end = Convert.ToInt32(Console.ReadLine());
// randomNumber(start,end);

// Вывести сумму двух чисел
// int SumTwoNumbers()
// {
//     Console.WriteLine("Введите первое число: ");
//     int number1 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите второе число: ");
//     int number2 = Convert.ToInt32(Console.ReadLine());
//     int sum = number1 + number2;
//     return sum;
// }
// for (int i=0; i < 3; i++)
// {
//     Console.WriteLine("Сумма двух чисел: "+ SumTwoNumbers());
// }

// Домашнее задание

// Принять на вход трехзначное число и на выходе показать вторую цифру этого числа
// void secondNumber()
//     {
//     Console.Write("Введите трехзначное число: " );
//     int number = Convert.ToInt32(Console.ReadLine());
//     if (number > 99 && number < 1000)
//         {
//         int result = number % 100 / 10;
//         Console.WriteLine(""+ number +" -> "+ result +"");
//         }
//     else Console.WriteLine("Некорректное значение");
//     }
// secondNumber();

// Вывести третью цифру заданного числа или написать что ее нет
// void thirdNumber()
//     {
//     Console.Write("Введите число: " );
//     int number = Convert.ToInt32(Console.ReadLine());
//     Console.Write(""+ number +" -> ");
//     if (number > 99)
//         {
//         while (number / 1000 > 0)
//             {number = number / 10;
//             };
//         int result = number % 10;
//         Console.Write(result);
//         }
//     else Console.Write("третьей цифры нет");
//     }   
// thirdNumber();

// Принть на вход цифру, обозначающую день недели, и проверить является ли день выходным
// void weekend()
//     {
//     Console.Write("Number of day: ");
//     int day = Convert.ToInt32(Console.ReadLine());
//     if (day == 6 || day == 7) 
//         Console.WriteLine(""+ day +" -> yes");
//     else if (day > 0 && day < 6)
//         Console.WriteLine(""+ day +" -> no");
//         else
//          Console.WriteLine("Incorrect number");
//     }
// weekend();