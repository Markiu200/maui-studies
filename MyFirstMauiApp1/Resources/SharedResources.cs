namespace MyFirstMauiApp1.Resources
{
    // Concept behind this (in course) is to have XAML Global Markup Variable, but to have it decoupled from any of the controls / pages.
    // Now instead of defining that in MainPage, we have individual C# class as resource.
    // Class doesn't need to be called "SharedResources", neither does it have to be in "Resources" folder, but that would make sense to put it there.
    internal static class SharedResources
    {
        public static readonly Color FntColor = Colors.Firebrick;
    }
}
