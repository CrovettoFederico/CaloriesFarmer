using CaloriasFarm.Models;
using CaloriasFarm.Utils.Files;
using CaloriasFarm.Utils.ModelHandlers;

namespace CaloriasFarm.Utils.Context{
    /// <summary>
    /// 
    /// </summary>
    public static class Context{
        public static List<Ejercicio> Ejercicios { get; private set; }
        public static Metas Metas { get; private set; }
        public static List<Rutina> Rutinas { get; private set; }

        private static readonly IContextHandler contextHandler = new ContextHandler(
            new EjercicioHandler(new JsonHandler()),
            new MetasHandler(new JsonHandler()),   
            new RutinaGymHandler(new ExcelHandler())
            );

        public static void CargarContext()
        {
            Ejercicios = contextHandler.GetEjercicios();
            Metas = contextHandler.GetMetas();
            Rutinas = contextHandler.GetRutinas();
        }

        public static void GuardarContext()
        {
            contextHandler.SaveContext(Ejercicios, Metas);
        }

    }
}
