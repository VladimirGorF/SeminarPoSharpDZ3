/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет,
 является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */
/*
void Palindrom()
{
Console.WriteLine ("Please input a five-digit number:");
int x = Convert.ToInt32(Console.ReadLine());
int x1 = x/10000;
int x2 = (x/1000)%10;
int x4 = (x/10)%10;
int x5 = x%10;

if (x1 == x5 && x2 == x4) Console.WriteLine ( "Palindrom"); 
else  Console.WriteLine ( "Usual digit");
}
try 
{
    Palindrom();
}
catch
{
Console.WriteLine ( "you should input five-ditits only");
}
*/
/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/
/*
double Res () 
     {
       Console.WriteLine("Введите координаты точки A (x;у;z) ");
        int Ax=Convert.ToInt32(Console.ReadLine());
        int Ay=Convert.ToInt32(Console.ReadLine());
        int Az=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите координаты точки B (x;у;z) ");
        int Bx=Convert.ToInt32(Console.ReadLine());
        int By=Convert.ToInt32(Console.ReadLine());
        int Bz=Convert.ToInt32(Console.ReadLine());

        int x =Ax-Bx;
        int y = Ay-By;
        int z = Az-Bz;
        double S = Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2)+Math.Pow(z,2));   
        return S;
     }
try
{
    
     Console.WriteLine(Res());
            
}
catch
{
    Console.WriteLine("введите цифры");
}
*/
/*
Задача 23 
Напишите программу, которая принимает на вход число (N)
 и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

try
{
void Cube()
{
Console.WriteLine ("Please input a number");
int n = Convert.ToInt32 (Console.ReadLine());
for (int i = 1; i <= n; i++  ) Console.Write("Cube: "+Math.Pow(i,3)+ ", ");
}
Cube ();
}
catch
{
Console.WriteLine("не порите чужжжжжж");
}
*/

/* Задача необязательная
Напишите программу, которая считывает с консоли числа (по одному в строке)до тех пор, пока сумма введённых чисел не будет равна 0 и сразу
 после этого
  выводит сумму квадратов всех считанных чисел. Гарантируется, что в какой-то момент сумма введённых чисел окажется равной 0, 
после этого считывание продолжать не нужно. В примере мы считываем числа 1, -3, 5, -6, -10, 13; в этот момент замечаем,
 что сумма этих чисел равна нулю и выводим сумму их квадратов, не обращая внимания на то, что остались ещё не прочитанные значения.*/

int SumSquareNumbers ()
{
Console.WriteLine("Please input a number");
int N = Convert.ToInt32(Console.ReadLine());
int Sum = N;
int SumSquare = N*N;

do
{
Console.WriteLine("Please input a number");
N = Convert.ToInt32(Console.ReadLine());
Sum = Sum + N;
SumSquare = SumSquare + N*N;
}
while (Sum !=0);
Console.WriteLine();
return SumSquare;
}

try
{
Console.WriteLine("Sum of squares of all numbers: " + SumSquareNumbers());   
}
catch
{
Console.WriteLine("не порите чужжжжжжжжь");
}
