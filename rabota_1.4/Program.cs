﻿/* №1
public class MainClass
{
    public static void Main()
    {
        Console.WriteLine("Введите число");
        var n = Convert.ToInt32(Console.ReadLine());
        var mul = 1;
        for (var i = 1; i < n; i++)
        {
            if (i % 3 == 0)
            {
                mul *= i;                
            }
        }
        Console.WriteLine($"{mul}");
    }
}*/
/* №2
public class MainClass
{
    public static void Main()
    {
        string[] nums = File.ReadAllLines("numsTask2.txt");
        string[] num = nums[0].Split(';');
        double sum = 0;
        foreach (var n in num)
        {
            if (Convert.ToDouble(n) == 0)
            {
                break;
            }

            if (Convert.ToDouble(n) > 0)
            {
                sum += Convert.ToDouble(n);
            }
        }

        sum = Math.Round(sum, 1);
        Console.WriteLine($"Сумма чисел: {sum}");
    }
}*/
/* №3
public class Example 
{    public static void Main() 
    {        
        string[] nums = File.ReadAllLines("numsTask3.txt"); 
        string[] num = nums[0].Split(',');      
        int min = 100; 
        int max = -100;        
        foreach (var n in num) 
        {         
            if (Convert.ToInt32(n) == 0) 
            {               
                break; 
            } 
            if (Convert.ToInt32(n) > max)         
            { 
                max = Convert.ToInt32(n);          
            } 
            if (Convert.ToDouble(n) < min) 
            {             
                min = Convert.ToInt32(n); 
            }
        } 
        double a = (double)max / (double)min; 
        Console.WriteLine($"Отношение максимального числа к минимальному: {a}");
        double b = (double)min / (double)max;
        Console.WriteLine($"Отношение минимального числа к максимальному: {b}");
    } 
}*/
/*#4
string[] nums = File.ReadAllLines("numsTask4.txt");
string[] num = nums[0].Split(' ');
int n = 1;
int nv = 1;
for (int i = 1; i < num.Length; i++)
{
    if (num[i] == num[i-1])
    {
        n++;
        if (n > nv)
        {
            nv = n;
        }
    }
    else
    {
        n = 1;
    }

}
Console.WriteLine($"Количество одинаковых рядом стоящих чисел: {nv}");*/
/* №5
Console.WriteLine("Введите числа a и b:");
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double x1 = -1;
double x2 = 3;
double y1 = -2;
double y2 = 4;
if ((x1 < a && a < x2) && (y1 < b && b < y2))
{
    Console.WriteLine("Точка с принадлежит заштрихованной области!");
}
else 
{
    Console.WriteLine("Точка с не принадлежит заштрихованной области!");
}*/





