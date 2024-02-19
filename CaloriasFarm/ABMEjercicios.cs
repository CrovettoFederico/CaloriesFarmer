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
using CaloriasFarm.Controllers;

namespace CaloriasFarm {
    public partial class ABMEjercicios : Form {
        private EjerciciosController Controller { get; set; }

        public ABMEjercicios() {
            InitializeComponent();
            Controller = new EjerciciosController(ErrorsHandler.ErrorHandler.OnError);
            Ejercicios_Grid.DataSource = new BindingList<Ejercicio>(Context.Ejercicios);
        }

        private void Guardar_Btn_Click(object sender, EventArgs e) {
            Controller.GuardarEjercicios();
            MessageBox.Show("Ejercicios Guardados");
        }
    }
}
