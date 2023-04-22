namespace Pages.Pages;

public partial class NewPage : ContentPage
{
	public NewPage()
	{
		InitializeComponent();
	}

    private void openNewPage1(object sender, EventArgs e)
    {
		Navigation.PushModalAsync(new NewPage1());
    }
}