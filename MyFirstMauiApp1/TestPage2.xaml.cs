namespace MyFirstMauiApp1;

public partial class TestPage2 : ContentPage
{
    int count = 0;

    public TestPage2()
	{
		// This reads XAML file and generates C# code basing on that. It will initialize all elements, classes 'n' stuff from there.
		InitializeComponent();
        //
        // Using XAML is not required, however it helps to visualize how are element nested, see the entire structure. 
        // Connecting XAML with C# is done by using InitializeComponent and x:<tag> tags in XAML. For example,
        // x:Name="CounetBtn" makes C# know, that that element will be referred to as "CounterBtn" in C# code.
        //
        // Do your XAML file first, then write C# code later, otherwise compiler will get confused and will throm errors
        // that won't go away until you restart Visual Studio.
	}

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"{count} Kasmok";
        else if (count < 5)
            CounterBtn.Text = $"{count} Kasmoki";
        else
            CounterBtn.Text = $"{count} Kasmoków";


        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}