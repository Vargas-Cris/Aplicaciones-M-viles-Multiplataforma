using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Lab06.Models;
using Lab06.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab06
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GroupingListViewSamplePage : ContentPage
    {
        public ObservableCollection<PhoneGroup> PhonesList { get; set; } = new ObservableCollection<PhoneGroup>();

        public GroupingListViewSamplePage()
        {
            InitializeComponent();

            PhonesList.Add(new PhoneGroup("Apple", new[]{ new Phone
                {
                    Title = "iPhone 6s",
                    Price = 50000
                },
                new Phone
                {
                    Title = "iPhone 7",
                    Price = 38000
                }}));

            PhonesList.Add(new PhoneGroup("Huawei", new[]{ new Phone
                {
                    Title = "Huawei P10",
                    Price = 10000
                },
                new Phone
                {
                    Title = "Huawei Mate 8",
                    Price = 29000
                }}));

            PhonesList.Add(new PhoneGroup("Samsung", new[]{ new Phone
                {
                    Title = "Galaxy S8",
                    Price = 60000
                },
                new Phone
                {
                    Title = "Galaxy S7 Edge",
                    Price = 50000
                }}));

            BindingContext = this;
        }
    }
}