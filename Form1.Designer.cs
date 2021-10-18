namespace Simulacion_Procesos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Detener = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.lbl_Contador = new System.Windows.Forms.Label();
            this.BtnGrafica = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dgv_Proceso = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.LblNombreCPU = new MetroFramework.Controls.MetroLabel();
            this.ProgressBarCPU = new MetroFramework.Controls.MetroProgressBar();
            this.ProgressBarRAM = new MetroFramework.Controls.MetroProgressBar();
            this.LblNombreRam = new MetroFramework.Controls.MetroLabel();
            this.LblPorCPU = new MetroFramework.Controls.MetroLabel();
            this.LblPorRAM = new MetroFramework.Controls.MetroLabel();
            this.Grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSalir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Proceso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grafico)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel2.Controls.Add(this.Btn_Detener);
            this.panel2.Controls.Add(this.BtnActualizar);
            this.panel2.Controls.Add(this.lbl_Contador);
            this.panel2.Controls.Add(this.BtnGrafica);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(27, 74);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 574);
            this.panel2.TabIndex = 1;
            // 
            // Btn_Detener
            // 
            this.Btn_Detener.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Btn_Detener.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Detener.FlatAppearance.BorderSize = 0;
            this.Btn_Detener.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Detener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Detener.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Detener.ForeColor = System.Drawing.Color.White;
            this.Btn_Detener.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Detener.Location = new System.Drawing.Point(0, 161);
            this.Btn_Detener.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Detener.Name = "Btn_Detener";
            this.Btn_Detener.Size = new System.Drawing.Size(296, 74);
            this.Btn_Detener.TabIndex = 8;
            this.Btn_Detener.Text = "Detener Proceso";
            this.Btn_Detener.UseVisualStyleBackColor = false;
            this.Btn_Detener.Click += new System.EventHandler(this.Btn_Detener_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.BtnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnActualizar.FlatAppearance.BorderSize = 0;
            this.BtnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.Color.White;
            this.BtnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnActualizar.Location = new System.Drawing.Point(0, 79);
            this.BtnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(296, 74);
            this.BtnActualizar.TabIndex = 6;
            this.BtnActualizar.Text = "Actualizar Tabla";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // lbl_Contador
            // 
            this.lbl_Contador.AutoSize = true;
            this.lbl_Contador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Contador.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contador.ForeColor = System.Drawing.Color.White;
            this.lbl_Contador.Location = new System.Drawing.Point(20, 366);
            this.lbl_Contador.Name = "lbl_Contador";
            this.lbl_Contador.Size = new System.Drawing.Size(206, 26);
            this.lbl_Contador.TabIndex = 5;
            this.lbl_Contador.Text = "Contador Procesos";
            // 
            // BtnGrafica
            // 
            this.BtnGrafica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.BtnGrafica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGrafica.FlatAppearance.BorderSize = 0;
            this.BtnGrafica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnGrafica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGrafica.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGrafica.ForeColor = System.Drawing.Color.White;
            this.BtnGrafica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGrafica.Location = new System.Drawing.Point(0, 242);
            this.BtnGrafica.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGrafica.Name = "BtnGrafica";
            this.BtnGrafica.Size = new System.Drawing.Size(296, 74);
            this.BtnGrafica.TabIndex = 1;
            this.BtnGrafica.Text = "Gráfica CPU y RAM";
            this.BtnGrafica.UseVisualStyleBackColor = false;
            this.BtnGrafica.Click += new System.EventHandler(this.Button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            // 
            // dgv_Proceso
            // 
            this.dgv_Proceso.AllowUserToAddRows = false;
            this.dgv_Proceso.AllowUserToDeleteRows = false;
            this.dgv_Proceso.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgv_Proceso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Proceso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_Proceso.Location = new System.Drawing.Point(329, 76);
            this.dgv_Proceso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Proceso.Name = "dgv_Proceso";
            this.dgv_Proceso.ReadOnly = true;
            this.dgv_Proceso.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgv_Proceso.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Proceso.RowTemplate.Height = 24;
            this.dgv_Proceso.Size = new System.Drawing.Size(996, 454);
            this.dgv_Proceso.TabIndex = 19;
            this.dgv_Proceso.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_Proceso_MouseClick_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Num Proceso";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Procesos";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Prioridad Proceso";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ID";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Memoria Fisica";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Memoria Virtual";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // pRAM
            // 
            this.pRAM.CategoryName = "Memory";
            this.pRAM.CounterName = "% Committed Bytes In Use";
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_Total";
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // LblNombreCPU
            // 
            this.LblNombreCPU.AutoSize = true;
            this.LblNombreCPU.Location = new System.Drawing.Point(383, 127);
            this.LblNombreCPU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombreCPU.Name = "LblNombreCPU";
            this.LblNombreCPU.Size = new System.Drawing.Size(36, 20);
            this.LblNombreCPU.TabIndex = 20;
            this.LblNombreCPU.Text = "CPU";
            this.LblNombreCPU.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LblNombreCPU.Visible = false;
            // 
            // ProgressBarCPU
            // 
            this.ProgressBarCPU.Location = new System.Drawing.Point(475, 122);
            this.ProgressBarCPU.Margin = new System.Windows.Forms.Padding(4);
            this.ProgressBarCPU.Name = "ProgressBarCPU";
            this.ProgressBarCPU.Size = new System.Drawing.Size(555, 28);
            this.ProgressBarCPU.TabIndex = 21;
            this.ProgressBarCPU.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ProgressBarCPU.Visible = false;
            // 
            // ProgressBarRAM
            // 
            this.ProgressBarRAM.Location = new System.Drawing.Point(475, 171);
            this.ProgressBarRAM.Margin = new System.Windows.Forms.Padding(4);
            this.ProgressBarRAM.Name = "ProgressBarRAM";
            this.ProgressBarRAM.Size = new System.Drawing.Size(555, 28);
            this.ProgressBarRAM.TabIndex = 23;
            this.ProgressBarRAM.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ProgressBarRAM.Visible = false;
            // 
            // LblNombreRam
            // 
            this.LblNombreRam.AutoSize = true;
            this.LblNombreRam.Location = new System.Drawing.Point(383, 176);
            this.LblNombreRam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombreRam.Name = "LblNombreRam";
            this.LblNombreRam.Size = new System.Drawing.Size(38, 20);
            this.LblNombreRam.TabIndex = 22;
            this.LblNombreRam.Text = "RAM";
            this.LblNombreRam.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LblNombreRam.Visible = false;
            // 
            // LblPorCPU
            // 
            this.LblPorCPU.AutoSize = true;
            this.LblPorCPU.Location = new System.Drawing.Point(1061, 127);
            this.LblPorCPU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPorCPU.Name = "LblPorCPU";
            this.LblPorCPU.Size = new System.Drawing.Size(33, 20);
            this.LblPorCPU.TabIndex = 24;
            this.LblPorCPU.Text = "0 %";
            this.LblPorCPU.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LblPorCPU.Visible = false;
            // 
            // LblPorRAM
            // 
            this.LblPorRAM.AutoSize = true;
            this.LblPorRAM.Location = new System.Drawing.Point(1061, 176);
            this.LblPorRAM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPorRAM.Name = "LblPorRAM";
            this.LblPorRAM.Size = new System.Drawing.Size(33, 20);
            this.LblPorRAM.TabIndex = 25;
            this.LblPorRAM.Text = "0 %";
            this.LblPorRAM.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LblPorRAM.Visible = false;
            // 
            // Grafico
            // 
            this.Grafico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Grafico.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Grafico.BorderSkin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Grafico.BorderSkin.PageColor = System.Drawing.Color.Black;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.Grafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Grafico.Legends.Add(legend1);
            this.Grafico.Location = new System.Drawing.Point(331, 235);
            this.Grafico.Margin = new System.Windows.Forms.Padding(4);
            this.Grafico.Name = "Grafico";
            this.Grafico.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            series1.LabelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "CPU";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            series2.LabelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "RAM";
            this.Grafico.Series.Add(series1);
            this.Grafico.Series.Add(series2);
            this.Grafico.Size = new System.Drawing.Size(993, 295);
            this.Grafico.TabIndex = 26;
            this.Grafico.Visible = false;
            this.Grafico.Click += new System.EventHandler(this.Grafico_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalir.Location = new System.Drawing.Point(1115, 590);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(210, 55);
            this.btnSalir.TabIndex = 27;
            this.btnSalir.Text = "Salir del programa";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(803, 590);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(291, 55);
            this.button1.TabIndex = 28;
            this.button1.Text = "Regresar al menú principal";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 673);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.Grafico);
            this.Controls.Add(this.LblPorRAM);
            this.Controls.Add(this.LblPorCPU);
            this.Controls.Add(this.ProgressBarRAM);
            this.Controls.Add(this.LblNombreRam);
            this.Controls.Add(this.ProgressBarCPU);
            this.Controls.Add(this.LblNombreCPU);
            this.Controls.Add(this.dgv_Proceso);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Estadísticas de Tareas y Procesos del Ordenador en tiempo real: Memoria Real y Vi" +
    "rtual";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Proceso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnGrafica;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Label lbl_Contador;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Btn_Detener;
        private System.Windows.Forms.DataGridView dgv_Proceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Diagnostics.PerformanceCounter pRAM;
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Windows.Forms.Timer timer;
        private MetroFramework.Controls.MetroLabel LblNombreCPU;
        private MetroFramework.Controls.MetroProgressBar ProgressBarCPU;
        private MetroFramework.Controls.MetroProgressBar ProgressBarRAM;
        private MetroFramework.Controls.MetroLabel LblNombreRam;
        private MetroFramework.Controls.MetroLabel LblPorCPU;
        private MetroFramework.Controls.MetroLabel LblPorRAM;
        private System.Windows.Forms.DataVisualization.Charting.Chart Grafico;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button button1;
    }
}

