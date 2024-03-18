namespace CaloriasFarm.ViewControls {
    partial class ItemHistorialControl {
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
            lbl_Causa = new Label();
            lbl_Calorias = new Label();
            SuspendLayout();
            // 
            // lbl_Causa
            // 
            lbl_Causa.AutoSize = true;
            lbl_Causa.Location = new Point(3, 0);
            lbl_Causa.Name = "lbl_Causa";
            lbl_Causa.Size = new Size(48, 20);
            lbl_Causa.TabIndex = 0;
            lbl_Causa.Text = "Causa";
            // 
            // lbl_Calorias
            // 
            lbl_Calorias.AutoSize = true;
            lbl_Calorias.Location = new Point(322, 0);
            lbl_Calorias.Name = "lbl_Calorias";
            lbl_Calorias.Size = new Size(33, 20);
            lbl_Calorias.TabIndex = 1;
            lbl_Calorias.Text = "999";
            // 
            // ItemHistorial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbl_Calorias);
            Controls.Add(lbl_Causa);
            Name = "ItemHistorial";
            Size = new Size(358, 20);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lbl_Causa;
        public Label lbl_Calorias;
    }
}
