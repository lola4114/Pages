namespace Pages.Pages;

public partial class NavigationPageDemo2 : ContentPage
{
	public NavigationPageDemo2()
	{
		InitializeComponent();
	}

    private async void openfirstpage(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}