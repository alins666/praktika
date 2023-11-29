/* №1
 using System.Collections;
namespace ConsoleApp1;
public class Program 
{
    static void Main()
    {
        List<int> nums = new List<int>(100);
        int a = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < 100; i++)
        {
            nums.Add(a);
            a -= 3;
        }

        for (int i = 0; i < 100; i++)
        {
            Console.Write($"{nums[i]} ");
        }
    }
} */
/* №2 
namespace ConsoleApp1;
public class Program 
{
    static void Main()
    {
        int[] array = new int[100];
        int a = 1;
        for (int i = 0; i < 100; i++)
        {
            array[i] = a;
            a += 2;
        }

        for (int i = 0; i < 100; i++)
        {
            Console.Write($"{array[i]} ");
        }
    }
} */
/* №3
using System.Collections;
namespace ConsoleApp1;
public class Program
{
    static void Main()
    {
        Console.WriteLine("Введите размер матрицы: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            array[0, i] = 1;
            array[i, 0] = 1;
        }
        for (int i = 1; i < n; i++)
        {
            for (int j = 1; j < n; j++)
            {
                array[i, j] = array[i - 1, j] + array[i, j - 1];
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
} */


static int[] Avgtemperature(int[,] temperature)
{
    int[] Avgtemper = new int [12];
    int avg = 0;
    for (int i = 0; i < 12; i++)
    {
        for (int j = 0; j < 30; j++)
        {
            avg += temperature[i, j];
        }

        Avgtemper[i] = avg / 30;
        avg = 0;
    }

    return Avgtemper;
}

int[,] temperature = new int[12, 30];
int min = -20 ;
int max = 20;
Random rand = new Random();
for (int i = 0; i < 12; i++)
{ 
    for (int j = 0; j < 30; j++)
    {
        temperature[i, j] = rand.Next(min, max);
    }

    if (i<6)
    {
        min += 3;
    }

    else if (i>6)
    {
        max += 3;
    }
}
for (int i = 0; i < 12; i++)
{
    Console.WriteLine($"Месяц №{i}");
    for (int j = 0; j < 30; j++)
    {
        Console.Write($"{temperature[i, j]} ");
    }
    
    
    Console.WriteLine();
}