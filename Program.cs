// List<string> tasks = new List<string> { "Код", "Тест", "Код" };
// tasks.Add("Отчёт");
// tasks.Insert(1, "План");

// Console.WriteLine(tasks[0]);
// Console.WriteLine(tasks[tasks.Count - 1]);
// PrintTasks(tasks);

// List<string> emptyTasks = new List<string>();
// emptyTasks.Add("Код");
// Console.WriteLine($"В emptyTasks элементов: {emptyTasks.Count}, первый: {emptyTasks[0]}");


// List<string> removedTasks = new List<string> { "Код", "Тест", "Код" };
// Console.WriteLine(removedTasks.Remove("Код"));
// PrintTasks(removedTasks);

// Console.WriteLine(removedTasks.Remove("Экзамен"));
// Console.WriteLine(removedTasks.Count);

// removedTasks.RemoveAt(1);
// PrintTasks(removedTasks);

// List<int> scores = new List<int> { 10, 20, 30 };
// scores.RemoveAt(1);
// Console.WriteLine($"После RemoveAt(1): {scores[0]} {scores[1]} (Count = {scores.Count})");


// List<string> searchableTasks = new List<string> { "Код", "Тест", "Код" };

// Console.WriteLine(searchableTasks.Contains("Код"));
// Console.WriteLine(searchableTasks.Contains("План"));
// Console.WriteLine(searchableTasks.IndexOf("Код"));
// Console.WriteLine(searchableTasks.IndexOf("План"));


// int index = searchableTasks.IndexOf("Код");

// if (index >= 0)
// {
//     Console.WriteLine($"Первый индекс: {index}");
// }
// else
// {
//     Console.WriteLine("Задача не найдена");
// }



Console.Write("Сколько задач добавить сначала: ");
int count = int.Parse(Console.ReadLine()!);

List<string> tasks = new List<string>();

for (int i = 0; i < count; i++)
{
    Console.Write($"Задача {i + 1}: ");
    string title = Console.ReadLine()!;
    tasks.Add(title);
}


Console.WriteLine();
PrintTasks(tasks);
Console.WriteLine();


Console.Write("Введите новую задачу для добавления в конец: ");
string newTask = Console.ReadLine()!;
tasks.Add(newTask);
Console.WriteLine("Задача добавлена");
Console.WriteLine();


Console.Write("Введите задачу для вставки: ");
string insertTitle = Console.ReadLine()!;
Console.Write("Введите индекс вставки: ");
int insertIndex = int.Parse(Console.ReadLine()!);

if (InsertTaskSafe(tasks, insertIndex, insertTitle))
{
    Console.WriteLine("Задача вставлена");
}
else
{
    Console.WriteLine("Недопустимый индекс вставки");
}
Console.WriteLine();

Console.Write("Введите название задачи для удаления: ");
string removeTitle = Console.ReadLine()!;

if (tasks.Remove(removeTitle))
{
    Console.WriteLine("Первое совпадение удалено");
}
else
{
    Console.WriteLine("Задача не найдена");
}
Console.WriteLine();


Console.Write("Введите индекс задачи для удаления: ");
int removeIndex = int.Parse(Console.ReadLine()!);

if (RemoveTaskAtSafe(tasks, removeIndex))
{
    Console.WriteLine("Задача по индексу удалена");
}
else
{
    Console.WriteLine("Недопустимый индекс удаления");
}
Console.WriteLine();


Console.Write("Введите название задачи для поиска: ");
string searchTitle = Console.ReadLine()!;
int foundIndex = tasks.IndexOf(searchTitle);

if (foundIndex >= 0)
{
    Console.WriteLine($"Первый индекс: {foundIndex}");
}
else
{
    Console.WriteLine("Задача не найдена");
}
Console.WriteLine();


Console.WriteLine(">>> Итоговый список дел <<<");
Console.WriteLine();
Console.WriteLine($"Количество задач: {tasks.Count}");
PrintTasks(tasks);


Console.WriteLine();
Console.Write("Введите название задачи для подсчёта совпадений: ");
string countTitle = Console.ReadLine()!;
Console.WriteLine($"Количество совпадений: {CountTask(tasks, countTitle)}");

int CountTask(List<string> tasks, string title)
{
    int count = 0;

    foreach (string task in tasks)
    {
        if (task == title)
        {
            count++;
        }
    }

    return count;
}


bool InsertTaskSafe(List<string> tasks, int index, string title)
{
    if (index < 0 || index > tasks.Count)
    {
        return false;
    }

    tasks.Insert(index, title);
    return true;
}

void PrintTasks(List<string> tasks)
{
    if (tasks.Count == 0)
    {
        Console.WriteLine("Список пуст");
        return;
    }

    for (int i = 0; i < tasks.Count; i++)
    {
        Console.WriteLine($"{i}: {tasks[i]}");
    }
}

bool RemoveTaskAtSafe(List<string> tasks, int index)
{
    if (index < 0 || index >= tasks.Count)
    {
        return false;
    }

    tasks.RemoveAt(index);
    return true;
}