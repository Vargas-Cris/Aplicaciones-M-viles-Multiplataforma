using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab08
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            item01.Clicked += async (object sender, EventArgs e) =>
            {
                await Navigation.PushAsync(new ExplicitDemo());
            };

            item02.Clicked += async (object sender, EventArgs e) =>
            {
                await Navigation.PushAsync(new ExplicitControlDemo());
            };

            item03.Clicked += async (object sender, EventArgs e) =>
            {
                await Navigation.PushAsync(new ImplicitDemo());
            };

            item04.Clicked += async (object sender, EventArgs e) =>
            {
                await Navigation.PushAsync(new ImplicitControlDemo());
            };

            item05.Clicked += async (object sender, EventArgs e) =>
            {
                await Navigation.PushAsync(new GlobalDemo());
            };

            item06.Clicked += async (object sender, EventArgs e) =>
            {
                await Navigation.PushAsync(new InheritanceDemo());
            };
            item07.Clicked += async (object sender, EventArgs e) =>
            {
                await Navigation.PushAsync(new Examplecss());

            };


        }
    }
}