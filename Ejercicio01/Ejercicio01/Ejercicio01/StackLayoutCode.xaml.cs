using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StackLayoutCode : ContentPage
    {
        public StackLayoutCode()
        {
            InitializeComponent();
            var layout = new StackLayout();
            var button = new Button
            {
                Text = "StackLayout",
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };
            var yellowBox = new BoxView
            {
                Color = Color.Yellow,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };
            var greenBox = new BoxView
            {
                Color = Color.Green,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };
            var blueBox = new BoxView
            {
                Color = Color.Blue,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };
            layout.Children.Add(button);
            layout.Children.Add(yellowBox);
            layout.Children.Add(greenBox);
            layout.Children.Add(blueBox);
            layout.Spacing = 10;
            Content = layout;
        }
    }
}