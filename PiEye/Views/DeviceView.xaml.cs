using Windows.UI.Xaml;

namespace PiEye.Views
{
    public sealed partial class DeviceView
    {
        public DeviceView()
        {
            InitializeComponent();
        }

        private void Test(object sender, RoutedEventArgs e)
        {
            Title.Text = "Cliced";
        }
    }
}