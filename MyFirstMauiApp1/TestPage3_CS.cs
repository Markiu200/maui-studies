namespace MyFirstMauiApp1;

public class TestPage3_CS : ContentPage
{
	public TestPage3_CS()
	{
        var scrollView = new ScrollView();
        // UPDATE: Turns out you can set it as "Thickness", just like so:
        var stacklayout = new VerticalStackLayout {
            Margin = new Thickness(20, 20, 20, 20),
            Padding = 10,
            HeightRequest = 500,
            // Platform specific background settings implementation. 
            // To cover more platforms, "if else" constructions could be used.
            BackgroundColor = DeviceInfo.Platform == DevicePlatform.Android ? Colors.Beige : Colors.Green
        };
        scrollView.Content = stacklayout;

        Grid grid = new Grid
		{
			RowDefinitions =
			{
				new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },
                new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) }
            },
			ColumnDefinitions =
			{
				new ColumnDefinition { Width = new GridLength(200) },
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
            }
		};
		grid.Add(new BoxView { Color = Colors.CornflowerBlue, CornerRadius = 10, HeightRequest = 100, WidthRequest = 180 }, 0, 0);  // column, row
        grid.Add(new BoxView { Color = Colors.IndianRed, CornerRadius = 10, HeightRequest = 150, WidthRequest = 100 }, 1, 0);
        grid.Add(new BoxView { Color = Colors.PaleGoldenrod, CornerRadius = 10, HeightRequest = 100, WidthRequest = 200 }, 0, 1);
        grid.Add(new BoxView { Color = Colors.DarkViolet, CornerRadius = 10, HeightRequest = 100, WidthRequest = 100 }, 1, 1);
        grid.Add(new BoxView { Color = Colors.Indigo, CornerRadius = 10, HeightRequest = 100, WidthRequest = 200 }, 0, 2);
        grid.Add(new BoxView { Color = Colors.Firebrick, CornerRadius = 10, HeightRequest = 100, WidthRequest = 100 }, 1, 2);

        Label label = new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Layout but C#" };

		stacklayout.Children.Add(label);
		stacklayout.Children.Add(grid);
        this.Content = stacklayout;
    }
	
}