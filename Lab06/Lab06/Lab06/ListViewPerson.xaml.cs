using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace Lab06
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPerson : ContentPage
    {
        ObservableCollection<Person> persons = new ObservableCollection<Person>();
        public ListViewPerson()
        {
            InitializeComponent();
            PersonView.ItemsSource = persons;
            persons.Add(new Person { DisplayName = "Cristhina Vargas" });
            persons.Add(new Person { DisplayName = "Mishell Vargas" });
            persons.Add(new Person { DisplayName = "Dayron Vargas" });

        }
    }
}