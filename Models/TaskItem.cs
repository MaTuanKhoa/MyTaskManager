using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiTaskManager.Models;

public partial class TaskItem : ObservableObject
{
    [ObservableProperty]
    private string title;

    [ObservableProperty]
    private bool isCompleted;
}
