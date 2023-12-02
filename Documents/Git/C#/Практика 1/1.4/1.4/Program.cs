/*ЗАДАНИЕ 1:

Console.WriteLine("Введите целое число: ");
int n = int.Parse(Console.ReadLine());
int product = 1;

for (int i = 3; i <= n; ++i)
{
    if (i % 3 == 0)
    {
        product *= i;
    }
}
Console.WriteLine(product);
*/






/*ЗАДАНИЕ 2:

string path = "/Users/aleksej/Documents/Учёба/C#/Практика 1/1.4/numsTask2.txt";
string[] numbers = File.ReadAllText(path).Split(';');
float[] nums = new float[numbers.Length];
float sum = 0;

for (int i = 0; i < numbers.Length; ++i)
{
    nums[i] = float.Parse(numbers[i]);

    if (nums[i] > 0)
    {
        sum += nums[i];
    }
}
Console.WriteLine(sum);
*/









/*ЗАДАНИЕ 3:

string path = "/Users/aleksej/Documents/Учёба/C#/Практика 1/1.4/numsTask3.txt";
string[] numbers = File.ReadAllText(path).Split(',');
int[] nums = new int[numbers.Length];
int min = int.Parse(numbers[0]);
int max = min;
for (int i = 0; i < numbers.Length; ++i)
{
    nums[i] = int.Parse(numbers[i]);
    if (min > nums[i])
    {
        min = nums[i];
    }
    if (max < nums[i])
    {
        max = nums[i];
    }
}
Console.WriteLine(min +" < "+ max);
*/













/*ЗАДАНИЕ 4:

string path = "/Users/aleksej/Documents/Учёба/C#/Практика 1/1.4/numsTask4.txt";
string[] numbers = File.ReadAllText(path).Split(' ');
int count = 0;

for (int i = 1; i < numbers.Length; ++i)
{
    if (numbers[i] == numbers[i - 1])
    {
        count++;
    }
}
Console.WriteLine(count);
*/












/*ЗАДАНИЕ 5:

Console.WriteLine("Введите число a: ");
float a = float.Parse(Console.ReadLine());
Console.WriteLine("Введите число b: ");
float b = float.Parse(Console.ReadLine());

int a1 = -1;
int a2 = 3;
int b1 = -2;
int b2 = 4;

if (a >= a1 && a <= a2 && b >= b1 && b <= b2)
{
    Console.WriteLine("Принадлежит");
}
else
{
    Console.WriteLine("Непринадлежит");
}
*/











Console.WriteLine("Введите x: ");
float x = float.Parse(Console.ReadLine());
Console.WriteLine("Введите y: ");
float y = float.Parse(Console.ReadLine());

float s =  Math.Abs((-2 - 0) * (-3 - 2) - (2 - 0) * (-3 - 2));
float s1 = Math.Abs((-2 - 0) * (y - 2) - (x - 0) * (-3 - 2));
float s2 = Math.Abs((x - 0) * (-3 - 2) - (2 - 0) * (y - 2));
float s3 = Math.Abs((-2 - x) * (-3 - y) - (2 - x) * (-3 - y));





