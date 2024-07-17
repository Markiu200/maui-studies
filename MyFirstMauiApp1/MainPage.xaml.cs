namespace MyFirstMauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            // InitializeComponent();
            // "(...) which initializes all the objects defined in the XAML file, connects them all together in parent-child relationships,
            // attaches event handlers defined in code to events set in the XAML file, and sets the resultant tree of objects as the content of the page."
            // https://learn.microsoft.com/en-us/dotnet/maui/xaml/fundamentals/get-started?view=net-maui-8.0

            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
