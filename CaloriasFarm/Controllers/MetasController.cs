using CaloriasFarm.Models;
using CaloriasFarm.Utils.Context;
using CaloriasFarm.Utils.Files;
using CaloriasFarm.Utils.ModelHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriasFarm.Controllers
{
    public class MetasController : FormController {
        private ABMObjetos _HistorialHandler { get; set; }
        private List<DiaHistorial> Historial { get; set; }

        public MetasController(Form form, EventHandler<Exception> ErrorHandler, ABMObjetos historialHandler = null) : base(form, ErrorHandler){
            if (historialHandler != null)
                _HistorialHandler = historialHandler;
            else
                _HistorialHandler = new DiaHistorialHandler(new JsonHandler());
        }

        public void IniciarPrograma() {
            try {
                Context.CargarContext();
            }catch (Exception ex) {
                ExceptionHandler.Invoke(this, new Exception("Error al cargar el Context.", ex));
            }

        }

        public bool SetearMetas(Metas metas) {
            try {
                Context.Metas.ActualCalorias = metas.ActualCalorias;
                Context.Metas.TotalCalorias = metas.TotalCalorias;
                Context.Metas.ActualKilos = metas.ActualKilos;
                Context.Metas.TotalKilos = metas.TotalKilos;
                Context.GuardarContext();
            }catch(Exception ex) {
                ExceptionHandler.Invoke(null, new Exception("Error al setear Metas.", ex));
                return false;
            }
            return true;
        }        

        public bool AgregarCalorias(int Calorias, string Causa, DateTime Dia) {
            try {
                Context.Metas.ActualCalorias += Calorias;
                if (Context.Metas.ActualCalorias >= 7700) {
                    Context.Metas.ActualCalorias -= 7700;
                    Context.Metas.ActualKilos++;
                }
                Context.GuardarContext();
                GuardarHistorial(Calorias, Causa, Dia);

            }catch (Exception ex) {
                ExceptionHandler.Invoke(null, new Exception("Error al Actualizar Calorias.", ex));
                return false;
            }
            return true;
        }

        private void GuardarHistorial(int Calorias, string Causa, DateTime Dia) {
            if (Historial == null)
                Historial = (List<DiaHistorial>)_HistorialHandler.Obtener();

            DiaHistorial DiaARegistrar = Historial.FirstOrDefault(h=> h.Dia.ToShortDateString() == Dia.ToShortDateString());
            if (DiaARegistrar == null) {
                DiaARegistrar = new DiaHistorial() {
                    Dia = Dia,
                    CausaYCaloriasList = new Dictionary<string, int>() { { Causa, Calorias } }
                };

                Historial.Add(DiaARegistrar);
            }
            else
                DiaARegistrar.CausaYCaloriasList.Add(Causa, Calorias);

            _HistorialHandler.Guardar(Historial);

        }
    }
}
