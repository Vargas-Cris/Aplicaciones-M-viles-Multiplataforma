using Lab14.Models;
using Lab14.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab14.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        MainViewModel Vm { get { return BindingContext as MainViewModel; } }

        public async void UpdateRow_Tapped(object sender, EventArgs e)
        {
            var contenedor = ((Frame)sender).GestureRecognizers[0];

            EstudianteModel estudianteModel = ((TapGestureRecognizer)contenedor).CommandParameter as EstudianteModel;


            string Nombres = await DisplayPromptAsync("Nombres", estudianteModel.EstudianteNombres);
            string Descripcion = await DisplayPromptAsync("Descripción", estudianteModel.EstudianteDescripcion);


            estudianteModel.EstudianteNombres = Nombres;
            estudianteModel.EstudianteDescripcion = Descripcion;

            Vm.UpdateRowCommand.Execute(estudianteModel);

        }

        private async void DeleteRow_Swiped(object sender, SwipedEventArgs e)
        {

            bool resultado = await DisplayAlert("Eliminar", "¿Seguro que desea eliminar el registro?", "Si", "No");

            if (resultado)
            {
                var contenedor = ((Frame)sender).GestureRecognizers[0];

                EstudianteModel estudianteModel = ((TapGestureRecognizer)contenedor).CommandParameter as EstudianteModel;

                Vm.DeleteRowCommand.Execute(estudianteModel);
            }

        }


    }
}