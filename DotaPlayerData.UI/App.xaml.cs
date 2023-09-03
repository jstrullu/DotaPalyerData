namespace DotaPlayerData.UI;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new MainPage();
    }

    protected override Window CreateWindow(IActivationState activationState)
    {
        var window = base.CreateWindow(activationState);

        window.Height = 900;
        window.Width = 1500;
        window.X = 50;
        window.Y = 50;

        return window;
    }
}