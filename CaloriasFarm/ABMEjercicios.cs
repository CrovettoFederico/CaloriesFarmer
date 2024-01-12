using CaloriasFarm.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaloriasFarm.Models;

namespace CaloriasFarm {
    public partial class ABMEjercicios : Form {
        public ABMEjercicios() {
            InitializeComponent();
            Ejercicios_Grid.DataSource = new BindingList<Ejercicio>(Context.Ejercicios);
        }

        private void Guardar_Btn_Click(object sender, EventArgs e) {
            Context.GuardarContext();
            MessageBox.Show("Ejercicios Guardados");
        }
    }
}
