namespace CaloriasFarm.ViewControls {
    partial class SerieControl {
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
            num_Reps = new NumericUpDown();
            num_Peso = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)num_Reps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_Peso).BeginInit();
            SuspendLayout();
            // 
            // num_Reps
            // 
            num_Reps.Location = new Point(2, 0);
            num_Reps.Name = "num_Reps";
            num_Reps.Size = new Size(47, 27);
            num_Reps.TabIndex = 0;
            num_Reps.ValueChanged += num_Reps_ValueChanged;
            num_Reps.KeyUp += num_Reps_KeyUp;
            // 
            // num_Peso
            // 
            num_Peso.Location = new Point(1, 51);
            num_Peso.Name = "num_Peso";
            num_Peso.Size = new Size(48, 27);
            num_Peso.TabIndex = 1;
            num_Peso.ValueChanged += num_Peso_ValueChanged;
            num_Peso.KeyUp += num_Peso_KeyUp;
            // 
            // Serie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(num_Peso);
            Controls.Add(num_Reps);
            Name = "Serie";
            Size = new Size(56, 81);
            ((System.ComponentModel.ISupportInitialize)num_Reps).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_Peso).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown num_Reps;
        private NumericUpDown num_Peso;
    }
}
