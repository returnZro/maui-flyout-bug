namespace FlyoutPageSample;

public partial class AppFlyout : FlyoutPage
{
	public AppFlyout()
	{
		InitializeComponent();

		var master = new MasterPage();
		var detail = new DetailPage();
		Flyout = master; // content page
		Detail = new NavigationPage(detail); // navigation page
	}
}