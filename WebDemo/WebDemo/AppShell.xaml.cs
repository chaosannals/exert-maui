namespace WebDemo;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(Pages.LoginPage), typeof(Pages.LoginPage));
		Routing.RegisterRoute(nameof(Pages.ToolsPage), typeof(Pages.ToolsPage));
    }
}
