namespace Sistema_Votacion
{
    partial class vControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_get_empleados = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gridGanadores = new System.Windows.Forms.DataGridView();
            this.lblGanadorEmp = new System.Windows.Forms.Label();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.btn_presente = new System.Windows.Forms.Button();
            this.btn_ausente = new System.Windows.Forms.Button();
            this.lbldepacontrol = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gridPremios = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_agregar_xls_empleados = new System.Windows.Forms.Button();
            this.btn_agregar_xls_premios = new System.Windows.Forms.Button();
            this.Historial_Ganadores = new System.Windows.Forms.DataGridView();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Premio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.na = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridGanadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPremios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Historial_Ganadores)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_get_empleados
            // 
            this.btn_get_empleados.Location = new System.Drawing.Point(171, 203);
            this.btn_get_empleados.Name = "btn_get_empleados";
            this.btn_get_empleados.Size = new System.Drawing.Size(149, 38);
            this.btn_get_empleados.TabIndex = 1;
            this.btn_get_empleados.Text = "Buscar Ganador";
            this.btn_get_empleados.UseVisualStyleBackColor = true;
            this.btn_get_empleados.Click += new System.EventHandler(this.btn_get_empleados_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(483, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista de Ganadores";
            // 
            // gridGanadores
            // 
            this.gridGanadores.AllowUserToAddRows = false;
            this.gridGanadores.AllowUserToDeleteRows = false;
            this.gridGanadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGanadores.Location = new System.Drawing.Point(435, 65);
            this.gridGanadores.Name = "gridGanadores";
            this.gridGanadores.ReadOnly = true;
            this.gridGanadores.Size = new System.Drawing.Size(353, 220);
            this.gridGanadores.TabIndex = 4;
            // 
            // lblGanadorEmp
            // 
            this.lblGanadorEmp.AutoSize = true;
            this.lblGanadorEmp.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGanadorEmp.Location = new System.Drawing.Point(12, 65);
            this.lblGanadorEmp.Name = "lblGanadorEmp";
            this.lblGanadorEmp.Size = new System.Drawing.Size(243, 26);
            this.lblGanadorEmp.TabIndex = 5;
            this.lblGanadorEmp.Text = "Click en \"Buscar Ganador\"";
            this.lblGanadorEmp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Location = new System.Drawing.Point(17, 247);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(303, 38);
            this.btnExportarExcel.TabIndex = 8;
            this.btnExportarExcel.Text = "Exportar Historial";
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            this.btnExportarExcel.Visible = false;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // btn_presente
            // 
            this.btn_presente.BackColor = System.Drawing.Color.LightGreen;
            this.btn_presente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_presente.Location = new System.Drawing.Point(16, 108);
            this.btn_presente.Name = "btn_presente";
            this.btn_presente.Size = new System.Drawing.Size(191, 45);
            this.btn_presente.TabIndex = 9;
            this.btn_presente.Text = "ESTA PRESENTE";
            this.btn_presente.UseVisualStyleBackColor = false;
            this.btn_presente.Visible = false;
            this.btn_presente.Click += new System.EventHandler(this.btn_presente_Click);
            // 
            // btn_ausente
            // 
            this.btn_ausente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ausente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ausente.Location = new System.Drawing.Point(213, 108);
            this.btn_ausente.Name = "btn_ausente";
            this.btn_ausente.Size = new System.Drawing.Size(191, 45);
            this.btn_ausente.TabIndex = 10;
            this.btn_ausente.Text = "NO ESTA PRESENTE";
            this.btn_ausente.UseVisualStyleBackColor = false;
            this.btn_ausente.Visible = false;
            this.btn_ausente.Click += new System.EventHandler(this.btn_ausente_Click);
            // 
            // lbldepacontrol
            // 
            this.lbldepacontrol.AutoSize = true;
            this.lbldepacontrol.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldepacontrol.Location = new System.Drawing.Point(14, 30);
            this.lbldepacontrol.Name = "lbldepacontrol";
            this.lbldepacontrol.Size = new System.Drawing.Size(0, 15);
            this.lbldepacontrol.TabIndex = 11;
            this.lbldepacontrol.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gridPremios
            // 
            this.gridPremios.AllowUserToAddRows = false;
            this.gridPremios.AllowUserToDeleteRows = false;
            this.gridPremios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPremios.Location = new System.Drawing.Point(477, 346);
            this.gridPremios.Name = "gridPremios";
            this.gridPremios.ReadOnly = true;
            this.gridPremios.Size = new System.Drawing.Size(311, 181);
            this.gridPremios.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(483, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Lista de Premios";
            // 
            // btn_agregar_xls_empleados
            // 
            this.btn_agregar_xls_empleados.Location = new System.Drawing.Point(713, 36);
            this.btn_agregar_xls_empleados.Name = "btn_agregar_xls_empleados";
            this.btn_agregar_xls_empleados.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar_xls_empleados.TabIndex = 14;
            this.btn_agregar_xls_empleados.Text = "Agregar";
            this.btn_agregar_xls_empleados.UseVisualStyleBackColor = true;
            this.btn_agregar_xls_empleados.Click += new System.EventHandler(this.btn_agregar_xls_empleados_Click);
            // 
            // btn_agregar_xls_premios
            // 
            this.btn_agregar_xls_premios.Location = new System.Drawing.Point(713, 317);
            this.btn_agregar_xls_premios.Name = "btn_agregar_xls_premios";
            this.btn_agregar_xls_premios.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar_xls_premios.TabIndex = 15;
            this.btn_agregar_xls_premios.Text = "Agregar";
            this.btn_agregar_xls_premios.UseVisualStyleBackColor = true;
            this.btn_agregar_xls_premios.Click += new System.EventHandler(this.btn_agregar_xls_premios_Click);
            // 
            // Historial_Ganadores
            // 
            this.Historial_Ganadores.AllowUserToAddRows = false;
            this.Historial_Ganadores.AllowUserToDeleteRows = false;
            this.Historial_Ganadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Historial_Ganadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Departamento,
            this.Nombre,
            this.Premio,
            this.na});
            this.Historial_Ganadores.Location = new System.Drawing.Point(17, 346);
            this.Historial_Ganadores.Name = "Historial_Ganadores";
            this.Historial_Ganadores.ReadOnly = true;
            this.Historial_Ganadores.Size = new System.Drawing.Size(454, 181);
            this.Historial_Ganadores.TabIndex = 16;
            // 
            // Departamento
            // 
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.Name = "Departamento";
            this.Departamento.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Premio
            // 
            this.Premio.HeaderText = "Premio";
            this.Premio.Name = "Premio";
            this.Premio.ReadOnly = true;
            // 
            // na
            // 
            this.na.HeaderText = "n/a";
            this.na.Name = "na";
            this.na.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Historial de Ganadores";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(16, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 38);
            this.button1.TabIndex = 18;
            this.button1.Text = "Buscar Premio";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Maroon;
            this.btn_salir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_salir.Location = new System.Drawing.Point(326, 203);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(78, 82);
            this.btn_salir.TabIndex = 19;
            this.btn_salir.Text = "Salir del Sistema";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // vControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 556);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Historial_Ganadores);
            this.Controls.Add(this.btn_agregar_xls_premios);
            this.Controls.Add(this.btn_agregar_xls_empleados);
            this.Controls.Add(this.gridPremios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbldepacontrol);
            this.Controls.Add(this.btn_ausente);
            this.Controls.Add(this.btn_presente);
            this.Controls.Add(this.btnExportarExcel);
            this.Controls.Add(this.lblGanadorEmp);
            this.Controls.Add(this.gridGanadores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_get_empleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "vControl";
            this.Text = "vControl";
            this.Load += new System.EventHandler(this.vControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridGanadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPremios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Historial_Ganadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_get_empleados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridGanadores;
        private System.Windows.Forms.Label lblGanadorEmp;
        private System.Windows.Forms.Button btn_presente;
        private System.Windows.Forms.Button btn_ausente;
        private System.Windows.Forms.Label lbldepacontrol;
        public System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView gridPremios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_agregar_xls_empleados;
        private System.Windows.Forms.Button btn_agregar_xls_premios;
        private System.Windows.Forms.DataGridView Historial_Ganadores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Premio;
        private System.Windows.Forms.DataGridViewTextBoxColumn na;
        private System.Windows.Forms.Button btn_salir;
    }
}