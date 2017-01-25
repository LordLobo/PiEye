using Windows.UI.Xaml;

namespace PiEye.Views
{
    public sealed partial class ShellView
    {
        public ShellView()
        {
            InitializeComponent();
        }

        private void OpenNavigationView(object sender, RoutedEventArgs e)
        {
            NavigationView.IsPaneOpen = true;
        }
    }
}

