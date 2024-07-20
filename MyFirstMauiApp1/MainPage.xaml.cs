
namespace MyFirstMauiApp1
{
    public partial class MainPage : ContentPage
    {
        // Defining constant in C# file (to be used as "Global Markup Value")
        // Constants are in PascalCase (by the way).
        public const double ConstSize = 100;
        public const double SecondConstSize = 200;

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

    // For Global Markup Values this is the naming convention "Global<thitThing>Extension, and it must inherit from IMarkupExtension.
    public class GlobalConstSizeExtension : IMarkupExtension
    {
        // You do not need to use "serviceProvider"
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return MainPage.ConstSize;
        }
    }
    public class GlobalSecondConstSizeExtension : IMarkupExtension
    {
        // You do not need to use "serviceProvider"
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return MainPage.SecondConstSize;
        }
    }
}
