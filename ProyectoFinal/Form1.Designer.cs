namespace ProyectoFinal
{
    partial class Home
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
            this.BLoans = new System.Windows.Forms.Button();
            this.BClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BLoans
            // 
            this.BLoans.BackColor = System.Drawing.SystemColors.ControlText;
            this.BLoans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BLoans.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BLoans.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLoans.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BLoans.Location = new System.Drawing.Point(280, 289);
            this.BLoans.Name = "BLoans";
            this.BLoans.Size = new System.Drawing.Size(248, 44);
            this.BLoans.TabIndex = 0;
            this.BLoans.Text = "Modulo de Prestamos";
            this.BLoans.UseVisualStyleBackColor = false;
            this.BLoans.Click += new System.EventHandler(this.button1_Click);
            // 
            // BClient
            // 
            this.BClient.BackColor = System.Drawing.SystemColors.ControlText;
            this.BClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BClient.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BClient.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BClient.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BClient.Location = new System.Drawing.Point(280, 232);
            this.BClient.Name = "BClient";
            this.BClient.Size = new System.Drawing.Size(248, 44);
            this.BClient.TabIndex = 1;
            this.BClient.Text = "Modulo de Clientes";
            this.BClient.UseVisualStyleBackColor = false;
            this.BClient.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(159, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "SISTEMA DE PRESTAMOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BClient);
            this.Controls.Add(this.BLoans);
            this.Name = "Home";
            this.Text = "Sistema de Prestamos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BLoans;
        private System.Windows.Forms.Button BClient;
        private System.Windows.Forms.Label label1;
    }
}

