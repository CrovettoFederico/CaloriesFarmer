using CaloriasFarm.Models;
using CaloriasFarm.Utils.Files;
using CaloriasFarm.Utils.ModelHandlers;
using OfficeOpenXml;

namespace CaloriasFarm.Utils.Context
{
    public class ContextHandler : IContextHandler{
        private ABMObjetos _EjerciciosHandler;
        private ABMObjetos _MetasHandler;
        private ABMObjetos _RutinaGymHandler;       

        public ContextHandler(ABMObjetos ejerciciosHandler) {
            _EjerciciosHandler = ejerciciosHandler;
        }
       
        public ContextHandler(ABMObjetos ejerciciosHandler, ABMObjetos metasHandler , ABMObjetos rutinaGymHandler) {           
            _EjerciciosHandler = ejerciciosHandler;
            _MetasHandler = metasHandler;
            _RutinaGymHandler = rutinaGymHandler;
        }

        public List<Ejercicio> GetEjercicios(){
            return (List<Ejercicio>)_EjerciciosHandler.Obtener();
        }

        public Metas GetMetas(){
            return (Metas)_MetasHandler.Obtener();
        }

        public List<Rutina> GetRutinas() {            
           return (List<Rutina>)_RutinaGymHandler.Obtener();     
        }

        public void SaveContext(List<Ejercicio> Ejercicios, Metas metas){
            _EjerciciosHandler.Guardar(Ejercicios);
            _MetasHandler.Guardar(metas);
        }
    }
}
