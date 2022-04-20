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
    public partial class LabelCode : ContentPage
    {
        public LabelCode()
        {

            InitializeComponent();

            StackLayout stack = new StackLayout();
            var underlineLabel = new Label
            {
                Text = "This is underlined text.",
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            var strikethroughLabel = new Label
            {
                Text = "This is text with strikethrough.",
                TextDecorations = TextDecorations.Strikethrough,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            var bothLabel = new Label
            {
                Text = "This is underlined text with strikethrough.",
                TextDecorations = TextDecorations.Strikethrough | TextDecorations.Underline,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            var sampleLabel = new Label
            {
                Text = "Este es simple",
                BackgroundColor = Color.Red,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Padding = new Thickness(50)
            };

            stack.Children.Add(underlineLabel);
            stack.Children.Add(strikethroughLabel);
            stack.Children.Add(bothLabel);
            stack.Children.Add(sampleLabel);

            Content = stack;
        }
    }
}