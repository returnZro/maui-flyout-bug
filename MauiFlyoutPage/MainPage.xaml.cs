namespace FlyoutPageSample;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnPushClicked(object sender, EventArgs e)
	{
		var flyoutPage = new AppFlyout();
		Application.Current?.MainPage?.Navigation.PushAsync(flyoutPage);
	}
}

