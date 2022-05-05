using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lab_07.Droid;
using Xamarin.Forms;
using System.Threading.Tasks;
using ZXing.Mobile;

[assembly: Dependency(typeof(Lab_07.Droid.QrScanImplementation))]
namespace Lab_07.Droid
{
    class QrScanImplementation : IQrScan
    {

        public async Task<string> ScanAsync()
        {
            var optionsDefault = new MobileBarcodeScanningOptions();
            var optionsCustom = new MobileBarcodeScanningOptions();

            var scaner = new MobileBarcodeScanner()
            {
                TopText = "Scan QR Code",
                BottomText = "Please Wait",
            };

            var scanResult = await scaner.Scan(optionsCustom);
            return scanResult.Text;
        }
    }
}