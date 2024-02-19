using CaloriasFarm.Controllers;
using CaloriasFarm.ErrorsHandler;
using CaloriasFarm.Models;
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

namespace CaloriasFarm {
    public partial class SetearMetas : Form {
        MetasController metasController;

        public SetearMetas() {
            InitializeComponent();
            metasController = new MetasController(ErrorHandler.OnError);
            CargarCalorias();
        }

        private void CargarCalorias() {
            CaloriasActuales_Num.Value = Context.Metas.ActualCalorias;
            MetaCalorias_Num.Value = Context.Metas.TotalCalorias;
            KilosActuales_Num.Value = Context.Metas.ActualKilos;
            MetaKilos_Num.Value = Context.Metas.TotalKilos;
        }

        private void Guardar_Btn_Click(object sender, EventArgs e) {
            bool guardar = metasController.SetearMetas(new Metas() {
                ActualCalorias = decimal.ToInt32(CaloriasActuales_Num.Value),
                TotalCalorias = decimal.ToInt32(MetaCalorias_Num.Value),
                ActualKilos = decimal.ToInt32(KilosActuales_Num.Value),
                TotalKilos = decimal.ToInt32(MetaKilos_Num.Value)
            });

            if(guardar)
                MessageBox.Show("Metas Guardadas");
        }
    }
}
