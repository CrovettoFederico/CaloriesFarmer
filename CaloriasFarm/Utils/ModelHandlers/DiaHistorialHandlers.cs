using CaloriasFarm.Models;
using CaloriasFarm.Utils.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriasFarm.Utils.ModelHandlers {
    internal class DiaHistorialHandlers : ABMObjetosDesdeArchivo {
        internal override FileHandler _FileHandler { get; set; }
        private readonly string JsonFilePath = Directory.GetCurrentDirectory() + "\\Historial.json";

        public DiaHistorialHandlers(FileHandler fileHandler) {
            _FileHandler = fileHandler;
        }

        public override void Guardar(object historial) {
            _FileHandler.WriteFile(JsonFilePath, (List<DiaHistorial>)historial);
        }

        public override object Obtener() {
            return _FileHandler.ReadFile<List<DiaHistorial>>(JsonFilePath)!;
        }
    }
}
