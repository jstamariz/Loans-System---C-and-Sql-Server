namespace ProyectoFinal
{
    partial class AddClients
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
            this.CreateClient = new System.Windows.Forms.Button();
            this.UpdateClient = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ClientName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Dir = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Pho = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CreateClient
            // 
            this.CreateClient.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateClient.Location = new System.Drawing.Point(12, 219);
            this.CreateClient.Name = "CreateClient";
            this.CreateClient.Size = new System.Drawing.Size(128, 30);
            this.CreateClient.TabIndex = 4;
            this.CreateClient.Text = "Crear Cliente";
            this.CreateClient.UseVisualStyleBackColor = true;
            this.CreateClient.Click += new System.EventHandler(this.CreateClient_Click);
            // 
            // UpdateClient
            // 
            this.UpdateClient.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateClient.Location = new System.Drawing.Point(146, 219);
            this.UpdateClient.Name = "UpdateClient";
            this.UpdateClient.Size = new System.Drawing.Size(128, 30);
            this.UpdateClient.TabIndex = 5;
            this.UpdateClient.Text = "Modificar Cliente";
            this.UpdateClient.UseVisualStyleBackColor = true;
            this.UpdateClient.Click += new System.EventHandler(this.UpdateClient_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(12, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nombre";
            // 
            // ClientName
            // 
            this.ClientName.Location = new System.Drawing.Point(16, 45);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(240, 20);
            this.ClientName.TabIndex = 6;
            this.ClientName.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(12, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Direccion";
            // 
            // Dir
            // 
            this.Dir.Location = new System.Drawing.Point(16, 102);
            this.Dir.Name = "Dir";
            this.Dir.Size = new System.Drawing.Size(244, 20);
            this.Dir.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(12, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 19);
            this.label9.TabIndex = 11;
            this.label9.Text = "Telefono";
            // 
            // Pho
            // 
            this.Pho.Location = new System.Drawing.Point(16, 161);
            this.Pho.Name = "Pho";
            this.Pho.Size = new System.Drawing.Size(173, 20);
            this.Pho.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(191, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "ID";
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(195, 161);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(61, 20);
            this.Id.TabIndex = 12;
            // 
            // AddClients
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Pho);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Dir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ClientName);
            this.Controls.Add(this.UpdateClient);
            this.Controls.Add(this.CreateClient);
            this.Name = "AddClients";
            this.Text = "Crear / Modificar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Direction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CreateClient;
        private System.Windows.Forms.Button UpdateClient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ClientName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Dir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Pho;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Id;
    }
}