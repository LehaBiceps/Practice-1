using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class Program
{
    public class TaskJson
    {
        public string taskName { get; set; }
        public string taskDescription { get; set; }
        public DateTime taskDate { get; set; }
    }

    static string path = "/Users/aleksej/Documents/Учёба/C#/Практика 1/1.7/task.json";
    static List<TaskJson> task = new List<TaskJson>();

    static void addTask(List<TaskJson> task)
    {
        Console.WriteLine("Введите название задачи: ");
        string name = Console.ReadLine();

        Console.WriteLine("Введите описание задачи: ");
        string description = Console.ReadLine();

        Console.WriteLine("Введите дату окончания: ");
        DateTime time = DateTime.Parse(Console.ReadLine());

        TaskJson jsonRecord = new TaskJson() { taskName = name, taskDescription = description, taskDate = time };
        task.Add(jsonRecord);
    }

    //static void deleteTask(List<TaskJson> task)
    //{
    //    int number = 1;

    //    foreach (TaskJson list in task)
    //    {
    //        Console.WriteLine(number + " - " + list);
    //        number++;
    //    }

    //    Console.WriteLine("Введите номер для удаления:");
    //    int choiseDelete = int.Parse(Console.ReadLine());

    //    if (choiseDelete > 0 && choiseDelete < task.Count)
    //    {
    //        task.RemoveAt(choiseDelete);
    //        Console.WriteLine("Задача удалена");
    //    }
    //    else
    //    {
    //        Console.WriteLine("Неверный номер задачи");
    //    }
    //}

    //static void editTask()
    //{

    //}

    static void showTask(List<TaskJson> task)
    {
        foreach (var list in task)
        {
            Console.WriteLine($"Задача: {list.taskName}\tОписание: {list.taskDescription}\tОкончание: {list.taskDate}");
        }
    }

    static void saveTask()
    {
        using (StreamWriter file = File.CreateText(path))
        {
            var serializer = new Newtonsoft.Json.JsonSerializer();
            serializer.Serialize(file, task);
        }
    }

    static void loadTask()
    {
        if (File.Exists(path))
        {
            using (StreamReader file = File.OpenText(path))
            {
                var serializer = new Newtonsoft.Json.JsonSerializer();
                task = (List<TaskJson>)serializer.Deserialize(file, typeof(List<TaskJson>));
            }
        }
    }




    public static void Main()
    {
        loadTask();

        Console.WriteLine("Привет! Выбери действие: ");
        Console.Write("1 - посмотреть список дел\n2 - добавить задачу\n3 - удалить задачу\n4 - редактировать задачи\nВвод: ");
        int firstСhoice = int.Parse(Console.ReadLine());
        int secondChoice = 0;

        switch (firstСhoice)
        {
            case 1:
                Console.WriteLine("\nВыбрано: посмотреть список дел");
                showTask(task);
                secondChoice = int.Parse(Console.ReadLine());
                break;
            case 2:
                Console.WriteLine("\nВыбрано: добавить задачу");
                addTask(task);
                Console.WriteLine("Список обновлён");
                break;
            case 3:
                Console.WriteLine("Выбрано: удалить задачу\n");
                ///
                Console.WriteLine("Список обновлён");
                break;
            case 4:
                Console.WriteLine("Выбрано: редактировать задачи\n");
                ///
                Console.WriteLine("Список обновлён");
                break;
        }

        saveTask();
    }
}


