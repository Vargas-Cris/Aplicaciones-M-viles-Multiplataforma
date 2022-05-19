using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab09.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TapDemo : ContentPage
    {
        int tapCount;
        readonly Label label;
        public TapDemo()
        {

            InitializeComponent();
            var image = new Image
            {
                Source = "xamarinletter.jpg",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                WidthRequest = 300,
                HeightRequest = 500
            };

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.NumberOfTapsRequired = 2;
            tapGestureRecognizer.Tapped += OnTapGestureRecognizerTapped;
            image.GestureRecognizers.Add(tapGestureRecognizer);


            label = new Label
            {
                Text = "tap the photo!",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
            };

            Content = new StackLayout
            {
                Padding = new Thickness(20),
                Children = { image, label },
            };
        }

        void OnTapGestureRecognizerTapped(object sender, EventArgs e)
        {
            tapCount++;
            label.Text = String.Format("{0} tap{1} so far!", tapCount, tapCount == 1 ? "" : "s");

            var imageSender = (Image)sender;

            if (tapCount % 2 == 0)
            {
                imageSender.Source = "xammarinlogo.png";
            }
            else
            {
                imageSender.Source = "apps.png";
            }
        }
    }
}