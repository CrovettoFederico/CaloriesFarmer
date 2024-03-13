using CaloriasFarm.Models;
using CaloriasFarm.Utils.Files;
using OfficeOpenXml;
using OfficeOpenXml.Table.PivotTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriasFarm.Utils.ModelHandlers
{
    public class RutinaGymHandler : ABMObjetosDesdeArchivo, IDisposable {
        private ExcelPackage Archivo;
        private readonly string RutinaGymFile = Directory.GetCurrentDirectory() + "\\RutinaGym.xlsx";
        private readonly int FilasEntreEjercicios = 3;
        private readonly string SeparadorDeSemana = "-";
        private readonly string Abecedario = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private readonly string ColumnaPtsGym = "J";
        internal override FileHandler _FileHandler { get; set; }

        public RutinaGymHandler(FileHandler fileHandler = null) {
            if (fileHandler != null)
                _FileHandler = fileHandler;
            else
                _FileHandler = new ExcelHandler();


            Archivo = (ExcelPackage)_FileHandler.ReadFile<ExcelPackage>(RutinaGymFile);
        }

        public void Dispose() {
            if (Archivo != null) Archivo.Dispose();
        }

        public override object Obtener(){
            List<Rutina> Rutinas = new List<Rutina>();
            foreach(TiposDeRutina Tipo in Enum.GetValues(typeof(TiposDeRutina))){

                var Hoja = Archivo.Workbook.Worksheets[Tipo.ToString()];
                int Fila = FilasEntreEjercicios;
                Rutina RutinaActual = new Rutina();
                RutinaActual.TipoDeRutina = Tipo;

                while (true) {
                    try {
                        string Ejercicio = Hoja.Cells["A" + Fila].Value.ToString();
                        if (!string.IsNullOrEmpty(Ejercicio)) {
                            RutinaActual.EjerciciosGym.Add(Ejercicio);
                            Fila += FilasEntreEjercicios;
                        } else
                            break;
                    } catch {
                        break;
                    }
                }

                Rutinas.Add(RutinaActual);
            }
            return Rutinas;
        }

        public override void Guardar(object DiaDeGym) {
            DiaDeGym DiaACargar = DiaDeGym as DiaDeGym;
            if (Archivo == null)
                throw new Exception("El Archivo Excel no esta correctamente cargado");

            ExcelWorksheet HojaActual = CopiarHojaPlantilla(DiaACargar);
            EscribirNuevaHoja(HojaActual, DiaACargar.EjerciciosGym);

            Archivo.Save();
        }

        private ExcelWorksheet CopiarHojaPlantilla(DiaDeGym DiaACargar) {
            if(DiaACargar.Semana== 0) 
                DiaACargar.Semana = BuscarUltimaSemana(DiaACargar.Rutina.TipoDeRutina.ToString()) + 1;   
            
            string NombreNuevaHoja = DiaACargar.Rutina.TipoDeRutina.ToString() + "-" + DiaACargar.Semana;

            Archivo.Workbook.Worksheets.Copy(DiaACargar.Rutina.TipoDeRutina.ToString(), NombreNuevaHoja);
            return Archivo.Workbook.Worksheets[NombreNuevaHoja];
        }

        private int BuscarUltimaSemana(string NombreHoja) {
            int UltimaSemana = 0;
            foreach (ExcelWorksheet Hoja in Archivo.Workbook.Worksheets) {
                if (Hoja.Name.Contains(SeparadorDeSemana) && Hoja.Name.Contains(NombreHoja)) {
                    int SemanaActual = int.Parse(Hoja.Name.Split(SeparadorDeSemana)[1]);
                    if (SemanaActual > UltimaSemana)
                        UltimaSemana = SemanaActual;
                }
            }
            return UltimaSemana;
        }
              
        private string BuscarLetra(int Index) {
            return Abecedario.Substring(Index, 1);
        }
    
        private void EscribirNuevaHoja(ExcelWorksheet HojaActual, List<EjercicioGym> ejercicios) {
            
            int FilaEjercicio = FilasEntreEjercicios;

            ejercicios.ForEach(ejercicio => {
                int SerieNro = 1;
                ejercicio.Series.ForEach(serie => {
                    string Columna = BuscarLetra(SerieNro);
                    HojaActual.Cells[Columna + (FilaEjercicio - 1).ToString()].Value = serie.Reps;
                    HojaActual.Cells[Columna + FilaEjercicio.ToString()].Value = serie.Peso;
                    SerieNro++;
                });
                HojaActual.Cells[ColumnaPtsGym + FilaEjercicio.ToString()].Value = ejercicio.PuntosGym;

                FilaEjercicio += FilasEntreEjercicios;
            });
        }
    }
}
