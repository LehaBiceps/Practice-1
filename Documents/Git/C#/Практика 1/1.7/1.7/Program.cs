using System.Threading.Tasks;

public class Program
{
    static string path = "/Users/aleksej/Documents/Учёба/C#/Практика 1/1.7/task.json";

    public class TaskJson
    {
        public string taskName { get; set; }
        public string taskDescription { get; set; }
        public DateTime taskDate { get; set; }
    }

    static void showTask(List<Task> task)
    {
        foreach (TaskJson info in task)
        {
            Console.WriteLine($"Задача: {info.taskName}\nописание: {info.taskDescription}\nдата: {info.taskDate}\n");
        }
    }

    static void addTask(List<Task> task)
    {
        Console.WriteLine("Введите название задачи: ");
        string name = Console.ReadLine();

        Console.WriteLine("Введите описание задачи: ");
        string description = Console.ReadLine();

        Console.WriteLine("Введите дату окончания: ");
        DateTime time = DateTime.Parse(Console.ReadLine());

        Task add = new Task { taskName = name, Description = description, deadline = deadline };
        task.Add();
        Console.WriteLine("Список обновлён");
    }

    static void deleteTask(List<Task> task)
    {

    }

    static void editTask(List<Task> task)
    {

    }



    public static void Main()
    {
        Console.WriteLine("Привет! Выбери действие: ");
        Console.Write("1 - посмотреть список дел\n2 - добавить задачу\n3 - удалить задачу\n4 - редактировать задачи\nВвод: ");
        int firstСhoice = int.Parse(Console.ReadLine());
        int secondChoice = 0;

        switch (firstСhoice)
        {
            case 1:
                Console.WriteLine("\nВыбрано: посмотреть список дел");
                Console.Write("1 - на сегодня\n2 - на завтра\n3 - неделю\n4 - за всё время\n5 - предстоящие\n6 - выполненные\nВвод: ");
                secondChoice = int.Parse(Console.ReadLine());
                break;
            case 2:
                Console.WriteLine("\nВыбрано: добавить задачу");
                break;
            case 3:
                Console.WriteLine("Выбрано: удалить задачу\n");
                break;
            case 4:
                Console.WriteLine("Выбрано: редактировать задачи\n");
                break;
        }

        switch (secondChoice)
        {
            case 1:
                Console.WriteLine("Выбрано: на сегодня\n");
                break;
            case 2:
                Console.WriteLine("Выбрано: на завтра\n");
                break;
            case 3:
                Console.WriteLine("Выбрано: на неделю\n");
                break;
            case 4:
                Console.WriteLine("Выбрано: за всё время\n");
                break;
            case 5:
                Console.WriteLine("Выбрано: предстоящие\n");
                break;
            case 6:
                Console.WriteLine("Выбрано: выполненные\n");
                break;
        }
    }
}



using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;


using static ConsoleApp1.Program2;


namespace ConsoleApp1;

