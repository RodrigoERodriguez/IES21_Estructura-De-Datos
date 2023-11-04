namespace pryRodriguezED_Estructuras
{
    partial class frmConsultaEnBaseDeDatos
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
            this.dgvGrillaConsulta = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.txtComandoSQL = new System.Windows.Forms.TextBox();
            this.lblLeyenda = new System.Windows.Forms.Label();
            this.PCentral = new System.Windows.Forms.Panel();
            this.PLateral = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaConsulta)).BeginInit();
            this.PCentral.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGrillaConsulta
            // 
            this.dgvGrillaConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrillaConsulta.Location = new System.Drawing.Point(110, 331);
            this.dgvGrillaConsulta.Name = "dgvGrillaConsulta";
            this.dgvGrillaConsulta.Size = new System.Drawing.Size(915, 200);
            this.dgvGrillaConsulta.TabIndex = 7;
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(900, 264);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(125, 33);
            this.btnListar.TabIndex = 6;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // txtComandoSQL
            // 
            this.txtComandoSQL.Location = new System.Drawing.Point(110, 49);
            this.txtComandoSQL.Multiline = true;
            this.txtComandoSQL.Name = "txtComandoSQL";
            this.txtComandoSQL.Size = new System.Drawing.Size(915, 177);
            this.txtComandoSQL.TabIndex = 5;
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.AutoSize = true;
            this.lblLeyenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeyenda.ForeColor = System.Drawing.Color.White;
            this.lblLeyenda.Location = new System.Drawing.Point(105, 21);
            this.lblLeyenda.Name = "lblLeyenda";
            this.lblLeyenda.Size = new System.Drawing.Size(197, 25);
            this.lblLeyenda.TabIndex = 8;
            this.lblLeyenda.Text = "Consulta en SQL:";
            // 
            // PCentral
            // 
            this.PCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.PCentral.Controls.Add(this.PLateral);
            this.PCentral.Controls.Add(this.lblLeyenda);
            this.PCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PCentral.Location = new System.Drawing.Point(0, 0);
            this.PCentral.Name = "PCentral";
            this.PCentral.Size = new System.Drawing.Size(1037, 543);
            this.PCentral.TabIndex = 26;
            // 
            // PLateral
            // 
            this.PLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(52)))));
            this.PLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PLateral.Location = new System.Drawing.Point(0, 0);
            this.PLateral.Name = "PLateral";
            this.PLateral.Size = new System.Drawing.Size(90, 543);
            this.PLateral.TabIndex = 39;
            // 
            // frmConsultaEnBaseDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 543);
            this.Controls.Add(this.dgvGrillaConsulta);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txtComandoSQL);
            this.Controls.Add(this.PCentral);
            this.Name = "frmConsultaEnBaseDeDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaConsulta)).EndInit();
            this.PCentral.ResumeLayout(false);
            this.PCentral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrillaConsulta;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox txtComandoSQL;
        private System.Windows.Forms.Label lblLeyenda;
        private System.Windows.Forms.Panel PCentral;
        private System.Windows.Forms.Panel PLateral;
    }
}