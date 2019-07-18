using System;
using Android.Telephony;
using EstudoXamarin.Droid.Services;
using EstudoXamarin.Services;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceInfo))]
namespace EstudoXamarin.Droid.Services
{
    public class DeviceInfo : IDeviceInfo
    {
        [Obsolete]
        public string GetPhoneNumber()
        {
            var tMgr = (TelephonyManager)Forms.Context.ApplicationContext.GetSystemService(Android.Content.Context.TelephonyService);
            return tMgr.Line1Number;
        }
    }
}
