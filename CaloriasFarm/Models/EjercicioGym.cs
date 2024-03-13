using CaloriasFarm.ViewControls;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriasFarm.Models {
    public class EjercicioGym {
        public string Nombre { get; set; }
        public List<Serie> Series { get; set; }
        public int PuntosGym { get {
                int _PuntosGym = 0;
                foreach (Serie serie in Series) {
                    _PuntosGym += (serie.Reps * serie.Peso);
                }
                return _PuntosGym;
            }
        }

        public EjercicioGym() {
            Series = new List<Serie>();
        }
    }
}
