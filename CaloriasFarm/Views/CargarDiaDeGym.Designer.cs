namespace CaloriasFarm {
    partial class CargarDiaDeGym {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CargarDiaDeGym));
            panel_Ejercicios = new Panel();
            toolStrip = new ToolStrip();
            stripBut_Guardar = new ToolStripButton();
            stripLbl_Semana = new ToolStripLabel();
            stripTxt_Semana = new ToolStripTextBox();
            toolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Ejercicios
            // 
            panel_Ejercicios.AutoScroll = true;
            panel_Ejercicios.Location = new Point(0, 0);
            panel_Ejercicios.Name = "panel_Ejercicios";
            panel_Ejercicios.Size = new Size(798, 420);
            panel_Ejercicios.TabIndex = 0;
            // 
            // toolStrip
            // 
            toolStrip.Dock = DockStyle.Bottom;
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { stripBut_Guardar, stripLbl_Semana, stripTxt_Semana });
            toolStrip.Location = new Point(0, 423);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(800, 27);
            toolStrip.TabIndex = 1;
            toolStrip.Text = "Guardar";
            // 
            // stripBut_Guardar
            // 
            stripBut_Guardar.Alignment = ToolStripItemAlignment.Right;
            stripBut_Guardar.Image = (Image)resources.GetObject("stripBut_Guardar.Image");
            stripBut_Guardar.ImageTransparentColor = Color.Magenta;
            stripBut_Guardar.Name = "stripBut_Guardar";
            stripBut_Guardar.Size = new Size(86, 24);
            stripBut_Guardar.Text = "Guardar";
            stripBut_Guardar.Click += stripBut_Guardar_Click_1;
            // 
            // stripLbl_Semana
            // 
            stripLbl_Semana.Name = "stripLbl_Semana";
            stripLbl_Semana.Size = new Size(62, 24);
            stripLbl_Semana.Text = "Semana";
            // 
            // stripTxt_Semana
            // 
            stripTxt_Semana.Name = "stripTxt_Semana";
            stripTxt_Semana.Size = new Size(100, 27);
            stripTxt_Semana.Text = "0";
            stripTxt_Semana.TextChanged += stripTxt_Semana_TextChanged;
            // 
            // CargarDiaDeGym
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip);
            Controls.Add(panel_Ejercicios);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CargarDiaDeGym";
            Text = "Cargar Dia De Gym";
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Panel panel_Ejercicios;
        private ToolStrip toolStrip;
        private ToolStripButton stripBut_Guardar;
        private ToolStripLabel stripLbl_Semana;
        public ToolStripTextBox stripTxt_Semana;
    }
}