using CaloriasFarm.Models;

namespace CaloriasFarm.Utils.Context{

    public interface IContextHandler{
        public List<Ejercicio> GetEjercicios();
        public Metas GetMetas();
        public List<Rutina> GetRutinas();
        public void SaveContext(List<Ejercicio> Ejercicios, Metas metas);
    }

}
