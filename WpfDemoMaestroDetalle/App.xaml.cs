using System.Windows;
using Telerik.Windows.Controls;

namespace WpfDemoMaestroDetalle
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            StyleManager.ApplicationTheme = new VisualStudio2019Theme();
            this.InitializeComponent();
        }
    }
}
