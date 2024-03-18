using CaloriasFarm.Models;
using CaloriasFarm.Utils.Context;
using CaloriasFarm.Utils.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriasFarm.Utils.ModelHandlers
{
    public class MetasHandler : ABMObjetosDesdeArchivo{
        internal override FileHandler _FileHandler { get; set; }

        public MetasHandler(FileHandler fileHandler) {
            _FileHandler = fileHandler;
        }

        private readonly string MetasJsonFile = Directory.GetCurrentDirectory() + "\\Metas.json";

        public override object Obtener()
        {
            return _FileHandler.ReadFile<Metas>(MetasJsonFile)!;
        }

        public override void Guardar(object Metas) {
            _FileHandler.WriteFile(MetasJsonFile, (Metas)Metas);
        }

    }
}
