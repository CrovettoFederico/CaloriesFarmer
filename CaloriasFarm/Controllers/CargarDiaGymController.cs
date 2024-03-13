using CaloriasFarm.Models;
using CaloriasFarm.Utils.Files;
using CaloriasFarm.Utils.ModelHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CaloriasFarm.Controllers {
    public class CargarDiaGymController : FormController {
        new CargarDiaDeGym _Form;
        private ABMObjetosDesdeArchivo _RutinaGymHandler;

        public CargarDiaGymController(CargarDiaDeGym form, EventHandler<Exception> ErrorHandler, ABMObjetosDesdeArchivo RutinaGymHandler = null) {
            _Form = form;
            ExceptionHandler += ErrorHandler;
            if (RutinaGymHandler != null)
                _RutinaGymHandler = RutinaGymHandler;
            else
                _RutinaGymHandler = new RutinaGymHandler();
        }

        public bool GuardarDiaDeGym() {
            try {
                DiaDeGym DiaACargar = new DiaDeGym() { Rutina = _Form._Rutina, Semana = int.Parse(_Form.stripTxt_Semana.Text) };


                foreach (EjercicioControl c in _Form.panel_Ejercicios.Controls) {
                    EjercicioGym EjercicioGym = new EjercicioGym();
                    EjercicioGym.Nombre = c.lbl_EjercicioName.Text;
                    c.Series.ForEach(Serie => {
                        EjercicioGym.Series.Add(new Models.Serie() {
                            Reps = Serie.ModelSerie.Reps,
                            Peso = Serie.ModelSerie.Peso
                        });
                    });
                    DiaACargar.EjerciciosGym.Add(EjercicioGym);
                }
                _RutinaGymHandler.Guardar(DiaACargar);
                return true;
            } catch(Exception ex) {
                ExceptionHandler.Invoke(this, new Exception("Error al guardar el dia de Gimnasio", ex));
                return false;
            }
        }
    }
}
