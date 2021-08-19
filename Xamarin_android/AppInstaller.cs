using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace Xamarin_android
{
    public static class AppInstaller
    {

        public static void OnCreate()
        {
            AppCenter.Start("1f6e1663-642e-4d0f-8e39-aefde8a0817b",
                   typeof(Analytics), typeof(Crashes));
        }
    }

}