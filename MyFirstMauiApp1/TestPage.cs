namespace MyFirstMauiApp1;

// This class represents an entire page (so far, I guess). Everything we want to appear on that page must be put here.
public class TestPage : ContentPage
{
	// Like in any other class, we can put fields and properties and stuff outside any method. They will be executed when object is initialized.

	public TestPage()
	{
        // Turns out we want to initialize entire page in constructor (as Trevoir suggests in his course).

        // ScrollView is a container that handles scrolling up and down. In MSDN it's referenced as a "View".
        // https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/scrollview?view=net-maui-8.0
		// 
        var scrollView = new ScrollView();

        // I believe it's something like .grid in Python's Tkinter. There are number of Stack(..) classes, which would probably correspond 
        // to difference between ".grid" and "pack" and "place". I guess anyway...
        // In MSDN called per "Layout".
        // https://learn.microsoft.com/en-us/dotnet/maui/user-interface/layouts/?view=net-maui-8.0
        var stacklayout = new StackLayout();

        // Put the "how to arrange things" bit into "how do you view them" bit.
        scrollView.Content = stacklayout;

        // Create a label. I am going to assume that label will be used for absolutely everything, like in TKinter, I call it now.
        // Trevoir says that it is a good practice to prefix variable name with what class it is, so it's easier to recognize it later.
        // It's fields will be initialized using object initializer syntax.
        Label LabelText = new Label
        {
            // See documentation on what properties are available.
            // https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/label?view=net-maui-8.0
            Text = "Hello, I'm Jeff!",
            FontSize = 22,
            FontAttributes = FontAttributes.Bold, // Enumeration
            HorizontalOptions = LayoutOptions.Center
        };

        // Add this label into the thing holder. 
        stacklayout.Children.Add(LabelText);

        // Now place the View (containing thing with all the elements) as "what is in this page".
        // At his point, contents of the page, as they are now set, will be visible on screen.
        this.Content = stacklayout;
	}
}