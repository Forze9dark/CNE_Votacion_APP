namespace Sistema_Votacion
{
    partial class vGeneral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vGeneral));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblEmpleadoName = new System.Windows.Forms.Label();
            this.lblPremioName = new System.Windows.Forms.Label();
            this.aTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDepaGanador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(22, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(318, 144);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lblEmpleadoName
            // 
            this.lblEmpleadoName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmpleadoName.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpleadoName.Font = new System.Drawing.Font("Candara", 50F, System.Drawing.FontStyle.Bold);
            this.lblEmpleadoName.Location = new System.Drawing.Point(-14, 257);
            this.lblEmpleadoName.Name = "lblEmpleadoName";
            this.lblEmpleadoName.Size = new System.Drawing.Size(1007, 92);
            this.lblEmpleadoName.TabIndex = 2;
            this.lblEmpleadoName.Text = "Esperando por Empleado";
            this.lblEmpleadoName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPremioName
            // 
            this.lblPremioName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPremioName.BackColor = System.Drawing.Color.Transparent;
            this.lblPremioName.Font = new System.Drawing.Font("Candara", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPremioName.Location = new System.Drawing.Point(-1, 372);
            this.lblPremioName.Name = "lblPremioName";
            this.lblPremioName.Size = new System.Drawing.Size(980, 56);
            this.lblPremioName.TabIndex = 3;
            this.lblPremioName.Text = "Esperando por premio";
            this.lblPremioName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // aTimer
            // 
            this.aTimer.Enabled = true;
            this.aTimer.Tick += new System.EventHandler(this.aTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-17, 260);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1045, 320);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblDepaGanador
            // 
            this.lblDepaGanador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDepaGanador.BackColor = System.Drawing.Color.Transparent;
            this.lblDepaGanador.Font = new System.Drawing.Font("Candara", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepaGanador.Location = new System.Drawing.Point(-1, 201);
            this.lblDepaGanador.Name = "lblDepaGanador";
            this.lblDepaGanador.Size = new System.Drawing.Size(980, 56);
            this.lblDepaGanador.TabIndex = 5;
            this.lblDepaGanador.Text = "Esperando por premio";
            this.lblDepaGanador.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // vGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(994, 567);
            this.Controls.Add(this.lblDepaGanador);
            this.Controls.Add(this.lblEmpleadoName);
            this.Controls.Add(this.lblPremioName);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "vGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vGeneral";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblEmpleadoName;
        private System.Windows.Forms.Label lblPremioName;
        private System.Windows.Forms.Timer aTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDepaGanador;
    }
}