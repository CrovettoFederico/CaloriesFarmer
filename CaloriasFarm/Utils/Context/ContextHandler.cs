using CaloriasFarm.Models;
using CaloriasFarm.Utils.Files;
using CaloriasFarm.Utils.ModelHandlers;
using OfficeOpenXml;

namespace CaloriasFarm.Utils.Context
{

    /*
    public class GEjercicios {
        public bool habilitado;
        public string name;
    }

    public interface IRepository<T> {
        T unvalor();
        T primervalor();
        T ultimovalor();
        List<T> filtrar();
    }

    public class ContextSetup<T> {
        public List<T> StatesChanges;
    }

    public class GSet<T> : IRepository<T> {
        private readonly ContextSetup<T> _conn;
        public GSet(ContextSetup<T> setup) {
            _conn = setup;
            _conn.StatesChanges = new List<T>();
        }

        public List<T> filtrar() {
            throw new NotImplementedException();
        }

        public T primervalor() {
            T = new T();
            _conn.StatesChanges.Add(T);
            return T;
        }

        public T ultimovalor() {
            throw new NotImplementedException();
        }

        public T unvalor() {
            throw new NotImplementedException();
        }
    }

    public class JsonContext : IDisposable {
        public GSet<GEjercicios> ejercicios;

        public void Dispose() {
            throw new NotImplementedException();
        }

        public void save() {
            // Como valido lo que cambio?

        }
    }

    public void main() {
        using (GContext db = new GContext()) {
            GEjercicios e = db.ejercicios.primervalor();
            e.name = "Correr";
            db.save();
        }
    }*/

    public class ContextHandler : IContextHandler{
        private ABMObjetos _EjerciciosHandler;
        private ABMObjetos _MetasHandler;
        private ABMObjetos _RutinaGymHandler;
        // private ABObjetos<Exerice> Ejercicios;

        public ContextHandler(ABMObjetos ejeh) {
            _EjerciciosHandler = ejeh;
        }
       

        /*
        public ContextHandler(ABMObjetos ejerciciosHandler = null, ABMObjetos metasHandler = null, ABMObjetos rutinaGymHandler = null) {
            if (ejerciciosHandler != null)
                _EjerciciosHandler = ejerciciosHandler;
            else
                _EjerciciosHandler = new EjercicioHandler();

            if (metasHandler != null)
                _MetasHandler = metasHandler;
            else
                _MetasHandler = new MetasHandler();

            if (rutinaGymHandler != null)
                _RutinaGymHandler = rutinaGymHandler;
            else
                _RutinaGymHandler = new RutinaGymHandler();
        }
        */

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
