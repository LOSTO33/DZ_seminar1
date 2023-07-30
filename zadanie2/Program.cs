// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine("Введите num 1: ");
string strNum1 = Console.ReadLine();
Console.WriteLine ("Enter num2 : ");
string strNum2 = Console.ReadLine();
Console.WriteLine ("Enter num3 : ");
string strNum3 = Console.ReadLine();
int num1 = int.Parse(strNum1);
int num2 = int.Parse(strNum2);
int num3 = int.Parse(strNum3);
int max = 0;
if (num1>num2 && num1>num3)
{max= num1;
}
else
if(num2>num1 && num2>num3)
{
    max= num2;
}
else
if(num3>num2 && num3>num1)
{
    max= num3;
}
Console.WriteLine($"максимальноезначение :{max}");