namespace Cotizador.Presentacion
{
    partial class PanelVista
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
            this.lblCotizaciones = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalCamionetas = new System.Windows.Forms.Label();
            this.lblTotalAutos = new System.Windows.Forms.Label();
            this.lblCamionetas = new System.Windows.Forms.Label();
            this.lblAutos = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCotizaciones
            // 
            this.lblCotizaciones.AutoSize = true;
            this.lblCotizaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCotizaciones.Location = new System.Drawing.Point(93, 38);
            this.lblCotizaciones.Name = "lblCotizaciones";
            this.lblCotizaciones.Size = new System.Drawing.Size(151, 29);
            this.lblCotizaciones.TabIndex = 0;
            this.lblCotizaciones.Text = "Cotizaciones";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.lblTotalCamionetas);
            this.panel1.Controls.Add(this.lblTotalAutos);
            this.panel1.Controls.Add(this.lblCamionetas);
            this.panel1.Controls.Add(this.lblAutos);
            this.panel1.Location = new System.Drawing.Point(17, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 133);
            this.panel1.TabIndex = 5;
            // 
            // lblTotalCamionetas
            // 
            this.lblTotalCamionetas.AutoSize = true;
            this.lblTotalCamionetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCamionetas.Location = new System.Drawing.Point(271, 91);
            this.lblTotalCamionetas.Name = "lblTotalCamionetas";
            this.lblTotalCamionetas.Size = new System.Drawing.Size(20, 24);
            this.lblTotalCamionetas.TabIndex = 8;
            this.lblTotalCamionetas.Text = "0";
            // 
            // lblTotalAutos
            // 
            this.lblTotalAutos.AutoSize = true;
            this.lblTotalAutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAutos.Location = new System.Drawing.Point(271, 20);
            this.lblTotalAutos.Name = "lblTotalAutos";
            this.lblTotalAutos.Size = new System.Drawing.Size(20, 24);
            this.lblTotalAutos.TabIndex = 7;
            this.lblTotalAutos.Text = "0";
            // 
            // lblCamionetas
            // 
            this.lblCamionetas.AutoSize = true;
            this.lblCamionetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamionetas.Location = new System.Drawing.Point(13, 91);
            this.lblCamionetas.Name = "lblCamionetas";
            this.lblCamionetas.Size = new System.Drawing.Size(109, 24);
            this.lblCamionetas.TabIndex = 6;
            this.lblCamionetas.Text = "Camionetas";
            // 
            // lblAutos
            // 
            this.lblAutos.AutoSize = true;
            this.lblAutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutos.Location = new System.Drawing.Point(13, 20);
            this.lblAutos.Name = "lblAutos";
            this.lblAutos.Size = new System.Drawing.Size(58, 24);
            this.lblAutos.TabIndex = 5;
            this.lblAutos.Text = "Autos";
            // 
            // PanelVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 263);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCotizaciones);
            this.Name = "PanelVista";
            this.Text = "Panel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCotizaciones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalCamionetas;
        private System.Windows.Forms.Label lblTotalAutos;
        private System.Windows.Forms.Label lblCamionetas;
        private System.Windows.Forms.Label lblAutos;
    }
}

