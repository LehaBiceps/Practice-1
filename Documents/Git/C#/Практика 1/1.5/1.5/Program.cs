﻿/*ЗАДАНИЕ 1:

string path = "/Users/aleksej/Documents/Учёба/C#/Практика 1/1.5/numsTask1.txt";
string[] numbers = File.ReadAllText(path).Split(' ');
int[] nums = new int[numbers.Length];
int min = int.Parse(numbers[0]);
int index = 0;
int result = 1;

for (int i = 0; i < numbers.Length; ++i)
{
    nums[i] = int.Parse(numbers[i]);
    if (min > nums[i])
    {
        min = nums[i];
        index = i;
    }
}

for (int i = index; i < numbers.Length; ++i)
{
    result *= nums[i];
}
Console.WriteLine(result);
*/






/* ЗАДАНИЕ 2:

string path = "/Users/aleksej/Documents/Учёба/C#/Практика 1/1.5/numsTask2.txt";
string[] numbers = File.ReadAllText(path).Split(';');
float[] nums = new float[numbers.Length];

for (int i = 0; i < nums.Length; i++)
{
    nums[i] = float.Parse(numbers[i]);
}

for (int i = 0; i < numbers.Length; i++)
{
    for (int j = 0; j < numbers.Length - i - 1; j++)
    {
        if (nums[j] > nums[j + 1])
        {
            float temp = nums[j];
            nums[j] = nums[j + 1];
            nums[j + 1] = temp;
        }
    }
}

for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine(nums[i]);
}
*/







/*ЗАДАНИЕ 3:

string path = "/Users/aleksej/Documents/Учёба/C#/Практика 1/1.5/numsTask3.txt";
string[] numbers = File.ReadAllText(path).Split(' ');
int[] nums = new int[numbers.Length];
int min = int.Parse(numbers[0]);
int index = 0;
float average = 0;

for (int i = 0; i < numbers.Length; ++i)
{
    nums[i] = int.Parse(numbers[i]);

    if (min > nums[i])
    {
        min = nums[i];
        index = i;
    }
}

for (int i = 0; i < index; ++i)
{
    average += nums[i];
}
average /= index;
Console.WriteLine(average);
*/






/*ЗАДАНИЕ 4:

string path = "/Users/aleksej/Documents/Учёба/C#/Практика 1/1.5/numsTask4.txt";
string[] numbers = File.ReadAllText(path).Split(' ');
int[] nums = new int[numbers.Length];
int max = 0;

for (int i = 0; i < numbers.Length; ++i)
{
    nums[i] = int.Parse(numbers[i]);

    if (max < nums[i])
    {
        max = nums[i];
    }
}

int sum = 0;

for (int i = 0; i < numbers.Length; ++i)
{
    if (nums[i] == max - 1)
    {
        sum += nums[i];
    }
}

Console.WriteLine(sum);
*/








/*
string path = "/Users/aleksej/Documents/Учёба/C#/Практика 1/1.5/numsTask5.txt";
string[] numbers = File.ReadAllText(path).Split(' ');
int[] nums = new int[numbers.Length];
int min = int.Parse(numbers[0]);
int max = min;
int indexMin = 0;
int indexMax = 0;
float average = 0;

for (int i = 0; i < numbers.Length; ++i)
{
    nums[i] = int.Parse(numbers[i]);

    if (min > nums[i])
    {
        min = nums[i];
        indexMin = i;
    }

    if (max < nums[i])
    {
        max = nums[i];
        indexMax = i;
    }
}

for (int i = indexMin + 1; i < indexMax; ++i)
{
    average += nums[i];
}
average /= indexMax - (indexMin + 1);
Console.WriteLine(average);
*/