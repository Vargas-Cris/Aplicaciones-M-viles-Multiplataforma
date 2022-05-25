using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab10
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            // Menu buttons
            item1.Clicked += async (object sender, EventArgs e) =>
            {
                await Navigation.PushAsync(new ViewToViewDemo());
            };
            item2.Clicked += async (object sender, EventArgs e) =>
            {
                await Navigation.PushAsync(new BindingModeDemo());
            };
            item3.Clicked += async (object sender, EventArgs e) =>
            {
                await Navigation.PushAsync(new PickerDemo());
            };
            item4.Clicked += async (object sender, EventArgs e) =>
            {
                await Navigation.PushAsync(new ListViewDemo());
            };
        }

    }
}
