using CaloriasFarm.Controllers;
using CaloriasFarm.ErrorsHandler;
using CaloriasFarm.ViewControls;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaloriasFarm.Views {
    public partial class HistorialDeCargaCalorias : Form {
        HistorialDeCargaCaloriasController Controller { get; set; }

        private readonly int CalendarWidth = 290;

        public HistorialDeCargaCalorias() {
            InitializeComponent();
            this.Controller = new HistorialDeCargaCaloriasController(this, ErrorHandler.OnError);
            Historial_Total.lbl_Causa.Text = "Total: ";
            Historial_Total.lbl_Calorias.Text = string.Empty;
            CargarDiaHistorial(Calendar_Historial.SelectionStart);
        }

        private void CargarDiaHistorial(DateTime Dia) {
            string Diastr = Dia.ToString("dddd dd-MM-yyyy");
            lbl_TituloDiaHistorial.Text = Diastr.Substring(0, 1).ToUpper() + Diastr.Substring(1);

            var diaHistorial = Controller.ObtenerDia(Dia);
            panel_ContenedorHistorial.Controls.Clear();
            int TotalCalorias = 0;
            foreach (var item in diaHistorial.CausaYCaloriasList) {
                TotalCalorias += item.Value;

                var ItemHistorial = new ItemHistorialControl();
                ItemHistorial.lbl_Causa.Text = item.Key.ToString();
                ItemHistorial.lbl_Calorias.Text = item.Value.ToString();
                ItemHistorial.Location = new Point(0, panel_ContenedorHistorial.Controls.Count * ItemHistorial.Size.Height);

                panel_ContenedorHistorial.Controls.Add(ItemHistorial);
            }
            Historial_Total.lbl_Calorias.Text = TotalCalorias.ToString();
        }

        private void Calendar_Historial_DateChanged(object sender, DateRangeEventArgs e) {
            CargarDiaHistorial(e.Start);
        }

        private void ReposicionarTituloDia(Label TituloCambiado) {
            var OffSetIzquierdoDesdeForm = CalendarWidth + Calendar_Historial.Location.X;
            var AnchoTotalDisponible = this.ClientSize.Width - OffSetIzquierdoDesdeForm;
            var AnchoLbl = TituloCambiado.Size.Width;
            var Margen = (AnchoTotalDisponible - AnchoLbl) / 2;
            lbl_TituloDiaHistorial.Location = new Point(OffSetIzquierdoDesdeForm + Margen, TituloCambiado.Location.Y);


        }

        private void lbl_TituloDiaHistorial_SizeChanged(object sender, EventArgs e) {
            ReposicionarTituloDia((Label)sender);
        }
    }
}
