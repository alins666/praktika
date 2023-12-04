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

string[] height  = File.ReadAllLines("nnn.txt");
string[] num = height [0].Split(' ');
int max = Convert.ToInt32(0);
int min = Convert.ToInt32(0);
for (int i = 1; i < num.Length; i++) // столбцы 
{
    for (int j = i+1; j < num.Length; j++) //деления  
    {
        if (height[i] > height[j])
        {
            max =  
        }
  