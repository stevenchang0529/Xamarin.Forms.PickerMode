using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
namespace Xamarin.Forms.PickerMode
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            On<iOS>().SetUseSafeArea(true);
            picker.On<iOS>().SetUpdateMode(UpdateMode.WhenFinished);
        }
    }
}
