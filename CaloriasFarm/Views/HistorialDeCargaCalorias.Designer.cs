namespace CaloriasFarm.Views {
    partial class HistorialDeCargaCalorias {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialDeCargaCalorias));
            Calendar_Historial = new MonthCalendar();
            lbl_TituloDiaHistorial = new Label();
            panel_ContenedorHistorial = new Panel();
            Historial_Total = new ViewControls.ItemHistorialControl();
            SuspendLayout();
            // 
            // Calendar_Historial
            // 
            Calendar_Historial.Location = new Point(18, 18);
            Calendar_Historial.Margin = new Padding(0);
            Calendar_Historial.MaxSelectionCount = 1;
            Calendar_Historial.Name = "Calendar_Historial";
            Calendar_Historial.TabIndex = 0;
            Calendar_Historial.DateChanged += Calendar_Historial_DateChanged;
            // 
            // lbl_TituloDiaHistorial
            // 
            lbl_TituloDiaHistorial.AutoSize = true;
            lbl_TituloDiaHistorial.Location = new Point(533, 30);
            lbl_TituloDiaHistorial.Margin = new Padding(0);
            lbl_TituloDiaHistorial.Name = "lbl_TituloDiaHistorial";
            lbl_TituloDiaHistorial.Size = new Size(74, 20);
            lbl_TituloDiaHistorial.TabIndex = 1;
            lbl_TituloDiaHistorial.Text = "Titulo Dia";
            lbl_TituloDiaHistorial.SizeChanged += lbl_TituloDiaHistorial_SizeChanged;
            // 
            // panel_ContenedorHistorial
            // 
            panel_ContenedorHistorial.AutoScroll = true;
            panel_ContenedorHistorial.Location = new Point(320, 56);
            panel_ContenedorHistorial.Name = "panel_ContenedorHistorial";
            panel_ContenedorHistorial.Size = new Size(358, 133);
            panel_ContenedorHistorial.TabIndex = 2;
            // 
            // Historial_Total
            // 
            Historial_Total.Location = new Point(320, 200);
            Historial_Total.Name = "Historial_Total";
            Historial_Total.Size = new Size(358, 25);
            Historial_Total.TabIndex = 0;
            // 
            // HistorialDeCargaCalorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 243);
            Controls.Add(Historial_Total);
            Controls.Add(panel_ContenedorHistorial);
            Controls.Add(lbl_TituloDiaHistorial);
            Controls.Add(Calendar_Historial);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "HistorialDeCargaCalorias";
            Text = "Historial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar Calendar_Historial;
        private Label lbl_TituloDiaHistorial;
        private Panel panel_ContenedorHistorial;
        private ViewControls.ItemHistorialControl Historial_Total;
    }
}