﻿using MauiApp1.ViewModels;

namespace MauiApp1.Views;

public partial class MainPage : ContentPage
{

	public MainPage(MainPageViewModel vm)
	{
		InitializeComponent();
		vm.Navigation = Navigation;
		BindingContext = vm;
	}
}

