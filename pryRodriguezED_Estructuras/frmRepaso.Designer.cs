namespace pryRodriguezED_Estructuras
{
    partial class frmRepaso
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
            this.PCentral = new System.Windows.Forms.Panel();
            this.lblLeyenda = new System.Windows.Forms.Label();
            this.cbCriterios = new System.Windows.Forms.ComboBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.txtLeyenda = new System.Windows.Forms.TextBox();
            this.dgvGrillaConsulta = new System.Windows.Forms.DataGridView();
            this.PLateral = new System.Windows.Forms.Panel();
            this.PCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // PCentral
            // 
            this.PCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.PCentral.Controls.Add(this.lblLeyenda);
            this.PCentral.Controls.Add(this.cbCriterios);
            this.PCentral.Controls.Add(this.btnListar);
            this.PCentral.Controls.Add(this.txtLeyenda);
            this.PCentral.Controls.Add(this.dgvGrillaConsulta);
            this.PCentral.Controls.Add(this.PLateral);
            this.PCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PCentral.Location = new System.Drawing.Point(0, 0);
            this.PCentral.Name = "PCentral";
            this.PCentral.Size = new System.Drawing.Size(1037, 543);
            this.PCentral.TabIndex = 25;
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.AutoSize = true;
            this.lblLeyenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeyenda.ForeColor = System.Drawing.Color.White;
            this.lblLeyenda.Location = new System.Drawing.Point(113, 54);
            this.lblLeyenda.Name = "lblLeyenda";
            this.lblLeyenda.Size = new System.Drawing.Size(448, 25);
            this.lblLeyenda.TabIndex = 50;
            this.lblLeyenda.Text = "Operacion a realizar en la base de datos:";
            // 
            // cbCriterios
            // 
            this.cbCriterios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCriterios.FormattingEnabled = true;
            this.cbCriterios.Items.AddRange(new object[] {
            "Proyeccion Simple",
            "Proyeccion MultiAtributo",
            "Juntar",
            "Seleccion Simple",
            "Seleccion MultiAtributo con Operador AND",
            "Seleccion MultiAtributo con Operador OR",
            "Seleccion MultiAtributo por Convolucion",
            "Union",
            "Interseccion",
            "Diferencia"});
            this.cbCriterios.Location = new System.Drawing.Point(567, 58);
            this.cbCriterios.Name = "cbCriterios";
            this.cbCriterios.Size = new System.Drawing.Size(303, 21);
            this.cbCriterios.TabIndex = 49;
            this.cbCriterios.SelectedIndexChanged += new System.EventHandler(this.cbCriterios_SelectedIndexChanged);
            // 
            // btnListar
            // 
            this.btnListar.Enabled = false;
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(900, 51);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(125, 33);
            this.btnListar.TabIndex = 48;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // txtLeyenda
            // 
            this.txtLeyenda.Location = new System.Drawing.Point(118, 126);
            this.txtLeyenda.Multiline = true;
            this.txtLeyenda.Name = "txtLeyenda";
            this.txtLeyenda.Size = new System.Drawing.Size(907, 177);
            this.txtLeyenda.TabIndex = 47;
            // 
            // dgvGrillaConsulta
            // 
            this.dgvGrillaConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrillaConsulta.Location = new System.Drawing.Point(118, 335);
            this.dgvGrillaConsulta.Name = "dgvGrillaConsulta";
            this.dgvGrillaConsulta.Size = new System.Drawing.Size(907, 196);
            this.dgvGrillaConsulta.TabIndex = 46;
            // 
            // PLateral
            // 
            this.PLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(52)))));
            this.PLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PLateral.Location = new System.Drawing.Point(0, 0);
            this.PLateral.Name = "PLateral";
            this.PLateral.Size = new System.Drawing.Size(90, 543);
            this.PLateral.TabIndex = 45;
            // 
            // frmRepaso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 543);
            this.Controls.Add(this.PCentral);
            this.Name = "frmRepaso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PCentral.ResumeLayout(false);
            this.PCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PCentral;
        private System.Windows.Forms.Panel PLateral;
        private System.Windows.Forms.DataGridView dgvGrillaConsulta;
        private System.Windows.Forms.TextBox txtLeyenda;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ComboBox cbCriterios;
        private System.Windows.Forms.Label lblLeyenda;
    }
}