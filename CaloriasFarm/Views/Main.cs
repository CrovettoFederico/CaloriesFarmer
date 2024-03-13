using CaloriasFarm.Controllers;
using CaloriasFarm.ErrorsHandler;
using CaloriasFarm.Models;
using CaloriasFarm.Utils.Context;
using System.ComponentModel;

namespace CaloriasFarm {
    public partial class Main : Form {

        private Point StartingPos = new Point(12, 45);
        private SetearMetas MetasForm;
        private ABMEjercicios ABMForm;
        private MetasController Controller;
        private CargarDiaDeGym DiaGymForm;

        public Main() {
            InitializeComponent();
            Controller = new MetasController(this, ErrorHandler.OnError);
            Controller.IniciarPrograma();
            InicializarVista();

        }
        private void InicializarVista() {
            RefrescarVista();

            General_Group.Visible = true;
            Ejercicio_Group.Visible = false;
            General_Group.Location = StartingPos;

            MetasForm = new SetearMetas();
            ABMForm = new ABMEjercicios();
        }

        private void RefrescarVista() {
            Ejercicio_Cmb.Refresh();
            Ejercicio_Cmb.DataSource = new BindingList<Ejercicio>(Context.Ejercicios);
            SetearBarras();
            this.Refresh();
        }

        private void General_Btn_Click(object sender, EventArgs e) {
            AbrirGeneral();
        }

        private void AbrirGeneral() {
            General_Group.Visible = true;
            Ejercicio_Group.Visible = false;
            General_Group.Location = StartingPos;
        }

        private void Ejercicio_Btn_Click(object sender, EventArgs e) {
            AbrirEjercicios();
        }

        private void AbrirEjercicios() {
            General_Group.Visible = false;
            Ejercicio_Group.Visible = true;
            Ejercicio_Group.Location = StartingPos;
        }

        private void Ejercicio_Cmb_SelectedIndexChanged(object sender, EventArgs e) {
            CargarEjercicioElecto((ComboBox)sender);
        }

        private void CargarEjercicioElecto(ComboBox ComboEjercicios) {
            Calorias_Txt.Text = ComboEjercicios.SelectedValue.ToString();
            GastoTotal_Txt.Text = ((int)ComboEjercicios.SelectedValue * Tiempo_Num.Value * 2).ToString();
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

            Controller.ActualizarCalorias(Calorias);
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
            if (ABMForm == null || ABMForm.IsDisposed) ABMForm = new ABMEjercicios();
            ABMForm.Show();
            ABMForm.Select();
        }


        private void Main_Activated(object sender, EventArgs e) {
            RefrescarVista();
        }

        private void SetearMetas_Btn_Click(object sender, EventArgs e) {
            if (MetasForm == null || MetasForm.IsDisposed) MetasForm = new SetearMetas();
            MetasForm.Show();
            MetasForm.Select();
        }

        private void Main_MouseClick(object sender, MouseEventArgs e) {
            Ejercicio_Group.Select();
        }

        private void Ejercicio_Group_MouseCaptureChanged(object sender, EventArgs e) {
            Ejercicio_Group.Select();
        }

        private void pechoToolStripMenuItem_Click(object sender, EventArgs e) {
            MostrarCargarDiaGym(TiposDeRutina.Pecho);
        }

        private void piernasToolStripMenuItem_Click(object sender, EventArgs e) {
            MostrarCargarDiaGym(TiposDeRutina.Piernas);
        }

        private void espaldaToolStripMenuItem_Click(object sender, EventArgs e) {
            MostrarCargarDiaGym(TiposDeRutina.Espalda);
        }

        private void MostrarCargarDiaGym(TiposDeRutina Rutina) {
            if (DiaGymForm == null || DiaGymForm.IsDisposed)
                DiaGymForm = new CargarDiaDeGym(Rutina);

            DiaGymForm.Show();
            DiaGymForm.Select();

            if (DiaGymForm.Text != Rutina.ToString())
                MessageBox.Show("Ya esta cargando un dia de Gimnasio");

        }

        private void Mas_Tool_Click(object sender, EventArgs e) {

        }
    }
}