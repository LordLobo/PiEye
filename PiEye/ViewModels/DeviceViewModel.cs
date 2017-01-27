using Caliburn.Micro;

namespace PiEye.ViewModels
{
    public class DeviceViewModel : Screen
    {
        public void Test()
        {
            Title.Text = "Clicked! from vm";
        }
    }
}
