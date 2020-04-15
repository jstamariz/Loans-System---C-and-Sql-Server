namespace ProyectoFinal
{
    partial class MClientes
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
            this.AddClient = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.List = new System.Windows.Forms.Button();
            this.DeleteCl = new System.Windows.Forms.Button();
            this.ModCl = new System.Windows.Forms.Button();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddClient
            // 
            this.AddClient.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddClient.Location = new System.Drawing.Point(124, 369);
            this.AddClient.Name = "AddClient";
            this.AddClient.Size = new System.Drawing.Size(82, 58);
            this.AddClient.TabIndex = 0;
            this.AddClient.Text = "Agregar Cliente";
            this.AddClient.UseVisualStyleBackColor = true;
            this.AddClient.Click += new System.EventHandler(this.AddClient_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.DarkRed;
            this.Back.Location = new System.Drawing.Point(40, 369);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(81, 58);
            this.Back.TabIndex = 3;
            this.Back.Text = " <- Atras";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.ListClient_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(381, 280);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(53, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Lista de Clientes";
            // 
            // List
            // 
            this.List.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.List.Location = new System.Drawing.Point(209, 369);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(81, 58);
            this.List.TabIndex = 11;
            this.List.Text = "Listar Clientes";
            this.List.UseVisualStyleBackColor = true;
            this.List.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteCl
            // 
            this.DeleteCl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteCl.ForeColor = System.Drawing.Color.DarkRed;
            this.DeleteCl.Location = new System.Drawing.Point(293, 369);
            this.DeleteCl.Name = "DeleteCl";
            this.DeleteCl.Size = new System.Drawing.Size(81, 58);
            this.DeleteCl.TabIndex = 12;
            this.DeleteCl.Text = "Eliminar";
            this.DeleteCl.UseVisualStyleBackColor = true;
            this.DeleteCl.Click += new System.EventHandler(this.DeleteCl_Click);
            // 
            // ModCl
            // 
            this.ModCl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModCl.Location = new System.Drawing.Point(377, 369);
            this.ModCl.Name = "ModCl";
            this.ModCl.Size = new System.Drawing.Size(81, 58);
            this.ModCl.TabIndex = 13;
            this.ModCl.Text = "Modificar Clientes";
            this.ModCl.UseVisualStyleBackColor = true;
            this.ModCl.Click += new System.EventHandler(this.ModCl_Click);
            // 
            // SearchBar
            // 
            this.SearchBar.Location = new System.Drawing.Point(235, 12);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(164, 20);
            this.SearchBar.TabIndex = 14;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(405, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(53, 20);
            this.button4.TabIndex = 15;
            this.button4.Text = "Buscar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(499, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.ModCl);
            this.Controls.Add(this.DeleteCl);
            this.Controls.Add(this.List);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.AddClient);
            this.Name = "MClientes";
            this.Text = "Modulo De Clientes";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddClient;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button List;
        private System.Windows.Forms.Button DeleteCl;
        private System.Windows.Forms.Button ModCl;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.Button button4;
    }
}