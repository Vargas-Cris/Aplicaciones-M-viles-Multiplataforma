using Lab14.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Essentials;

namespace Lab14.Data
{
    public class EstudianteContext : DbContext
    {
        public DbSet<EstudianteModel> TbEstudiante { get; set; }

        public EstudianteContext()
        {
            /*Necesario para iniciar sqlite en iOS*/
            SQLitePCL.Batteries_V2.Init();
            this.Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "Estudiante.db3");
            optionsBuilder.UseSqlite($"Filename={dbPath}");
        }
    }
}