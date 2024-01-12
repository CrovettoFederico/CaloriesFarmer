namespace CaloriasFarm {
    partial class ABMEjercicios {
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABMEjercicios));
            Ejercicios_Grid = new DataGridView();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            caloriasDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ejercicioBindingSource = new BindingSource(components);
            Guardar_Btn = new Button();
            ((System.ComponentModel.ISupportInitialize)Ejercicios_Grid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ejercicioBindingSource).BeginInit();
            SuspendLayout();
            // 
            // Ejercicios_Grid
            // 
            Ejercicios_Grid.AutoGenerateColumns = false;
            Ejercicios_Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Ejercicios_Grid.Columns.AddRange(new DataGridViewColumn[] { nombreDataGridViewTextBoxColumn, caloriasDataGridViewTextBoxColumn });
            Ejercicios_Grid.DataSource = ejercicioBindingSource;
            Ejercicios_Grid.Location = new Point(12, 12);
            Ejercicios_Grid.Name = "Ejercicios_Grid";
            Ejercicios_Grid.RowHeadersWidth = 51;
            Ejercicios_Grid.RowTemplate.Height = 29;
            Ejercicios_Grid.Size = new Size(309, 244);
            Ejercicios_Grid.TabIndex = 0;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.Width = 93;
            // 
            // caloriasDataGridViewTextBoxColumn
            // 
            caloriasDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            caloriasDataGridViewTextBoxColumn.DataPropertyName = "Calorias";
            caloriasDataGridViewTextBoxColumn.HeaderText = "Calorias";
            caloriasDataGridViewTextBoxColumn.MinimumWidth = 6;
            caloriasDataGridViewTextBoxColumn.Name = "caloriasDataGridViewTextBoxColumn";
            // 
            // ejercicioBindingSource
            // 
            ejercicioBindingSource.DataSource = typeof(Models.Ejercicio);
            // 
            // Guardar_Btn
            // 
            Guardar_Btn.Location = new Point(106, 278);
            Guardar_Btn.Name = "Guardar_Btn";
            Guardar_Btn.Size = new Size(122, 45);
            Guardar_Btn.TabIndex = 1;
            Guardar_Btn.Text = "Guardar";
            Guardar_Btn.UseVisualStyleBackColor = true;
            Guardar_Btn.Click += Guardar_Btn_Click;
            // 
            // ABMEjercicios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 335);
            Controls.Add(Guardar_Btn);
            Controls.Add(Ejercicios_Grid);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ABMEjercicios";
            Text = "ABM Ejercicios";
            ((System.ComponentModel.ISupportInitialize)Ejercicios_Grid).EndInit();
            ((System.ComponentModel.ISupportInitialize)ejercicioBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Ejercicios_Grid;
        private BindingSource ejercicioBindingSource;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn caloriasDataGridViewTextBoxColumn;
        private Button Guardar_Btn;
    }
}