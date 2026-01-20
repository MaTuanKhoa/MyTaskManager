using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiTaskManager.Models;
using System.Collections.ObjectModel;

namespace MauiTaskManager.ViewModels;

public partial class TasksViewModel : ObservableObject
{
    public TasksViewModel()
    {
        Tasks = new ObservableCollection<TaskItem>();
        Tasks.CollectionChanged += (_, __) => UpdateCounts();
    }

    [ObservableProperty]
    private string newTaskTitle;

    [ObservableProperty]
    private TaskItem selectedTask;

    public ObservableCollection<TaskItem> Tasks { get; }

    [ObservableProperty]
    private int totalCount;

    [ObservableProperty]
    private int completedCount;

    [RelayCommand]
    private void AddTask()
    {
        if (string.IsNullOrWhiteSpace(NewTaskTitle))
            return;

        var task = new TaskItem { Title = NewTaskTitle };
        task.PropertyChanged += (_, __) => UpdateCounts();

        Tasks.Add(task);
        NewTaskTitle = string.Empty;
        UpdateCounts();
    }

    private void UpdateCounts()
    {
        TotalCount = Tasks.Count;
        CompletedCount = Tasks.Count(t => t.IsCompleted);
    }
}
