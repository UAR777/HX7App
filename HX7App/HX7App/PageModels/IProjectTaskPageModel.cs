using CommunityToolkit.Mvvm.Input;
using HX7App.Models;

namespace HX7App.PageModels;

public interface IProjectTaskPageModel
{
	IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
	bool IsBusy { get; }
}