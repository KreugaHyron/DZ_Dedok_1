﻿namespace DZ_Dedok_1.Model;

public class TodoItem
{
    public string Task { get; set; }
    public bool IsComplete { get; set; }

    public override string ToString()
    {
        return $"{Task} - {(IsComplete ? "Completed" : "Pending")}";
    }
}
