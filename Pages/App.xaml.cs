using Pages.Pages;

namespace Pages;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new TabbedPageDemo1();
	}

   
}
