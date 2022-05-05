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
    public partial class TextToSpeechDemo : ContentPage
    {
        public TextToSpeechDemo()
        {
            InitializeComponent();
            var stack = new StackLayout();

            var speak = new Button
            {
                Text = "Welcome to Lab07!!",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };

            speak.Clicked += (object sender, EventArgs e) =>
            {
                DependencyService.Get<ITextToSpeech>().Speak("Hello Cristhina Vargas!!!");
            };

            stack.Children.Add(speak);

            Content = speak;
        }

    }
}