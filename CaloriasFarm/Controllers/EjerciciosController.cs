using CaloriasFarm.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriasFarm.Controllers {
    public class EjerciciosController {
        private EventHandler<Exception> ExceptionHandler;
        public EjerciciosController(EventHandler<Exception> exceptionHanlder) {
            ExceptionHandler += exceptionHanlder;
        }

        public bool GuardarEjercicios() {
            if (Context.Ejercicios == null) {
                ExceptionHandler.Invoke(null, new Exception("Ejercicios no puede ser Nulo al guardar. "));
                return false;
            }

            Context.GuardarContext();

            return true;
        }

    }
}
