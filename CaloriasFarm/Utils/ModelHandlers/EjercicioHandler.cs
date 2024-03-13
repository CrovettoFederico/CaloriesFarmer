using CaloriasFarm.Models;
using CaloriasFarm.Utils.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriasFarm.Utils.ModelHandlers
{
    public class EjercicioHandler : ABMObjetosDesdeArchivo {
        internal override FileHandler _FileHandler { get; set; }

        private static string EjercicioJsonFile = Directory.GetCurrentDirectory() + "\\Ejercicios.json";

        public EjercicioHandler(FileHandler ejercicioHandler) {            
                _FileHandler = ejercicioHandler;
        }

        public override void Guardar(object Ejercicio) {
            _FileHandler.WriteFile(EjercicioJsonFile, (List<Ejercicio>)Ejercicio);
        }
        public override object Obtener() {
            return _FileHandler.ReadFile<List<Ejercicio>>(EjercicioJsonFile);
        }
    }
}
