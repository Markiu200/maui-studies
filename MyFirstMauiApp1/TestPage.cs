namespace MyFirstMauiApp1;

// This class represents an entire page (so far, I guess). Everything we want to appear on that page must be put here.
public class TestPage : ContentPage
{
    // Like in any other class, we can put fields and properties and stuff outside any method. They will be executed when object is initialized.
    int count = 0;

    // Moved fields declaration outside to be able to get to it in OnClickEvent method.
    Label labelText;
    Label labelText2;
    public Button buttonCounter;

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
        labelText = new Label
        {
            // See documentation on what properties are available.
            // https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/label?view=net-maui-8.0
            Text = "Hello, I'm Jeff!",
            FontSize = 22,
            FontAttributes = FontAttributes.Bold, // Enumeration
            HorizontalOptions = LayoutOptions.Center
        };

        // Add this label into the thing holder. 
        stacklayout.Children.Add(labelText);

        // Create button
        buttonCounter = new Button
        {
            Text = "Press to count {0}",
            HorizontalOptions = LayoutOptions.Center
        };

        // Add this button to list of elements.
        stacklayout.Children.Add(buttonCounter);

        // Action to the button is attached after it's creation.
        // We add to our own EventHandler, but I guess it makes sense, probably there's inherited OnClick method or something.
        buttonCounter.Clicked += OnClickEvent;

        // One more label for verification what is being send as an "sender" (this button that was pressed).
        labelText2 = new Label
        {
            Text = "Sender's text: not pressed yet...",
            FontSize = 16,
            HorizontalOptions = LayoutOptions.Center
        };
        stacklayout.Children.Add(labelText2);

        // Now place the View (containing thing with all the elements) as "what is in this page".
        // At his point, contents of the page, as they are now set, will be visible on screen.
        this.Content = stacklayout;
	}

    private void OnClickEvent(object? sender, EventArgs e)
    {
        count++;
        this.buttonCounter.Text = $"Press to count {count}";
        SemanticScreenReader.Announce(this.buttonCounter.Text);

        // labelText.Text = $"Jeff clicked {count} times!";
        if (sender != null)
        {
            labelText.Text = $"Type of sender: {sender.GetType().FullName}";
            // This is for screen readers, let's them know that this text has changed.
            SemanticScreenReader.Announce(labelText.Text);

            Button? thisButton = sender as Button;
            if (thisButton != null)
            {
                labelText2.Text = $"Sender's text: '{thisButton.Text}'";
                SemanticScreenReader.Announce(labelText2.Text);

            }
        }

    }
}