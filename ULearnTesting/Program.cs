//Ex.1
/*int a = 10;
int b = 20;
Console.WriteLine("Первоначальное значение:");
Console.WriteLine($"Первое число - {a} | Второе число - {b}");

int c = 0;
c = a;
a = b;
b = c;

Console.WriteLine("Инверсия:");
Console.WriteLine($"Первое число - {a} | Второе число - {b}");*/
//-----------------------------------------------------------------
//Ex. 2
/*
int enter = 892;
int firstNum = enter / 100;
int secondNum = (enter % 100)/10;
int thirdNum = enter % 10;
int result = (thirdNum * 100) + (secondNum * 10) + firstNum;
Console.WriteLine(result);
*/
//-----------------------------------------------------------------
//Ex. 3
/*
int enter = Convert.ToInt32(Console.ReadLine());
int grad = 0;
if (enter > 0 && enter < 12)
{
    grad = enter * 30;   
    Console.WriteLine($"Время по часам - {enter}, градусов от минутной до часовой стрелки - {grad}");
}
else if (enter == 12 || enter == 24)
{
    grad = 0;
    Console.WriteLine($"Время по часам - {enter}, градусов от минутной до часовой стрелки - {grad}");
}
else if (enter > 12 && enter < 24)
{
    grad = (enter * 30) - 360;
    Console.WriteLine($"Время по часам - {enter}, градусов от минутной до часовой стрелки - {grad}");
}
else
{
    Console.WriteLine("Введите корректное время!");
}
*/
//--------------------------------------------------------------------------------------------------------
//Ex.4
/*int N = int.Parse(Console.ReadLine());
int x, y, g;
x = 6;
y = 2;
g = 0;
for (int i = 1; i < N; i++)
{
    if (i % x == 0 && i % y == 0)
    {
        Console.WriteLine(i);
        g++;
    }
}
Console.WriteLine(g);*/
//-----------------------------------------------
//Ex. 5 Простой калькулятор/использование делегатов!

/*
Calculation calculation = new Calculation();
Messege? calculat;
calculat = calculation.CalcSum;
calculat += calculation.CalcSubtract;
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
calculat(x, y);
calculat -= calculation.CalcSubtract;
if (calculat != null) calculat(x, y);

delegate void Messege(int x, int y);


public class Calculation
{
    public void CalcSum(int a, int b) =>  Console.WriteLine(a + b);
    public void CalcSubtract(int a, int b) => Console.WriteLine(a - b);
}
*/
int a = 10;
int b = 20;

