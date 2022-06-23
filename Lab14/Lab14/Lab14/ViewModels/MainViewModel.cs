using Lab14.Services; //=BL
using Lab14.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Lab14.ViewModels;

namespace Lab14.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        Estudiantes estudiantes = new Estudiantes(); // viene del BL = Services


        private ObservableCollection<EstudianteModel> listEstudiantes;
        public ObservableCollection<EstudianteModel> ListEstudiantes
        {
            get { return listEstudiantes; }
            set { listEstudiantes= value; RaisePropetyChanged(); }
        }



        private string nombres;
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; RaisePropetyChanged(); }
        }

        private string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; RaisePropetyChanged(); }
        }


        public ICommand InsertRowCommand { get; set; }
        public ICommand UpdateRowCommand { get; set; }
        public ICommand DeleteRowCommand { get; set; }
        public ICommand DeleteAllRowCommand { get; set; }

        public MainViewModel()
        {

            DeleteRowCommand = new Command<EstudianteModel>(execute: async (estudianteModel) => {
                await estudiantes.DeleteEstudiante(estudianteModel);
                LoadListEstudiantes();
            });

            DeleteAllRowCommand = new Command(execute: async () => {
                await estudiantes.DeleteAllEstudiantes();
                LoadListEstudiantes();
            });

            UpdateRowCommand = new Command<EstudianteModel>(execute: async (estudianteModel) => {
                await estudiantes.UpdateEstudiante(estudianteModel);
                LoadListEstudiantes();
            });

            InsertRowCommand = new Command(execute: async () => {

                await estudiantes.InsertEstudiante(new EstudianteModel() { EstudianteNombres = Nombres, EstudianteDescripcion = Descripcion });
                Nombres = "";
                Descripcion = "";
                LoadListEstudiantes();
            });

            LoadListEstudiantes();
        }
        async void LoadListEstudiantes()
        {

            ListEstudiantes = new ObservableCollection<EstudianteModel>(await estudiantes.GetListEstudiante());
        }

    }
}