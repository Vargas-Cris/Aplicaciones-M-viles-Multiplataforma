using Lab14.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lab14.Interfaces
{
    public interface IEstudiante
    {
        Task<List<EstudianteModel>> GetListEstudiante();
        Task<EstudianteModel> GetEstudiante(int EstudianteId);
        Task<bool> InsertEstudiante(EstudianteModel estudianteModel);
        Task<bool> UpdateEstudiante(EstudianteModel estudianteModel);
        Task<bool> DeleteEstudiante(EstudianteModel estudianteModel);
        Task<bool> DeleteAllEstudiantes();
    }
}