namespace MyFirstMauiApp1;

public partial class TestPage3 : ContentPage
{
	public TestPage3()
	{
		InitializeComponent();
		// Referring to labellabel label is allowed in methods, but not in constructor nor class body.
		TurnsOutItMustBeInAnotherMethod();
	}
	
	private void TurnsOutItMustBeInAnotherMethod()
	{
		labelLabel.Text = $"Pixel width: {DeviceDisplay.Current.MainDisplayInfo.Width}";
	}
}