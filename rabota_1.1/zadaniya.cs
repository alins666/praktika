/*№1
int [] Array = new int[10];
Random rand = new Random();
for (int i = 0; i<10; i++)
{
    Array[i] = rand.Next(-100,100);
    Console.Write(Array[i] + " ");
}
  
int minElem = 100;
int minEmI = 0;
for (int i = 0; i<10; i++)
{
    if (Array[i] < minElem) minElem = Array[i];
    if (Array[i] < minEmI) minEmI = i;
}
Console.WriteLine($"\n {minEmI}");
*/

/*№2
List<int> nums = new List<int>();
Console.WriteLine("Введите числа (для завершения введите 0)");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int m = 1;
while (num != 0)
{
    nums.Add(num);
    sum += num;
    m *= num;
    
    num = Convert.ToInt32(Console.ReadLine());
}
int avg = sum / nums.Count;
Console.WriteLine(sum);
Console.WriteLine(m);
Console.WriteLine(avg);*/

/*№3
List<string> s = new List<string>(); 
Console.WriteLine("Введите слова (для завершения введите Enter)"); 
string str = Console.ReadLine(); 
string korotkoe = str; 
string dlinoe = str; 
 
while (str != "") 
{ 
    s.Add(str); 
    if (str.Length < korotkoe.Length) 
    { 
        korotkoe = str; 
    } 
    if (str.Length > dlinoe.Length) 
    { 
        dlinoe = str; 
    }
    str = Console.ReadLine(); 
} 
Console.WriteLine($"Самый короткий элемент: {korotkoe}");
Console.WriteLine($"Самый длинный элемент: {dlinoe}");*/

/*№4
namespace ConsoleApp1;

public class Program 
{
    static int[] Filled(int a, int b)
    {
        int[] arr = new int[10];
        Random rand = new Random();
        for (int i = 0; i < arr.Length; i++) 
        {
            arr[i] = rand.Next(a, b);
        }
        return arr;
    }
    static void Main()
    {
        int[] filledArray = Filled(0, 100);
        for (int i = 0; i < filledArray.Length; i++) 
        {
            Console.Write($"{filledArray[i]} ");
        }
    }
}
*/

/*№5
Console.WriteLine("Введите текст: "); 
string str = Console.ReadLine(); 
int probel = 1; 
foreach (char sym in str) 
{ 
 if (sym == ' ') probel++; 
} 
Console.WriteLine(probel); 
Console.WriteLine($"Start {str} End");
*/

