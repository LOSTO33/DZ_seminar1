// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine ("Введите число : ");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);
int num1 =1;
if(0 == num % 2)
{
    Console.WriteLine("Является четным");
}
else 
{
    Console.WriteLine("Не является четным");
}