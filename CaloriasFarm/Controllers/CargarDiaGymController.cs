using CaloriasFarm.Models;
using CaloriasFarm.Utils.Files;
using CaloriasFarm.Utils.ModelHandlers;

namespace CaloriasFarm.Controllers {
    public class CargarDiaGymController : FormController {

        // Como hago para no tener que pisarlo aca, y que igual me lo tome?
        // O es al pedo tener Form en el abstract? 
        new CargarDiaDeGym _Form;
        private ABMObjetos _RutinaGymHandler;

        // Quien tiene la responsabilidad de saber cual es el Handler (O Modelo) ??
        // La vista deberia crear el objeto RutinaGymHandler, o el controller se encarga de eso?
        // Si lo hace la vista, porque la vista conoce el modelo?
        // Si lo hace el controller no respeto la inversion de dependencia
        // siendo yo el cliente del modelo, deberia respetar la inversion de dependencia?
        // La vista es el cliente del controller. El controller el cliente del modelo. 
        public CargarDiaGymController(CargarDiaDeGym form, EventHandler<Exception> ErrorHandler, ABMObjetos? RutinaGymHandler = null) : base(form, ErrorHandler) {
            _Form = form;
            if (RutinaGymHandler != null)
                _RutinaGymHandler = RutinaGymHandler;
            else
                _RutinaGymHandler = new RutinaGymHandler(new ExcelHandler());
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
