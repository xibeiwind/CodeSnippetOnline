using Prism.Ioc;
using CodeSnippet.Online.DesktopApp.Views;
using System.Windows;

namespace CodeSnippet.Online.DesktopApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
