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
        public SetearMetas() {
            InitializeComponent();
            CaloriasActuales_Num.Value = Context.Metas.ActualCalorias;
            MetaCalorias_Num.Value = Context.Metas.TotalCalorias;
            KilosActuales_Num.Value = Context.Metas.ActualKilos;
            MetaKilos_Num.Value = Context.Metas.TotalKilos;
        }

        private void Guardar_Btn_Click(object sender, EventArgs e) {
            Context.Metas.ActualCalorias = decimal.ToInt32(CaloriasActuales_Num.Value);
            Context.Metas.TotalCalorias = decimal.ToInt32(MetaCalorias_Num.Value);
            Context.Metas.ActualKilos = decimal.ToInt32(KilosActuales_Num.Value);
            Context.Metas.TotalKilos = decimal.ToInt32(MetaKilos_Num.Value);
            Context.GuardarContext();
            MessageBox.Show("Metas Guardadas");
        }
    }
}