public class Program2
{
    class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime deadline { get; set; }
    }

   
    static void Main(string[] args)
    {
        Console.WriteLine("Это ваш ежедневник");

        Console.WriteLine("Выберите действие, которое хотите совершить");
        Console.WriteLine("1. Добавить задачу");
        Console.WriteLine("2. Удалить задачу");
        Console.WriteLine("3. Изменить задачу ");
        Console.WriteLine("4. Показать все задачи");
        Console.WriteLine("5. Показать задачи на сегодня");
        Console.WriteLine("6. Показать задачи на завтра");
        Console.WriteLine("7. Показать задачи на неделю");
        Console.WriteLine("8. Показать просроченные задачи");
        Console.WriteLine("9. Показать актульные задачи");
        Console.WriteLine("q - выход из ежедневника");

        string userInput = Console.ReadLine();

        while (userInput != "q")
        {
            switch (userInput)
            {
                case "1":
                    addTask(tasks);
                    break;
                case "2":
                    deleteTask(tasks);
                    break;
                case "3":
                    editTask(tasks);
                    break;
                case "4":
                    showTask(tasks, DateTime.Now);
                    break;
                case "5":
                    showTask(tasks, DateTime.Now.AddDays(1));
                    break;
                case "6":
                    showTask(tasks, DateTime.Now.AddDays(7));
                    break;
                case "8":
                    compliteTask();
                    break;
                case "9":
                    uncompliteTask();
                    break;
            }

            Console.WriteLine("Выберите действие, которое хотите совершить");
            Console.WriteLine("1. Добавить задачу");
            Console.WriteLine("2. Удалить задачу");
            Console.WriteLine("3. Изменить задачу ");
            Console.WriteLine("4. Показать все задачи");
            Console.WriteLine("5. Показать задачи на сегодня");
            Console.WriteLine("6. Показать задачи на завтра");
            Console.WriteLine("7. Показать задачи на неделю");
            Console.WriteLine("8. Показать просроченные задачи");
            Console.WriteLine("9. Показать актульные задачи");
            Console.WriteLine("q - выход из ежедневника");

            userInput = Console.ReadLine();
            saveTask();
        }
    }
    static void addTask(List<Task> tasks)
    {
        Console.WriteLine("Введите название задачи");
        string name = Console.ReadLine();
        Console.WriteLine("Введите описание задачи");
        string description = Console.ReadLine();
        Console.WriteLine("Введите срок задачи");
        Console.WriteLine("Введите день (дд):");
        int day = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите месяц (мм):");
        int month = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите год (гггг):");
        int year = Convert.ToInt32(Console.ReadLine());

        DateTime deadline = new DateTime(year, month, day);

        Task task = new Task { Title = name, Description = description, deadline = deadline };

        tasks.Add(task);
        Console.WriteLine("Задача добавлена");
    }
    static void deleteTask(List<Task> tasks)
    {
        int index = 0;
        foreach (Task task in tasks)
        {
            Console.WriteLine($"номер задачи - {index}, задача на этот день - {task} ");
            index++;
        }

        Console.WriteLine("Введите номер задачи, чтобы удалить его");
        int choose = Convert.ToInt32(Console.ReadLine());
        if (choose >= 0 && choose < tasks.Count)
        {
            tasks.RemoveAt(choose);
            Console.WriteLine("Задача удалена");
        }
        else
        {
            Console.WriteLine("Неверный номер задачи");
        }
    }
    static void editTask(List<Task> tasks)
    {
        int index = 0;
        foreach (Task t in tasks)
        {
            Console.WriteLine($"номер задачи - {index}, задача на этот день - {t.Title} описание {t.Description} ");
            index++;
        }
        Console.WriteLine("Введите номер задачи, чтобы изменить его");
        int choose = Convert.ToInt32(Console.ReadLine());
        if (choose >= 0 && choose < tasks.Count)
        {
            tasks.RemoveAt(choose);
        }
        else
        {
            Console.WriteLine("Неверный номер задачи");
        }

        Console.WriteLine("Введите название задачи");
        string name = Console.ReadLine();
        Console.WriteLine("Введите описание задачи");
        string description = Console.ReadLine();
        Console.WriteLine("Введите срок задачи (дд:мм:гггг)");
        Console.WriteLine("Введите день (дд):");
        int day = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите месяц (мм):");
        int month = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите год (гггг):");
        int year = Convert.ToInt32(Console.ReadLine());

        DateTime deadline = new DateTime(year, month, day);

        var task = new Task { Title = name, Description = description, deadline = deadline };

        tasks.Append(task);
        Console.WriteLine("Задача изменена");
    }
    static void showTask(List<Task> tasks, DateTime time)
    {
        Console.WriteLine("Список задач");
        foreach (Task t in tasks)
        {
            Console.WriteLine($"Название задачи: {t.Title}, описание: {t.Description}, дата: {t.deadline}");
        }
    }

    static void compliteTask()
    {
        Console.WriteLine("Просроченные задачи:");

        DateTime Time = DateTime.Now;

        foreach (Task t in tasks)
        {
            if (t.deadline < Time)
            {
                Console.WriteLine($"Название: {t.Title}, Описание: {t.Description}, Дата завершения: {t.deadline}");
            }
        }
    }
    static void uncompliteTask()
    {
        Console.WriteLine("Актуальные задачи");
        DateTime Time = DateTime.Now;

        foreach (Task t in tasks)
        {
            if (t.deadline > Time)
            {
                Console.WriteLine($"Название: {t.Title}, Описание: {t.Description}, Дата завершения: {t.deadline}");
            }
        }
    }
    static void saveTask()
    {
        File.WriteAllText(jsonFilePath, JsonConvert.SerializeObject(tasks));
    }
}

