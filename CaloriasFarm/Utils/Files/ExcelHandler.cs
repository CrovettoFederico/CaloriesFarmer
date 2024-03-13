using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriasFarm.Utils.Files {
    public class ExcelHandler : FileHandler {

        public ExcelHandler() {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        public object ReadFile<T>(string File) {

            ExcelPackage Archivo;
            try {
                FileInfo fileInfo = new FileInfo(File);

                Archivo = new ExcelPackage(fileInfo);
            } catch (Exception e) {
                throw new Exception("No se pudo abrir el Excel.", e);
            }

            return Archivo;
        }

        public void CloseFile(ExcelPackage File) {
            File.Dispose();
        }

        public void WriteFile<T>(string File, T obj) {
            ((ExcelPackage)(object)obj).Save();
        }
    }
}
