using Lab14.Data;
using Lab14.Interfaces;
using Lab14.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab14.Services
{
    public class Estudiantes : IEstudiante
    {
        public async Task<List<EstudianteModel>> GetListEstudiante()
        {
            using (var estudiantesContext = new EstudianteContext())
            {
                return await estudiantesContext.TbEstudiante.ToListAsync();
            }
        }

        public async Task<EstudianteModel> GetEstudiante(int estudianteId)
        {
            using (var estudiantesContext = new EstudianteContext())
            {
                return await estudiantesContext.TbEstudiante
                    .Where(p => p.EstudianteId == estudianteId).FirstOrDefaultAsync();
            }

        }


        public async Task<bool> InsertEstudiante(EstudianteModel estudianteModel)
        {
            using (var estudiantesContext = new EstudianteContext())
            {
                estudiantesContext.Add(estudianteModel);

                await estudiantesContext.SaveChangesAsync();
            }
            return true;
        }

        public async Task<bool> UpdateEstudiante(EstudianteModel estudianteModel)
        {
            using (var estudiantesContext = new EstudianteContext())
            {
                var tracking = estudiantesContext.Update(estudianteModel);

                await estudiantesContext.SaveChangesAsync();

                var isModified = tracking.State == EntityState.Modified;
                return isModified;
            }
        }

        public async Task<bool> DeleteEstudiante(EstudianteModel estudianteModel)
        {
            using (var estudiantesContext = new EstudianteContext())
            {
                var tracking = estudiantesContext.Remove(estudianteModel);

                await estudiantesContext.SaveChangesAsync();

                var isDeleted = tracking.State == EntityState.Deleted;
                return isDeleted;
            }

        }


        public async Task<bool> DeleteAllEstudiantes()
        {
            using (var estudiantesContext = new EstudianteContext())
            {
                estudiantesContext.RemoveRange(estudiantesContext.TbEstudiante);

                await estudiantesContext.SaveChangesAsync();
            }
            return true;
        }
    }
}
