using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriasFarm.Controllers {
    public abstract class FormController {
        internal EventHandler<Exception> ExceptionHandler { get; set; }
        internal Form _Form { get; set; }

        internal FormController(Form form, EventHandler<Exception> ErrorHandler) {
            _Form = form;
            ExceptionHandler += ErrorHandler;
        }
    }
}
