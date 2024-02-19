using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriasFarm.ErrorsHandler
{
    public static class ErrorHandler
    {
        private static string LogPath = Directory.GetCurrentDirectory() + "\\Error.log ";

        public static void OnError(object? sender, Exception ex)
        {
            string BodyMsg = ex.ToString();
            LoguearError(BodyMsg, TiposDeError.Basico);
            MessageBox.Show(ex.Message + "\nRevise el archivo Error.log en el directorio del programa. ", " - Error - \n", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static void LoguearError(string Msj, TiposDeError tipo)
        {
            string Date = "[" + DateTime.Now.ToString() + "]";
            string StrTipoError = "[" + tipo.ToString() + "]";
            string EndOfError = "[ - END OF ERROR - ]";
            
            string Error = "\n" + Date + " - " + StrTipoError + "\n" + Msj + "\n" + EndOfError + "\n";
            File.AppendAllText(LogPath, Error);


        }
    }
}
