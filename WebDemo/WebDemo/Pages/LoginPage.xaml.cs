namespace WebDemo.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void OnToToolsButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ToolsPage));
    }
}