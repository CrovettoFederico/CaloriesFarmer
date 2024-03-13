using CaloriasFarm.Controllers;
using CaloriasFarm.ErrorsHandler;
using CaloriasFarm.Models;
using CaloriasFarm.Utils.Context;
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
    public partial class CargarDiaDeGym : Form {

        private readonly int EspacioEntreEjercicios = 30;
        private readonly TiposDeRutina TipoRutina;
        public Rutina _Rutina;
        private CargarDiaGymController Controller;

        public CargarDiaDeGym(TiposDeRutina Rutina) {
            InitializeComponent();
            Controller = new CargarDiaGymController(this, ErrorHandler.OnError);
            TipoRutina = Rutina;
            this.Text = TipoRutina.ToString();
            IniciarControlesEjercicios();
        }

        private void IniciarControlesEjercicios() {
            int Xpos = 10, Ypos = 10;
            int ControlCount = 0;
            _Rutina = Context.Rutinas.Where(rutina => rutina.TipoDeRutina == TipoRutina).First();

            _Rutina.EjerciciosGym.ForEach(ejercicio => {
                var NewEjercicioControl = new EjercicioControl(ejercicio);
                NewEjercicioControl.AutoSize = true;
                NewEjercicioControl.Location = new Point(Xpos, Ypos);
                NewEjercicioControl.Name = "Ejercicio_" + ControlCount.ToString();
                NewEjercicioControl.TabIndex = 0;
                this.panel_Ejercicios.Controls.Add(NewEjercicioControl);

                Ypos += NewEjercicioControl.Size.Height + EspacioEntreEjercicios;
                ControlCount++;
            });
        }

        private string QuitarNoNumericos(string Texto) {
            string TextoSinNumeros = Texto;
            foreach (char c in Texto) {
                if (!char.IsDigit(c))
                    TextoSinNumeros = TextoSinNumeros.Replace(c.ToString(), "");
            }

            return TextoSinNumeros;
        }

        private void stripTxt_Semana_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void stripBut_Guardar_Click_1(object sender, EventArgs e) {
            if (Controller.GuardarDiaDeGym())
                MessageBox.Show("Dia de gimnasio guardado");
        }

        private void stripTxt_Semana_TextChanged(object sender, EventArgs e) {
            stripTxt_Semana.Text = QuitarNoNumericos(sender.ToString());
            if (stripTxt_Semana.TextLength == 0) stripTxt_Semana.Text = "0";
            stripTxt_Semana.Select(stripTxt_Semana.TextLength, 0);
        }

    }
}
