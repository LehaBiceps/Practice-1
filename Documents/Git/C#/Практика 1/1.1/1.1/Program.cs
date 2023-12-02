/*ЗАДАНИЕ 1:

Random rnd = new Random();
int[] numbers = new int[10];
int min = 0;

for (int i = 0; i < numbers.Length; ++i)
{
    numbers[i] = rnd.Next(-100, 100);
    Console.WriteLine(numbers[i]);

    if (numbers[i] < numbers[min])
    {
        min = i;
    }
}
Console.WriteLine("Номер минимального элемента: " + min);
*/




/*ЗАДАНИЕ 2:

List<float> numbers = new List<float>();
Console.WriteLine("Вводите элементы (введите 0 для завершения): ");

do
{
    float input = float.Parse(Console.ReadLine());

    if (input == 0)
    {
        break;
    }
    numbers.Add(input);
}while(true);

float sum = 0;
float product = 1;

foreach (int num in numbers)
{
    sum += num;
    product *= num;
}
float average = sum / numbers.Count;
Console.WriteLine($"\nСумма: {sum} \nПроизведение: {product} \nСреднее: {average} \n");
*/




/*ЗАДАНИЕ 3:

List<string> words = new List<string>();
Console.WriteLine("Вводите слова (введите пустую строку для завершения): ");

do
{
    string input = Console.ReadLine();

    if (string.IsNullOrEmpty(input))
    {
        break;
    }
    words.Add(input);
}while(true);

string min = null;
string max = null;

foreach (string word in words)
{
    if (min == null || word.Length < min.Length)
    {
        min = word;
    }
    else if (max == null || word.Length > max.Length)
    {
        max = word;
    }
}
Console.WriteLine($"Самое короткое слово: {min}\t Самое длинное слово: {max}");
*/






/*ЗАДАНИЕ 4: 

static int[] random(int size, int start, int end)
{
    Random rnd = new Random();
    int[] numbers = new int[size];

    for (int i = 0; i < numbers.Length; ++i)
    {
        numbers[i] = rnd.Next(start, end);
    }
    return numbers;
}

Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("Введите начальное число диапозона: ");
int start = int.Parse(Console.ReadLine());
Console.WriteLine("Введите конечное число диапозона: ");
int end = int.Parse(Console.ReadLine());

foreach (int num in random(size, start, end))
{
    Console.Write(num + " ");
}
*/





/* ЗАДАНИЕ 5:

List<string> words = new List<string>();
Console.WriteLine("Вводите слова (пустая строка для завершения):\n\nStart:\n ");

do
{
    string input = Console.ReadLine();

    if (string.IsNullOrEmpty(input))
    {
        Console.WriteLine("end.");
        break;
    }
    words.Add(input);
} while (true);

int score = 0;

for (int i = 0; i < words.Count; ++i)
{
    score++;
}
Console.WriteLine($"\nКоличество слов: {score}");
*/