// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1



int Number (int num)
{
    int sot = num/10 % 10;
    return sot;
}


int randomNumber = new Random().Next(100,1000);
Console.WriteLine(randomNumber);
int result = Number(randomNumber);
Console.WriteLine(result);

