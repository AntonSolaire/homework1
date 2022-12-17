// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


// int Number (int num)
// {
//     int sot = num/10 % 10;
//     return sot;
// }

// int randomNumber = new Random().Next(100,1000);
// Console.WriteLine(randomNumber);
// int result = Number(randomNumber);
// Console.WriteLine(result);




// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


// void ThirdNumber (int num1)
// {

//     while (num1>999){
//         num1=num1/10;
//     }

//     if (num1<100){
//         Console.WriteLine ($" У {num1} нет третьей цифры ");
//     }
//     else {
//         if (num1>100 && num1<1000){
//         int sot = num1%10;
//         Console.WriteLine ($"Третья цифра в числе это {sot}");
//         }
//     }
// }

// Console.WriteLine ("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine ());
// ThirdNumber(num1);


// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет



void weekend (int num)
{
    if (num > 7) {
        Console.WriteLine("Такого дня недели нет");
    }
    else {
    if (num < 6)
    {
        Console.WriteLine("Это не выходной");
    }
    else
        Console.WriteLine("Это выходной");
    }
}
Console.WriteLine("Введите цифру, обозначающую день недели");
int num = Convert.ToInt32(Console.ReadLine());

weekend(num);