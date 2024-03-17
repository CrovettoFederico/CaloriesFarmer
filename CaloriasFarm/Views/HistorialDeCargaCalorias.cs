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
        public HistorialDeCargaCalorias() {

            InitializeComponent();

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e) {
            MessageBox.Show("Dia Elegido: " + e.Start.ToString("dd-MM-yyyy"));
        }
    }
}
