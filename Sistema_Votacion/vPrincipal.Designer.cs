namespace Sistema_Votacion
{
    partial class vPrincipal
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
            this.btn_start_sorteo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_config = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_start_sorteo
            // 
            this.btn_start_sorteo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_start_sorteo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_start_sorteo.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn_start_sorteo.FlatAppearance.BorderSize = 2;
            this.btn_start_sorteo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start_sorteo.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start_sorteo.ForeColor = System.Drawing.Color.White;
            this.btn_start_sorteo.Location = new System.Drawing.Point(12, 75);
            this.btn_start_sorteo.Name = "btn_start_sorteo";
            this.btn_start_sorteo.Size = new System.Drawing.Size(256, 216);
            this.btn_start_sorteo.TabIndex = 0;
            this.btn_start_sorteo.Text = "COMENZAR";
            this.btn_start_sorteo.UseVisualStyleBackColor = false;
            this.btn_start_sorteo.Click += new System.EventHandler(this.btn_start_sorteo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Heiti Std R", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione la Accion que desea hacer:";
            // 
            // btn_config
            // 
            this.btn_config.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_config.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_config.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn_config.FlatAppearance.BorderSize = 2;
            this.btn_config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_config.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_config.ForeColor = System.Drawing.Color.White;
            this.btn_config.Location = new System.Drawing.Point(274, 75);
            this.btn_config.Name = "btn_config";
            this.btn_config.Size = new System.Drawing.Size(256, 216);
            this.btn_config.TabIndex = 3;
            this.btn_config.Text = "CONFIGURAR";
            this.btn_config.UseVisualStyleBackColor = false;
            this.btn_config.Click += new System.EventHandler(this.btn_config_Click);
            // 
            // vPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(542, 303);
            this.Controls.Add(this.btn_config);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_start_sorteo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "vPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Votacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start_sorteo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_config;
    }
}

