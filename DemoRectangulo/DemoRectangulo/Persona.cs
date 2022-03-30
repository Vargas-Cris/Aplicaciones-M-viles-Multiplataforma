using System;
using System.Collections.Generic;
using System.Text;

namespace DemoRectangulo
{
    class Persona
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }


        public string DevolverNombresCompletos()
        {
            return string.Concat(Nombres, " ", Apellidos);
        }
    }
}
