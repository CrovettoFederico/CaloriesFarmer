namespace CaloriasFarm {
    partial class EjercicioControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            lbl_EjercicioName = new Label();
            lbl_Reps = new Label();
            lbl_Peso = new Label();
            but_mas = new Button();
            Serie_1 = new ViewControls.SerieControl();
            panel_Contenedor = new Panel();
            panel_Contenedor.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_EjercicioName
            // 
            lbl_EjercicioName.AutoSize = true;
            lbl_EjercicioName.Location = new Point(3, 33);
            lbl_EjercicioName.Name = "lbl_EjercicioName";
            lbl_EjercicioName.Size = new Size(65, 20);
            lbl_EjercicioName.TabIndex = 0;
            lbl_EjercicioName.Text = "Ejercicio";
            // 
            // lbl_Reps
            // 
            lbl_Reps.AutoSize = true;
            lbl_Reps.Location = new Point(57, 3);
            lbl_Reps.Name = "lbl_Reps";
            lbl_Reps.Size = new Size(41, 20);
            lbl_Reps.TabIndex = 1;
            lbl_Reps.Text = "Reps";
            // 
            // lbl_Peso
            // 
            lbl_Peso.AutoSize = true;
            lbl_Peso.Location = new Point(57, 61);
            lbl_Peso.Name = "lbl_Peso";
            lbl_Peso.Size = new Size(39, 20);
            lbl_Peso.TabIndex = 2;
            lbl_Peso.Text = "Peso";
            // 
            // but_mas
            // 
            but_mas.Location = new Point(181, 29);
            but_mas.Name = "but_mas";
            but_mas.Size = new Size(39, 29);
            but_mas.TabIndex = 5;
            but_mas.Text = "+";
            but_mas.UseVisualStyleBackColor = true;
            but_mas.Click += but_mas_Click;
            // 
            // Serie_1
            // 
            Serie_1.BackColor = Color.Transparent;
            Serie_1.Location = new Point(111, 3);
            Serie_1.Name = "Serie_1";
            Serie_1.Size = new Size(50, 84);
            Serie_1.TabIndex = 6;
            // 
            // panel_Contenedor
            // 
            panel_Contenedor.AutoSize = true;
            panel_Contenedor.BorderStyle = BorderStyle.FixedSingle;
            panel_Contenedor.Controls.Add(lbl_Reps);
            panel_Contenedor.Controls.Add(Serie_1);
            panel_Contenedor.Controls.Add(lbl_EjercicioName);
            panel_Contenedor.Controls.Add(but_mas);
            panel_Contenedor.Controls.Add(lbl_Peso);
            panel_Contenedor.Location = new Point(0, 0);
            panel_Contenedor.Name = "panel_Contenedor";
            panel_Contenedor.Size = new Size(251, 92);
            panel_Contenedor.TabIndex = 7;
            // 
            // EjercicioControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel_Contenedor);
            Name = "EjercicioControl";
            Size = new Size(251, 87);
            panel_Contenedor.ResumeLayout(false);
            panel_Contenedor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lbl_EjercicioName;
        private Label lbl_Reps;
        private Label lbl_Peso;
        private Button but_mas;
        private ViewControls.SerieControl Serie_1;
        private Panel panel_Contenedor;
    }
}
