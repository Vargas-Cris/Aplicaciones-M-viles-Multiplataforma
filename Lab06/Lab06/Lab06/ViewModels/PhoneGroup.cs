using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using Lab06.Models;

namespace Lab06.ViewModels
{
    public class PhoneGroup : ObservableCollection<Phone>
    {
        public string Name { get; private set; }

        public PhoneGroup(string name)
            : base()
        {
            Name = name;
        }

        public PhoneGroup(string name, IEnumerable<Phone> source)
            : base(source)
        {
            Name = name;
        }
    }
}