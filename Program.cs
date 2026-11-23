List<string> tasks = new List<string> { "Код", "Тест", "Код" };
tasks.Add("Отчёт");
tasks.Insert(1, "План");

Console.WriteLine(tasks[0]);
Console.WriteLine(tasks[tasks.Count - 1]);
PrintTasks(tasks);

List<string> emptyTasks = new List<string>();
emptyTasks.Add("Код");
Console.WriteLine($"В emptyTasks элементов: {emptyTasks.Count}, первый: {emptyTasks[0]}");


List<string> removedTasks = new List<string> { "Код", "Тест", "Код" };
Console.WriteLine(removedTasks.Remove("Код"));
PrintTasks(removedTasks);

Console.WriteLine(removedTasks.Remove("Экзамен"));
Console.WriteLine(removedTasks.Count);

removedTasks.RemoveAt(1);
PrintTasks(removedTasks);

List<int> scores = new List<int> { 10, 20, 30 };
scores.RemoveAt(1);
Console.WriteLine($"После RemoveAt(1): {scores[0]} {scores[1]} (Count = {scores.Count})");


List<string> searchableTasks = new List<string> { "Код", "Тест", "Код" };

Console.WriteLine(searchableTasks.Contains("Код"));
Console.WriteLine(searchableTasks.Contains("План"));
Console.WriteLine(searchableTasks.IndexOf("Код"));
Console.WriteLine(searchableTasks.IndexOf("План"));


int index = searchableTasks.IndexOf("Код");

if (index >= 0)
{
    Console.WriteLine($"Первый индекс: {index}");
}
else
{
    Console.WriteLine("Задача не найдена");
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