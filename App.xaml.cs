namespace Maui_Issue13810;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new Page1());
	}
}
