using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab05
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ButtonCode : ContentPage
    {
        public ButtonCode()
        {
            Label title = new Label
            {
                Text = "ButtonCode",
                FontSize = Device.GetNamedSize(NamedSize.Title, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.Center
            };

            Label label = new Label
            {
                Text = "Click the Button below",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.Center
            };

            Button button = new Button
            {
                Text = "Click to Rotate Text!",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.Center
            };

            button.Clicked += async (sender, args) => await label.RotateTo(360, 2000);

            Content = new StackLayout
            {
                Children =
                {
                    title, 
                    label, 
                    button
                }
            };
        }
    }
}