using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.ReactiveUI;
using System;

namespace AvaloniaUI
{
   public class Program
    {
        // Initialization code. Don't use any Avalonia, third-party APIs or any
        // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
        // yet and stuff might break.
        public static void Main(string[] args) => BuildAvaloniaApp()
            .StartWithClassicDesktopLifetime(args);

        // Avalonia configuration, don't remove; also used by visual designer.
        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>(() => new App(null))
                .UsePlatformDetect()
                .LogToTrace()
                .UseReactiveUI();

        public static AppBuilder BuildAvaloniaApp(SDKLibrary.MainClass mainClass)
       => AppBuilder.Configure<App>(() => new App(new Models.MainModel(mainClass)))
           .UsePlatformDetect()
           .LogToTrace()
           .UseReactiveUI();

        public static void RunUI(SDKLibrary.MainClass mainClass)
        {
     


            BuildAvaloniaApp(mainClass) .Start<Views.MainWindow> ( ) ;
     


        }
    }
}
