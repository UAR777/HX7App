using HX7App.Models;
using HX7App.PageModels;

namespace HX7App.Pages;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageModel model)
	{
		InitializeComponent();
		BindingContext = model;
	}
}