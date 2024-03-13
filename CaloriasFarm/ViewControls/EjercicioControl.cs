using CaloriasFarm.ViewControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaloriasFarm {
    public partial class EjercicioControl : UserControl {

        public List<SerieControl> Series = new List<SerieControl>();
        private int EspacioEntreSeries = 10;

        public EjercicioControl(string EjercicioName) {
            InitializeComponent();
            Series.Add(this.Serie_1);
            this.lbl_EjercicioName.Text = EjercicioName;
        }

        private void but_mas_Click(object sender, EventArgs e) {
            AgregarEspacioParaSerie();
        }

        private void AgregarEspacioParaSerie() {
            var newSerie = new SerieControl();
            Size MargenHaciaDerecha = new Size(newSerie.Size.Width + EspacioEntreSeries, 0);
            newSerie.Location = Point.Add(this.Series.Last().Location, MargenHaciaDerecha);
            this.but_mas.Location = Point.Add(this.but_mas.Location, MargenHaciaDerecha);
            this.panel_Contenedor.Controls.Add(newSerie);
            Series.Add(newSerie);
        }
    }
}
