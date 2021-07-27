using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaUI.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif


            this.FindControl<Avalonia.Controls.Image>("MainImage").PointerPressed += (s, e) =>
            {

                System.Drawing.PointF point = new System.Drawing.PointF((float)(e.GetPosition(e.Source as IControl).X / ((Avalonia.Controls.Image)e.Source).DesiredSize.Width), (float)(e.GetPosition(e.Source as IControl).Y / ((Avalonia.Controls.Image)e.Source).DesiredSize.Height));
                ((ViewModels.MainWindowViewModel)DataContext).OnMaimImageClick(point);
            };
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
