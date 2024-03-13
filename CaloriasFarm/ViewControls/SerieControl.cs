using CaloriasFarm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaloriasFarm.ViewControls {
    public partial class SerieControl : UserControl {

        public Serie ModelSerie { get; set; }

        public SerieControl() {
            InitializeComponent();
            ModelSerie = new Serie();
        }

        private void num_Reps_ValueChanged(object sender, EventArgs e) {
            ModelSerie.Reps = (int)num_Reps.Value;
        }

        private void num_Peso_ValueChanged(object sender, EventArgs e) {
            ModelSerie.Peso = (int)num_Peso.Value;
        }

        private void num_Reps_KeyUp(object sender, KeyEventArgs e) {
            ModelSerie.Reps = (int)num_Reps.Value;
        }

        private void num_Peso_KeyUp(object sender, KeyEventArgs e) {
            ModelSerie.Peso = (int)num_Peso.Value;
        }       
    }
}
