// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine ("Введите число : ");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);
int num1 =1;
while(num1<=num){

if(0 == num1 % 2)
{
    Console.WriteLine(num1);
}
num1= num1+1;}