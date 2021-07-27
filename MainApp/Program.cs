using Avalonia;
using Avalonia.ReactiveUI;
using AvaloniaUI;
using System;

namespace MainApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            SDKLibrary.MainClass mainClass = new SDKLibrary.MainClass();
            AvaloniaUI.Program.RunUI(mainClass); //Убираем эту строку и пишем свою инициализацию UI
            Console.ReadKey();
        }    
    }
}
