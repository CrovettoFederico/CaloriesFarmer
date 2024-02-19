using CaloriasFarm.Models;
using CaloriasFarm.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriasFarm.Controllers {
    public class MetasController {

        private EventHandler<Exception> ExceptionHandler;

        public MetasController(EventHandler<Exception> ErrorHandler) {
            ExceptionHandler += ErrorHandler;
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

        public bool ActualizarCalorias(int Calorias) {
            try {
                Context.Metas.ActualCalorias += Calorias;
                if (Context.Metas.ActualCalorias >= 7700) {
                    Context.Metas.ActualCalorias -= 7700;
                    Context.Metas.ActualKilos++;
                }
                Context.GuardarContext();
            }catch (Exception ex) {
                ExceptionHandler.Invoke(null, new Exception("Error al Actualizar Calorias.", ex));
                return false;
            }
            return true;
        }
    }
}
