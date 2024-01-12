using CaloriasFarm.Models;
using CaloriasFarm.Utils;
using System.ComponentModel;

namespace CaloriasFarm {
    public partial class Main : Form {

        private Point StartingPos = new Point(12, 45);
        public Main() {
            InitializeComponent();
            Context.CargarContext();
            Inicializar();
            General_Group.Visible = true;
            Ejercicio_Group.Visible = false;
            General_Group.Location = StartingPos;
        }
        private void Inicializar() {

            Ejercicio_Cmb.Refresh();
            Ejercicio_Cmb.DataSource = new BindingList<Ejercicio>(Context.Ejercicios);
            SetearBarras();
        }


        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void General_Btn_Click(object sender, EventArgs e) {
            General_Group.Visible = true;
            Ejercicio_Group.Visible = false;
            General_Group.Location = StartingPos;
        }

        private void Ejercicio_Btn_Click(object sender, EventArgs e) {
            General_Group.Visible = false;
            Ejercicio_Group.Visible = true;
            Ejercicio_Group.Location = StartingPos;
        }

        private void Ejercicio_Cmb_SelectedIndexChanged(object sender, EventArgs e) {
            Calorias_Txt.Text = ((ComboBox)sender).SelectedValue.ToString();
            GastoTotal_Txt.Text = ((int)((ComboBox)sender).SelectedValue * Tiempo_Num.Value * 2).ToString();

        }

        private void Tiempo_Num_ValueChanged(object sender, EventArgs e) {
            GastoTotal_Txt.Text = (((NumericUpDown)sender).Value * (int)Ejercicio_Cmb.SelectedValue * 2).ToString();
        }

        private void Main_Load(object sender, EventArgs e) {
        }

        private void Añadir_Ejercicio_Btn_Click(object sender, EventArgs e) {
            ActualizarCalorias(Decimal.ToInt32(Decimal.Parse(GastoTotal_Txt.Text)));
        }

        private void Añadir_Btn_Click(object sender, EventArgs e) {
            ActualizarCalorias((int)Calorias_Num.Value);
        }

        private void SetearBarras() {
            Calorias_Bar.Minimum = 0;
            Calorias_Bar.Maximum = Context.Metas.TotalCalorias;
            CaloriasMax_Bar_Lbl.Text = Context.Metas.TotalCalorias.ToString();
            Calorias_Bar.Value = Context.Metas.ActualCalorias;
            CaloriasBar_Lbl.Text = Context.Metas.ActualCalorias.ToString();

            Kilos_Bar.Minimum = 0;
            Kilos_Bar.Maximum = Context.Metas.TotalKilos;
            KilosMax_Bar_Lbl.Text = Context.Metas.TotalKilos.ToString();
            Kilos_Bar.Value = Context.Metas.ActualKilos;
            KilosBar_Lbl.Text = Context.Metas.ActualKilos.ToString();
        }

        private void ActualizarCalorias(int Calorias) {
            Context.Metas.ActualCalorias += Calorias;
            if (Context.Metas.ActualCalorias >= 7700) {
                Context.Metas.ActualCalorias -= 7700;
                Context.Metas.ActualKilos++;
            }
            Context.GuardarContext();
            SetearBarras();

        }

        private void Calorias_Num_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)13) {
                ActualizarCalorias((int)Calorias_Num.Value);
            }
        }

        private void Tiempo_Num_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)13) {
                ActualizarCalorias(Decimal.ToInt32(Decimal.Parse(GastoTotal_Txt.Text)));
            }
        }

        private void ABMEjercicios_Btn_Click(object sender, EventArgs e) {
            ABMEjercicios frm = new ABMEjercicios();
            frm.Show();
        }


        private void Main_Activated(object sender, EventArgs e) {
            Inicializar();
            this.Refresh();
        }

        private void SetearMetas_Btn_Click(object sender, EventArgs e) {
            SetearMetas frm = new SetearMetas();
            frm.Show();
        }
    }
}