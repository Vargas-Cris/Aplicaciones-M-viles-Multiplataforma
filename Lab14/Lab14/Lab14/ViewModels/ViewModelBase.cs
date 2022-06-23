﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Lab14.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropetyChanged([CallerMemberName] string nombrePropiedad = null)
        {
            var cambio = PropertyChanged;
            if (cambio != null)
            {
                cambio(this, new PropertyChangedEventArgs(nombrePropiedad));
            }
        }
    }
}