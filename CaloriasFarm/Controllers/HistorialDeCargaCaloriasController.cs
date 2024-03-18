using CaloriasFarm.Models;
using CaloriasFarm.Utils.Files;
using CaloriasFarm.Utils.ModelHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CaloriasFarm.Controllers {
    public class HistorialDeCargaCaloriasController : FormController {

        private ABMObjetos _HistorialHandler { get; set; }
        private List<DiaHistorial> Historial { get; set; }

        public HistorialDeCargaCaloriasController(Form form, EventHandler<Exception> ErrorHandler, ABMObjetos? historialHandler = null) : base(form, ErrorHandler){
            if(historialHandler != null)
                _HistorialHandler = historialHandler;
                else
            _HistorialHandler = new DiaHistorialHandlers(new JsonHandler());

            Historial = (List<DiaHistorial>)_HistorialHandler.Obtener();
        }

        public DiaHistorial ObtenerDia(DateTime Fecha) {
            DiaHistorial dia = Historial.FirstOrDefault(h => h.Dia.ToShortDateString() == Fecha.ToShortDateString())!;
            if (dia == null)
                dia = new DiaHistorial() {CausaYCaloriasList = new Dictionary<string, int>() };
            return dia;
        }
        

    }
}
