using Microsoft.Maui.Controls;

namespace ExpenseTrackerApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState activationState)
    {
        // Create a new window and set the initial page to Login
        var window = new Window
        {
            Page = new MainPage() // Or use a Shell-based approach if using AppShell
        };

        return window;
    }
}
