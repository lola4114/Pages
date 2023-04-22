namespace Pages.Pages;

public partial class NavigationPageDemo : ContentPage
{
	public NavigationPageDemo()
	{
		InitializeComponent();

	}

    private void opensecondpage(object sender, EventArgs e)
    {
		var navigation = new NavigationPage(new NavigationPageDemo2());
		Navigation.PushAsync(navigation);
    }
}