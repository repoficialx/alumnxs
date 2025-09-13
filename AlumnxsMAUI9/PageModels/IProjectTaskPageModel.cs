using AlumnxsMAUI9.Models;
using CommunityToolkit.Mvvm.Input;

namespace AlumnxsMAUI9.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}