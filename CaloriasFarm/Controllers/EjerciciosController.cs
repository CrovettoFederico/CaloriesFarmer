using CaloriasFarm.Utils.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriasFarm.Controllers
{
    public class EjerciciosController : FormController {
        public EjerciciosController(Form form, EventHandler<Exception> ErrorHandler) : base(form, ErrorHandler) {            
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
