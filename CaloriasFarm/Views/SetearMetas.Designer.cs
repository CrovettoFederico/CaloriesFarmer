namespace CaloriasFarm {
    partial class SetearMetas {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetearMetas));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Guardar_Btn = new Button();
            CaloriasActuales_Num = new NumericUpDown();
            KilosActuales_Num = new NumericUpDown();
            MetaCalorias_Num = new NumericUpDown();
            MetaKilos_Num = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)CaloriasActuales_Num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KilosActuales_Num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MetaCalorias_Num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MetaKilos_Num).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 23);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 0;
            label1.Text = "Calorias Actuales";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(247, 23);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 1;
            label2.Text = "Meta de Calorias";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 115);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 2;
            label3.Text = "Kilos actuales";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(247, 115);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 3;
            label4.Text = "Meta de Kilos";
            // 
            // Guardar_Btn
            // 
            Guardar_Btn.Location = new Point(142, 209);
            Guardar_Btn.Name = "Guardar_Btn";
            Guardar_Btn.Size = new Size(141, 54);
            Guardar_Btn.TabIndex = 8;
            Guardar_Btn.Text = "Guardar";
            Guardar_Btn.UseVisualStyleBackColor = true;
            Guardar_Btn.Click += Guardar_Btn_Click;
            // 
            // CaloriasActuales_Num
            // 
            CaloriasActuales_Num.Location = new Point(49, 46);
            CaloriasActuales_Num.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            CaloriasActuales_Num.Name = "CaloriasActuales_Num";
            CaloriasActuales_Num.Size = new Size(150, 27);
            CaloriasActuales_Num.TabIndex = 9;
            // 
            // KilosActuales_Num
            // 
            KilosActuales_Num.Location = new Point(46, 138);
            KilosActuales_Num.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            KilosActuales_Num.Name = "KilosActuales_Num";
            KilosActuales_Num.Size = new Size(150, 27);
            KilosActuales_Num.TabIndex = 10;
            // 
            // MetaCalorias_Num
            // 
            MetaCalorias_Num.Location = new Point(247, 46);
            MetaCalorias_Num.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            MetaCalorias_Num.Name = "MetaCalorias_Num";
            MetaCalorias_Num.Size = new Size(150, 27);
            MetaCalorias_Num.TabIndex = 11;
            // 
            // MetaKilos_Num
            // 
            MetaKilos_Num.Location = new Point(247, 138);
            MetaKilos_Num.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            MetaKilos_Num.Name = "MetaKilos_Num";
            MetaKilos_Num.Size = new Size(150, 27);
            MetaKilos_Num.TabIndex = 12;
            // 
            // SetearMetas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 310);
            Controls.Add(MetaKilos_Num);
            Controls.Add(MetaCalorias_Num);
            Controls.Add(KilosActuales_Num);
            Controls.Add(CaloriasActuales_Num);
            Controls.Add(Guardar_Btn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SetearMetas";
            Text = "Setear Metas";
            ((System.ComponentModel.ISupportInitialize)CaloriasActuales_Num).EndInit();
            ((System.ComponentModel.ISupportInitialize)KilosActuales_Num).EndInit();
            ((System.ComponentModel.ISupportInitialize)MetaCalorias_Num).EndInit();
            ((System.ComponentModel.ISupportInitialize)MetaKilos_Num).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Guardar_Btn;
        private NumericUpDown CaloriasActuales_Num;
        private NumericUpDown KilosActuales_Num;
        private NumericUpDown MetaCalorias_Num;
        private NumericUpDown MetaKilos_Num;
    }
}