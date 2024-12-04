using DZ_Dedok_1.Model;

namespace DZ_Dedok_1.Controller;

public class TodoController
{
    private List<TodoItem> _tasks;

    public TodoController()
    {
        _tasks = new List<TodoItem>();
    }

    public void AddTask(string task)
    {
        if (!string.IsNullOrWhiteSpace(task))
        {
            _tasks.Add(new TodoItem { Task = task, IsComplete = false });
        }
    }

    public void MarkTaskAsCompleted(int index)
    {
        if (index >= 0 && index < _tasks.Count)
        {
            _tasks[index].IsComplete = true;
        }
    }
    public void DeleteTask(int index)
    {
        if (index >= 0 && index < _tasks.Count)
        {
            _tasks.RemoveAt(index);
        }
    }
    public List<TodoItem> GetTasks()
    {
        return _tasks;
    }
}