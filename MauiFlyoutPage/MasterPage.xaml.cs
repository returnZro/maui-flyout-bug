namespace FlyoutPageSample;

public partial class MasterPage : ContentPage
{
	public MasterPage()
	{
		InitializeComponent();
	}

	private void Button_OnClicked(object sender, EventArgs e)
	{
		Application.Current?.MainPage?.Navigation.PopAsync();
	}
}