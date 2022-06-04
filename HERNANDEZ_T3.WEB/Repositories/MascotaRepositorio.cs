using HERNANDEZ_T3.WEB.DB;
using HERNANDEZ_T3.WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HERNANDEZ_T3.WEB.Repositories
{
    public interface IMascotaRepositorio
    {
        Mascota ObtenerMascota(int id);
        List<Mascota> ObtenerMascotas();
        void SaveMascota(Mascota mascota);
    }
    public class MascotaRepositorio : IMascotaRepositorio
    {
        private DbEntities dbEntities;
        public MascotaRepositorio(DbEntities dbEntities)
        {
            this.dbEntities = dbEntities;
        }
        public Mascota ObtenerMascota(int id)
        {
            return dbEntities.Mascotas.First(o => o.MascotaId == id);
        }

        public List<Mascota> ObtenerMascotas()
        {
            return dbEntities.Mascotas.ToList();
        }

        public void SaveMascota(Mascota mascota)
        {
            dbEntities.Mascotas.Add(mascota);
            dbEntities.SaveChanges();
        }
    }
}
