﻿namespace Maui_Issue13810;

public partial class Page1 : ContentPage
{
	public Page1()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e) 
	{
		await Navigation.PushAsync(new Page2(), false);
    }
}

