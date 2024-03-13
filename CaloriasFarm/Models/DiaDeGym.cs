using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriasFarm.Models {
    public class DiaDeGym {
        public Rutina Rutina { get; set; }
        //public Dictionary<string, int> EjercicioYPtsGym { get; set; }
        public List<EjercicioGym> EjerciciosGym { get; set; }
        public DiaDeGym() {
            EjerciciosGym = new List<EjercicioGym>();
        }
        public int Semana { get; set; }

    }
}
