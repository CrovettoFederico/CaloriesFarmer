using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriasFarm.Utils.Files {
     public abstract class ABMObjetosDesdeArchivo : ABMObjetos {
        internal abstract FileHandler _FileHandler { get; set;}

        public abstract void Guardar(object ObjetoAGuardar);
        public abstract object Obtener();
    }
}
