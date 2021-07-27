using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using AvaloniaUI.ViewModels;
using AvaloniaUI.Views;

namespace AvaloniaUI
{
    public class App : Application
    {
        public App()
        {

        }
        public App(Models.MainModel mainModel)
        {
            MainModel = mainModel;
        }
        public Models.MainModel MainModel;

        public override void Initialize()
        {
           
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow
                {
                    DataContext = new MainWindowViewModel(MainModel),
                };
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}
