namespace CaloriasFarm {
    partial class Main {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            toolStrip1 = new ToolStrip();
            General_Btn = new ToolStripButton();
            Ejercicio_Btn = new ToolStripButton();
            Mas_Tool = new ToolStripDropDownButton();
            ABMEjercicios_Btn = new ToolStripMenuItem();
            SetearMetas_Btn = new ToolStripMenuItem();
            cargarDiaDeGymToolStripMenuItem = new ToolStripMenuItem();
            pechoToolStripMenuItem = new ToolStripMenuItem();
            piernasToolStripMenuItem = new ToolStripMenuItem();
            espaldaToolStripMenuItem = new ToolStripMenuItem();
            General_Group = new GroupBox();
            Añadir_Btn = new Button();
            Calorias_Num = new NumericUpDown();
            Calorias_Lbl = new Label();
            Ejercicio_Group = new GroupBox();
            GastoTotal_Txt = new Label();
            Calorias_Txt = new Label();
            Añadir_Ejercicio_Btn = new Button();
            Totales_Lbl = new Label();
            CaloriasEjercicio_Lbl = new Label();
            Tiempo_Num = new NumericUpDown();
            Tiempo_Lbl = new Label();
            Ejercicio_Cmb = new ComboBox();
            ejercicioBindingSource = new BindingSource(components);
            Ejercicio_Lbl = new Label();
            Calorias_Bar = new ProgressBar();
            Kilos_Bar = new ProgressBar();
            label1 = new Label();
            CaloriasMin_Bar_Lbl = new Label();
            CaloriasMax_Bar_Lbl = new Label();
            label4 = new Label();
            KilosMin_Bar_Lbl = new Label();
            KilosMax_Bar_Lbl = new Label();
            CaloriasBar_Lbl = new Label();
            KilosBar_Lbl = new Label();
            historialToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            General_Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Calorias_Num).BeginInit();
            Ejercicio_Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Tiempo_Num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ejercicioBindingSource).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { General_Btn, Ejercicio_Btn, Mas_Tool });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(393, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // General_Btn
            // 
            General_Btn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            General_Btn.Image = (Image)resources.GetObject("General_Btn.Image");
            General_Btn.ImageTransparentColor = Color.Magenta;
            General_Btn.Name = "General_Btn";
            General_Btn.Size = new Size(51, 22);
            General_Btn.Text = "General";
            General_Btn.Click += General_Btn_Click;
            // 
            // Ejercicio_Btn
            // 
            Ejercicio_Btn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            Ejercicio_Btn.Image = (Image)resources.GetObject("Ejercicio_Btn.Image");
            Ejercicio_Btn.ImageTransparentColor = Color.Magenta;
            Ejercicio_Btn.Name = "Ejercicio_Btn";
            Ejercicio_Btn.Size = new Size(55, 22);
            Ejercicio_Btn.Text = "Ejercicio";
            Ejercicio_Btn.Click += Ejercicio_Btn_Click;
            // 
            // Mas_Tool
            // 
            Mas_Tool.DisplayStyle = ToolStripItemDisplayStyle.Text;
            Mas_Tool.DropDownItems.AddRange(new ToolStripItem[] { ABMEjercicios_Btn, SetearMetas_Btn, historialToolStripMenuItem, cargarDiaDeGymToolStripMenuItem });
            Mas_Tool.Image = (Image)resources.GetObject("Mas_Tool.Image");
            Mas_Tool.ImageTransparentColor = Color.Magenta;
            Mas_Tool.Name = "Mas_Tool";
            Mas_Tool.Size = new Size(42, 22);
            Mas_Tool.Text = "Más";
            // 
            // ABMEjercicios_Btn
            // 
            ABMEjercicios_Btn.Name = "ABMEjercicios_Btn";
            ABMEjercicios_Btn.Size = new Size(180, 22);
            ABMEjercicios_Btn.Text = "ABM De Ejercicios";
            ABMEjercicios_Btn.Click += ABMEjercicios_Btn_Click;
            // 
            // SetearMetas_Btn
            // 
            SetearMetas_Btn.Name = "SetearMetas_Btn";
            SetearMetas_Btn.Size = new Size(180, 22);
            SetearMetas_Btn.Text = "Setear Metas";
            SetearMetas_Btn.Click += SetearMetas_Btn_Click;
            // 
            // cargarDiaDeGymToolStripMenuItem
            // 
            cargarDiaDeGymToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pechoToolStripMenuItem, piernasToolStripMenuItem, espaldaToolStripMenuItem });
            cargarDiaDeGymToolStripMenuItem.Name = "cargarDiaDeGymToolStripMenuItem";
            cargarDiaDeGymToolStripMenuItem.Size = new Size(180, 22);
            cargarDiaDeGymToolStripMenuItem.Text = "Cargar Dia de Gym";
            // 
            // pechoToolStripMenuItem
            // 
            pechoToolStripMenuItem.Name = "pechoToolStripMenuItem";
            pechoToolStripMenuItem.Size = new Size(114, 22);
            pechoToolStripMenuItem.Text = "Pecho";
            pechoToolStripMenuItem.Click += pechoToolStripMenuItem_Click;
            // 
            // piernasToolStripMenuItem
            // 
            piernasToolStripMenuItem.Name = "piernasToolStripMenuItem";
            piernasToolStripMenuItem.Size = new Size(114, 22);
            piernasToolStripMenuItem.Text = "Piernas";
            piernasToolStripMenuItem.Click += piernasToolStripMenuItem_Click;
            // 
            // espaldaToolStripMenuItem
            // 
            espaldaToolStripMenuItem.Name = "espaldaToolStripMenuItem";
            espaldaToolStripMenuItem.Size = new Size(114, 22);
            espaldaToolStripMenuItem.Text = "Espalda";
            espaldaToolStripMenuItem.Click += espaldaToolStripMenuItem_Click;
            // 
            // General_Group
            // 
            General_Group.Controls.Add(Añadir_Btn);
            General_Group.Controls.Add(Calorias_Num);
            General_Group.Controls.Add(Calorias_Lbl);
            General_Group.Location = new Point(16, 22);
            General_Group.Margin = new Padding(3, 2, 3, 2);
            General_Group.Name = "General_Group";
            General_Group.Padding = new Padding(3, 2, 3, 2);
            General_Group.Size = new Size(325, 98);
            General_Group.TabIndex = 1;
            General_Group.TabStop = false;
            General_Group.Text = "Menu General";
            General_Group.Visible = false;
            // 
            // Añadir_Btn
            // 
            Añadir_Btn.Location = new Point(178, 36);
            Añadir_Btn.Margin = new Padding(3, 2, 3, 2);
            Añadir_Btn.Name = "Añadir_Btn";
            Añadir_Btn.Size = new Size(82, 31);
            Añadir_Btn.TabIndex = 3;
            Añadir_Btn.Text = "Añadir";
            Añadir_Btn.UseVisualStyleBackColor = true;
            Añadir_Btn.Click += Añadir_Btn_Click;
            // 
            // Calorias_Num
            // 
            Calorias_Num.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            Calorias_Num.Location = new Point(17, 41);
            Calorias_Num.Margin = new Padding(3, 2, 3, 2);
            Calorias_Num.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            Calorias_Num.Name = "Calorias_Num";
            Calorias_Num.Size = new Size(105, 23);
            Calorias_Num.TabIndex = 2;
            Calorias_Num.KeyPress += Calorias_Num_KeyPress;
            // 
            // Calorias_Lbl
            // 
            Calorias_Lbl.AutoSize = true;
            Calorias_Lbl.Location = new Point(17, 24);
            Calorias_Lbl.Name = "Calorias_Lbl";
            Calorias_Lbl.Size = new Size(49, 15);
            Calorias_Lbl.TabIndex = 0;
            Calorias_Lbl.Text = "Calorias";
            // 
            // Ejercicio_Group
            // 
            Ejercicio_Group.Controls.Add(GastoTotal_Txt);
            Ejercicio_Group.Controls.Add(Calorias_Txt);
            Ejercicio_Group.Controls.Add(Añadir_Ejercicio_Btn);
            Ejercicio_Group.Controls.Add(Totales_Lbl);
            Ejercicio_Group.Controls.Add(CaloriasEjercicio_Lbl);
            Ejercicio_Group.Controls.Add(Tiempo_Num);
            Ejercicio_Group.Controls.Add(Tiempo_Lbl);
            Ejercicio_Group.Controls.Add(Ejercicio_Cmb);
            Ejercicio_Group.Controls.Add(Ejercicio_Lbl);
            Ejercicio_Group.Location = new Point(10, 69);
            Ejercicio_Group.Margin = new Padding(3, 2, 3, 2);
            Ejercicio_Group.Name = "Ejercicio_Group";
            Ejercicio_Group.Padding = new Padding(3, 2, 3, 2);
            Ejercicio_Group.Size = new Size(372, 210);
            Ejercicio_Group.TabIndex = 3;
            Ejercicio_Group.TabStop = false;
            Ejercicio_Group.Text = "Menu Ejercicio";
            Ejercicio_Group.Visible = false;
            Ejercicio_Group.MouseCaptureChanged += Ejercicio_Group_MouseCaptureChanged;
            // 
            // GastoTotal_Txt
            // 
            GastoTotal_Txt.AutoSize = true;
            GastoTotal_Txt.BackColor = Color.GhostWhite;
            GastoTotal_Txt.Location = new Point(221, 106);
            GastoTotal_Txt.MinimumSize = new Size(115, 20);
            GastoTotal_Txt.Name = "GastoTotal_Txt";
            GastoTotal_Txt.Size = new Size(115, 20);
            GastoTotal_Txt.TabIndex = 10;
            // 
            // Calorias_Txt
            // 
            Calorias_Txt.AutoSize = true;
            Calorias_Txt.BackColor = Color.GhostWhite;
            Calorias_Txt.Location = new Point(17, 106);
            Calorias_Txt.MinimumSize = new Size(132, 20);
            Calorias_Txt.Name = "Calorias_Txt";
            Calorias_Txt.Size = new Size(132, 20);
            Calorias_Txt.TabIndex = 9;
            // 
            // Añadir_Ejercicio_Btn
            // 
            Añadir_Ejercicio_Btn.Location = new Point(138, 146);
            Añadir_Ejercicio_Btn.Margin = new Padding(3, 2, 3, 2);
            Añadir_Ejercicio_Btn.Name = "Añadir_Ejercicio_Btn";
            Añadir_Ejercicio_Btn.Size = new Size(96, 40);
            Añadir_Ejercicio_Btn.TabIndex = 8;
            Añadir_Ejercicio_Btn.Text = "Añadir";
            Añadir_Ejercicio_Btn.UseVisualStyleBackColor = true;
            Añadir_Ejercicio_Btn.Click += Añadir_Ejercicio_Btn_Click;
            // 
            // Totales_Lbl
            // 
            Totales_Lbl.AutoSize = true;
            Totales_Lbl.Location = new Point(221, 85);
            Totales_Lbl.Name = "Totales_Lbl";
            Totales_Lbl.Size = new Size(65, 15);
            Totales_Lbl.TabIndex = 6;
            Totales_Lbl.Text = "Gasto Total";
            // 
            // CaloriasEjercicio_Lbl
            // 
            CaloriasEjercicio_Lbl.AutoSize = true;
            CaloriasEjercicio_Lbl.Location = new Point(17, 85);
            CaloriasEjercicio_Lbl.Name = "CaloriasEjercicio_Lbl";
            CaloriasEjercicio_Lbl.Size = new Size(96, 15);
            CaloriasEjercicio_Lbl.TabIndex = 4;
            CaloriasEjercicio_Lbl.Text = "Calorias (30 Min)";
            // 
            // Tiempo_Num
            // 
            Tiempo_Num.DecimalPlaces = 1;
            Tiempo_Num.ImeMode = ImeMode.On;
            Tiempo_Num.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            Tiempo_Num.Location = new Point(221, 48);
            Tiempo_Num.Margin = new Padding(3, 2, 3, 2);
            Tiempo_Num.Name = "Tiempo_Num";
            Tiempo_Num.Size = new Size(91, 23);
            Tiempo_Num.TabIndex = 3;
            Tiempo_Num.ValueChanged += Tiempo_Num_ValueChanged;
            Tiempo_Num.KeyPress += Tiempo_Num_KeyPress;
            // 
            // Tiempo_Lbl
            // 
            Tiempo_Lbl.AutoSize = true;
            Tiempo_Lbl.Location = new Point(221, 30);
            Tiempo_Lbl.Name = "Tiempo_Lbl";
            Tiempo_Lbl.Size = new Size(72, 15);
            Tiempo_Lbl.TabIndex = 2;
            Tiempo_Lbl.Text = "Tiempo (Hs)";
            // 
            // Ejercicio_Cmb
            // 
            Ejercicio_Cmb.AutoCompleteCustomSource.AddRange(new string[] { "1", "2", "3", "4" });
            Ejercicio_Cmb.AutoCompleteMode = AutoCompleteMode.Suggest;
            Ejercicio_Cmb.DataSource = ejercicioBindingSource;
            Ejercicio_Cmb.DisplayMember = "Nombre";
            Ejercicio_Cmb.FormattingEnabled = true;
            Ejercicio_Cmb.Location = new Point(17, 47);
            Ejercicio_Cmb.Margin = new Padding(3, 2, 3, 2);
            Ejercicio_Cmb.Name = "Ejercicio_Cmb";
            Ejercicio_Cmb.Size = new Size(133, 23);
            Ejercicio_Cmb.TabIndex = 1;
            Ejercicio_Cmb.ValueMember = "Calorias";
            Ejercicio_Cmb.SelectedIndexChanged += Ejercicio_Cmb_SelectedIndexChanged;
            // 
            // Ejercicio_Lbl
            // 
            Ejercicio_Lbl.AutoSize = true;
            Ejercicio_Lbl.Location = new Point(17, 30);
            Ejercicio_Lbl.Name = "Ejercicio_Lbl";
            Ejercicio_Lbl.Size = new Size(51, 15);
            Ejercicio_Lbl.TabIndex = 0;
            Ejercicio_Lbl.Text = "Ejercicio";
            // 
            // Calorias_Bar
            // 
            Calorias_Bar.ForeColor = SystemColors.ActiveCaptionText;
            Calorias_Bar.Location = new Point(10, 309);
            Calorias_Bar.Margin = new Padding(3, 2, 3, 2);
            Calorias_Bar.Maximum = 7700;
            Calorias_Bar.Name = "Calorias_Bar";
            Calorias_Bar.Size = new Size(372, 22);
            Calorias_Bar.TabIndex = 2;
            Calorias_Bar.Value = 2000;
            // 
            // Kilos_Bar
            // 
            Kilos_Bar.Location = new Point(10, 378);
            Kilos_Bar.Margin = new Padding(3, 2, 3, 2);
            Kilos_Bar.Maximum = 5;
            Kilos_Bar.Name = "Kilos_Bar";
            Kilos_Bar.Size = new Size(372, 22);
            Kilos_Bar.TabIndex = 4;
            Kilos_Bar.Value = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 292);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 5;
            label1.Text = "Calorias por Kilo";
            // 
            // CaloriasMin_Bar_Lbl
            // 
            CaloriasMin_Bar_Lbl.AutoSize = true;
            CaloriasMin_Bar_Lbl.Location = new Point(10, 333);
            CaloriasMin_Bar_Lbl.Name = "CaloriasMin_Bar_Lbl";
            CaloriasMin_Bar_Lbl.Size = new Size(13, 15);
            CaloriasMin_Bar_Lbl.TabIndex = 6;
            CaloriasMin_Bar_Lbl.Text = "0";
            // 
            // CaloriasMax_Bar_Lbl
            // 
            CaloriasMax_Bar_Lbl.AutoSize = true;
            CaloriasMax_Bar_Lbl.Location = new Point(346, 333);
            CaloriasMax_Bar_Lbl.Name = "CaloriasMax_Bar_Lbl";
            CaloriasMax_Bar_Lbl.Size = new Size(31, 15);
            CaloriasMax_Bar_Lbl.TabIndex = 7;
            CaloriasMax_Bar_Lbl.Text = "7700";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(174, 361);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 8;
            label4.Text = "Kilos";
            // 
            // KilosMin_Bar_Lbl
            // 
            KilosMin_Bar_Lbl.AutoSize = true;
            KilosMin_Bar_Lbl.Location = new Point(10, 402);
            KilosMin_Bar_Lbl.Name = "KilosMin_Bar_Lbl";
            KilosMin_Bar_Lbl.Size = new Size(13, 15);
            KilosMin_Bar_Lbl.TabIndex = 9;
            KilosMin_Bar_Lbl.Text = "0";
            // 
            // KilosMax_Bar_Lbl
            // 
            KilosMax_Bar_Lbl.AutoSize = true;
            KilosMax_Bar_Lbl.Location = new Point(368, 402);
            KilosMax_Bar_Lbl.Name = "KilosMax_Bar_Lbl";
            KilosMax_Bar_Lbl.RightToLeft = RightToLeft.Yes;
            KilosMax_Bar_Lbl.Size = new Size(13, 15);
            KilosMax_Bar_Lbl.TabIndex = 10;
            KilosMax_Bar_Lbl.Text = "5";
            // 
            // CaloriasBar_Lbl
            // 
            CaloriasBar_Lbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CaloriasBar_Lbl.AutoSize = true;
            CaloriasBar_Lbl.BackColor = Color.Transparent;
            CaloriasBar_Lbl.Location = new Point(174, 333);
            CaloriasBar_Lbl.MinimumSize = new Size(36, 15);
            CaloriasBar_Lbl.Name = "CaloriasBar_Lbl";
            CaloriasBar_Lbl.Size = new Size(36, 15);
            CaloriasBar_Lbl.TabIndex = 11;
            CaloriasBar_Lbl.Text = "1000";
            CaloriasBar_Lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // KilosBar_Lbl
            // 
            KilosBar_Lbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            KilosBar_Lbl.AutoSize = true;
            KilosBar_Lbl.BackColor = Color.Transparent;
            KilosBar_Lbl.Location = new Point(174, 402);
            KilosBar_Lbl.MinimumSize = new Size(36, 15);
            KilosBar_Lbl.Name = "KilosBar_Lbl";
            KilosBar_Lbl.Size = new Size(36, 15);
            KilosBar_Lbl.TabIndex = 12;
            KilosBar_Lbl.Text = "0";
            KilosBar_Lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // historialToolStripMenuItem
            // 
            historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            historialToolStripMenuItem.Size = new Size(180, 22);
            historialToolStripMenuItem.Text = "Historial";
            historialToolStripMenuItem.Click += historialToolStripMenuItem_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 423);
            Controls.Add(KilosBar_Lbl);
            Controls.Add(CaloriasBar_Lbl);
            Controls.Add(KilosMax_Bar_Lbl);
            Controls.Add(KilosMin_Bar_Lbl);
            Controls.Add(label4);
            Controls.Add(CaloriasMax_Bar_Lbl);
            Controls.Add(CaloriasMin_Bar_Lbl);
            Controls.Add(label1);
            Controls.Add(Kilos_Bar);
            Controls.Add(Ejercicio_Group);
            Controls.Add(Calorias_Bar);
            Controls.Add(General_Group);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Main";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Farmeando Calorias";
            Activated += Main_Activated;
            Load += Main_Load;
            MouseClick += Main_MouseClick;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            General_Group.ResumeLayout(false);
            General_Group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Calorias_Num).EndInit();
            Ejercicio_Group.ResumeLayout(false);
            Ejercicio_Group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Tiempo_Num).EndInit();
            ((System.ComponentModel.ISupportInitialize)ejercicioBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton General_Btn;
        private ToolStripButton Ejercicio_Btn;
        private GroupBox General_Group;
        private NumericUpDown Calorias_Num;
        private Label Calorias_Lbl;
        private Button Añadir_Btn;
        private ProgressBar Calorias_Bar;
        private GroupBox Ejercicio_Group;
        private NumericUpDown Tiempo_Num;
        private Label Tiempo_Lbl;
        private ComboBox Ejercicio_Cmb;
        private Label Ejercicio_Lbl;
        private Label CaloriasEjercicio_Lbl;
        private Button Añadir_Ejercicio_Btn;
        private Label Totales_Lbl;
        private BindingSource ejercicioBindingSource;
        private Label GastoTotal_Txt;
        private Label Calorias_Txt;
        private ProgressBar Kilos_Bar;
        private Label label1;
        private Label CaloriasMin_Bar_Lbl;
        private Label CaloriasMax_Bar_Lbl;
        private Label label4;
        private Label KilosMin_Bar_Lbl;
        private Label KilosMax_Bar_Lbl;
        private Label CaloriasBar_Lbl;
        private Label KilosBar_Lbl;
        private ToolStripDropDownButton Mas_Tool;
        private ToolStripMenuItem ABMEjercicios_Btn;
        private ToolStripMenuItem SetearMetas_Btn;
        private ToolStripMenuItem cargarDiaDeGymToolStripMenuItem;
        private ToolStripMenuItem pechoToolStripMenuItem;
        private ToolStripMenuItem piernasToolStripMenuItem;
        private ToolStripMenuItem espaldaToolStripMenuItem;
        private ToolStripMenuItem historialToolStripMenuItem;
    }
}