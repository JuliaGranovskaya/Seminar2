// Вывести случайное число из отрезка [10, 99] и показывает наибольшую цифру числа
void randomNumber(){
    int number = new Random().Next(10, 100);
    Console.Write(number + "->");
    if (number / 10 > number % 10)
        {
        Console.WriteLine(number / 10);
        }
    else
        {
        Console.WriteLine(number % 10);
        }
}
randomNumber();