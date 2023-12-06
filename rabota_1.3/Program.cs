/*№1
 string[] lines = File.ReadAllLines("input.txt");
string[] luckyN = lines[0].Split(' ');
int bilet = Convert.ToInt32(lines[1]);
StreamWriter writer = new StreamWriter("output.txt", true);
for (int i = 2; i < 2 + bilet; i++)
{
    int a = 0; 
    string[] Nums = lines[i].Split(' ');
    foreach (var n in Nums)
    {
        if (luckyN.Contains(n))
        {
            a++;
        }
    }
    if (a >= 3)
    {
        writer.WriteLine("Lucky");
        Console.WriteLine("Lucky");
    }
    else 
    {
        writer.WriteLine("Unlucky");
        Console.WriteLine("Unlucky");
    }
}

writer.Close();

 */

/*№2
 string[] nums = File.ReadAllLines("nums.txt");
string[] num = nums[0].Split(' ');
List<string> a = new List<string>();
foreach (var n in num)
{
    if (Convert.ToInt32(n) % 2 != 0)
    {
        a.Add(n);
    }
}

string allNums = "";
foreach (var n in a)
{
    allNums += $"{n} ";
}

StreamWriter writer = new StreamWriter("nums.txt", false);
writer.Write(allNums);
writer.Close();*/

/* №3
string[] num = File.ReadAllLines("xxx.txt")[0].Split(',');
int[] height = new int[num.Length]; 
int maxS = 0; 
int a = 0; 
int b = 0; 
for (int i = 0; i < num.Length; i++) 
{ 
    height[i] = Convert.ToInt32(num[i]); 
} 
 
for (int i = 0; i < num.Length; i++) 
{ 
    for (int j = 0; j < num.Length; j++) 
    { 
        int minHeight = 0; 
        if (height[i] < height[j]) 
        { 
            minHeight = height[i]; 
        } 
        else 
        { 
            minHeight = height[j]; 
        } 
 
        int dist; 
        if (i > j) 
        { 
            dist = i - j; 
        } 
        else 
        { 
            dist = j - i; 
        } 
 
        int S = dist * minHeight; 
        if (maxS < S) 
        { 
            maxS = S; 
            a = i + 1; 
            b = j + 1; 
        } 
    } 
} 
 
Console.WriteLine($"{a},{b}"); 
Console.WriteLine($"{maxS} максимальная площадь");*/ 
