using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Lab14.Models
{
    public class EstudianteModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EstudianteId { get; set; }
        public string EstudianteNombres { get; set; }
        public string EstudianteDescripcion { get; set; }
    }
}