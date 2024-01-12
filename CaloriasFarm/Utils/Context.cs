using CaloriasFarm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriasFarm.Utils {
    public static class Context {
        public static List<Ejercicio> Ejercicios { get; private set; }
        public static Metas Metas { get; private set; }

        private static string EjercicioJsonFile = Directory.GetCurrentDirectory() + "\\Ejercicios.json ";
        private static string MetasJsonFile = Directory.GetCurrentDirectory() + "\\Metas.json ";

        public static void CargarContext() {
            Ejercicios = JsonHandler.ReadFile<List<Ejercicio>>(EjercicioJsonFile);
            Metas = JsonHandler.ReadFile<Metas>(MetasJsonFile);
        }

        public static void GuardarContext() {
            JsonHandler.WriteFile<List<Ejercicio>>(EjercicioJsonFile, Ejercicios);
            JsonHandler.WriteFile<Metas>(MetasJsonFile, Metas);
        }

    }
}
