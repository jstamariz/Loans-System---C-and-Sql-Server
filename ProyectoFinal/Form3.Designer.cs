namespace ProyectoFinal
{
    partial class MLoans
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
            this.DeleteClient = new System.Windows.Forms.Button();
            this.AddClient = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.IdPrestamo = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SeeDebts = new System.Windows.Forms.Button();
            this.SummitSeach = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteClient
            // 
            this.DeleteClient.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteClient.ForeColor = System.Drawing.Color.Black;
            this.DeleteClient.Location = new System.Drawing.Point(157, 240);
            this.DeleteClient.Name = "DeleteClient";
            this.DeleteClient.Size = new System.Drawing.Size(85, 53);
            this.DeleteClient.TabIndex = 5;
            this.DeleteClient.Text = "Pago de Prestamo";
            this.DeleteClient.UseVisualStyleBackColor = true;
            this.DeleteClient.Click += new System.EventHandler(this.DeleteClient_Click);
            // 
            // AddClient
            // 
            this.AddClient.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddClient.Location = new System.Drawing.Point(255, 240);
            this.AddClient.Name = "AddClient";
            this.AddClient.Size = new System.Drawing.Size(85, 53);
            this.AddClient.TabIndex = 4;
            this.AddClient.Text = "Agregar Prestamo";
            this.AddClient.UseVisualStyleBackColor = true;
            this.AddClient.Click += new System.EventHandler(this.AddClient_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(388, 182);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(50, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Lista de Prestamos";
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.DarkRed;
            this.Back.Location = new System.Drawing.Point(58, 240);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(85, 53);
            this.Back.TabIndex = 10;
            this.Back.Text = "<- Atras";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.button1_Click);
            // 
            // IdPrestamo
            // 
            this.IdPrestamo.Location = new System.Drawing.Point(167, 392);
            this.IdPrestamo.Name = "IdPrestamo";
            this.IdPrestamo.Size = new System.Drawing.Size(101, 20);
            this.IdPrestamo.TabIndex = 19;
            this.IdPrestamo.TextChanged += new System.EventHandler(this.IdPrestamo_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(54, 333);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(388, 50);
            this.dataGridView2.TabIndex = 18;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(54, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Consultar Deuda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(54, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "id Prestamo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SeeDebts
            // 
            this.SeeDebts.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeeDebts.Location = new System.Drawing.Point(274, 389);
            this.SeeDebts.Name = "SeeDebts";
            this.SeeDebts.Size = new System.Drawing.Size(168, 32);
            this.SeeDebts.TabIndex = 22;
            this.SeeDebts.Text = "Consultar";
            this.SeeDebts.UseVisualStyleBackColor = true;
            this.SeeDebts.Click += new System.EventHandler(this.SeeDebts_Click);
            // 
            // SummitSeach
            // 
            this.SummitSeach.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummitSeach.Location = new System.Drawing.Point(389, 12);
            this.SummitSeach.Name = "SummitSeach";
            this.SummitSeach.Size = new System.Drawing.Size(53, 20);
            this.SummitSeach.TabIndex = 24;
            this.SummitSeach.Text = "Buscar";
            this.SummitSeach.UseVisualStyleBackColor = true;
            this.SummitSeach.Click += new System.EventHandler(this.SummitSeach_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(219, 12);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(164, 20);
            this.Search.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkRed;
            this.button2.Location = new System.Drawing.Point(355, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 53);
            this.button2.TabIndex = 25;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MLoans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(499, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SummitSeach);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SeeDebts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdPrestamo);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DeleteClient);
            this.Controls.Add(this.AddClient);
            this.Name = "MLoans";
            this.Text = "Modulo de Prestamos";
            this.Load += new System.EventHandler(this.MLoans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DeleteClient;
        private System.Windows.Forms.Button AddClient;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox IdPrestamo;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SeeDebts;
        private System.Windows.Forms.Button SummitSeach;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Button button2;
    }
}