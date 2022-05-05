using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab_07
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QRCode : ContentPage
    {
        public QRCode()
        {
            InitializeComponent();
        }

            private async void btnQrCode_Clicked(object sender, EventArgs e)
            {
                try
                {
                    var scanner = DependencyService.Get<IQrScan>();
                    var result = await scanner.ScanAsync();
                    if (result != null)
                    {
                        txtQrCode.Text = result;
                    }
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Error", ex.Message.ToString(), "Ok");
                }
            }
            
        
    }
}