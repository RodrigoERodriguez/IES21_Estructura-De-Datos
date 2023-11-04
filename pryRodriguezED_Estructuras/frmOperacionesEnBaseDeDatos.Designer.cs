namespace pryRodriguezED_Estructuras
{
    partial class frmOperacionesEnBaseDeDatos
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
            this.PLateral = new System.Windows.Forms.Panel();
            this.mrcOperacionesDeSeleccion = new System.Windows.Forms.GroupBox();
            this.btnSeleccionPorConvolucion = new System.Windows.Forms.Button();
            this.btnSeleccionMultiAtributo = new System.Windows.Forms.Button();
            this.btnSeleccionSimple = new System.Windows.Forms.Button();
            this.mrcOperacionesAlgebraicas = new System.Windows.Forms.GroupBox();
            this.btnDiferencia = new System.Windows.Forms.Button();
            this.btnInterseccion = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            this.mrcOperacionDeProyeccion = new System.Windows.Forms.GroupBox();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.btnProyeccionMultiAtributo = new System.Windows.Forms.Button();
            this.btnProyeccionSimple = new System.Windows.Forms.Button();
            this.dgvBaseDeDatos = new System.Windows.Forms.DataGridView();
            this.PCentral.SuspendLayout();
            this.mrcOperacionesDeSeleccion.SuspendLayout();
            this.mrcOperacionesAlgebraicas.SuspendLayout();
            this.mrcOperacionDeProyeccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDeDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // PCentral
            // 
            this.PCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.PCentral.Controls.Add(this.PLateral);
            this.PCentral.Controls.Add(this.mrcOperacionesDeSeleccion);
            this.PCentral.Controls.Add(this.mrcOperacionesAlgebraicas);
            this.PCentral.Controls.Add(this.mrcOperacionDeProyeccion);
            this.PCentral.Controls.Add(this.dgvBaseDeDatos);
            this.PCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PCentral.Location = new System.Drawing.Point(0, 0);
            this.PCentral.Name = "PCentral";
            this.PCentral.Size = new System.Drawing.Size(1037, 543);
            this.PCentral.TabIndex = 25;
            // 
            // PLateral
            // 
            this.PLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(52)))));
            this.PLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PLateral.Location = new System.Drawing.Point(0, 0);
            this.PLateral.Name = "PLateral";
            this.PLateral.Size = new System.Drawing.Size(90, 543);
            this.PLateral.TabIndex = 35;
            // 
            // mrcOperacionesDeSeleccion
            // 
            this.mrcOperacionesDeSeleccion.Controls.Add(this.btnSeleccionPorConvolucion);
            this.mrcOperacionesDeSeleccion.Controls.Add(this.btnSeleccionMultiAtributo);
            this.mrcOperacionesDeSeleccion.Controls.Add(this.btnSeleccionSimple);
            this.mrcOperacionesDeSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcOperacionesDeSeleccion.ForeColor = System.Drawing.Color.White;
            this.mrcOperacionesDeSeleccion.Location = new System.Drawing.Point(450, 323);
            this.mrcOperacionesDeSeleccion.Name = "mrcOperacionesDeSeleccion";
            this.mrcOperacionesDeSeleccion.Size = new System.Drawing.Size(243, 212);
            this.mrcOperacionesDeSeleccion.TabIndex = 3;
            this.mrcOperacionesDeSeleccion.TabStop = false;
            this.mrcOperacionesDeSeleccion.Text = "Operaciones de Seleccion";
            // 
            // btnSeleccionPorConvolucion
            // 
            this.btnSeleccionPorConvolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionPorConvolucion.ForeColor = System.Drawing.Color.Black;
            this.btnSeleccionPorConvolucion.Location = new System.Drawing.Point(22, 152);
            this.btnSeleccionPorConvolucion.Name = "btnSeleccionPorConvolucion";
            this.btnSeleccionPorConvolucion.Size = new System.Drawing.Size(198, 29);
            this.btnSeleccionPorConvolucion.TabIndex = 5;
            this.btnSeleccionPorConvolucion.Text = "Seleccion por convolucion";
            this.btnSeleccionPorConvolucion.UseVisualStyleBackColor = true;
            this.btnSeleccionPorConvolucion.Click += new System.EventHandler(this.btnSeleccionPorConvolucion_Click);
            // 
            // btnSeleccionMultiAtributo
            // 
            this.btnSeleccionMultiAtributo.ForeColor = System.Drawing.Color.Black;
            this.btnSeleccionMultiAtributo.Location = new System.Drawing.Point(22, 91);
            this.btnSeleccionMultiAtributo.Name = "btnSeleccionMultiAtributo";
            this.btnSeleccionMultiAtributo.Size = new System.Drawing.Size(198, 29);
            this.btnSeleccionMultiAtributo.TabIndex = 4;
            this.btnSeleccionMultiAtributo.Text = "Seleccion Multiatributo";
            this.btnSeleccionMultiAtributo.UseVisualStyleBackColor = true;
            this.btnSeleccionMultiAtributo.Click += new System.EventHandler(this.btnSeleccionMultiAtributo_Click);
            // 
            // btnSeleccionSimple
            // 
            this.btnSeleccionSimple.ForeColor = System.Drawing.Color.Black;
            this.btnSeleccionSimple.Location = new System.Drawing.Point(22, 31);
            this.btnSeleccionSimple.Name = "btnSeleccionSimple";
            this.btnSeleccionSimple.Size = new System.Drawing.Size(198, 29);
            this.btnSeleccionSimple.TabIndex = 3;
            this.btnSeleccionSimple.Text = "Seleccion Simple";
            this.btnSeleccionSimple.UseVisualStyleBackColor = true;
            this.btnSeleccionSimple.Click += new System.EventHandler(this.btnSeleccionSimple_Click);
            // 
            // mrcOperacionesAlgebraicas
            // 
            this.mrcOperacionesAlgebraicas.Controls.Add(this.btnDiferencia);
            this.mrcOperacionesAlgebraicas.Controls.Add(this.btnInterseccion);
            this.mrcOperacionesAlgebraicas.Controls.Add(this.btnUnion);
            this.mrcOperacionesAlgebraicas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcOperacionesAlgebraicas.ForeColor = System.Drawing.Color.White;
            this.mrcOperacionesAlgebraicas.Location = new System.Drawing.Point(776, 323);
            this.mrcOperacionesAlgebraicas.Name = "mrcOperacionesAlgebraicas";
            this.mrcOperacionesAlgebraicas.Size = new System.Drawing.Size(249, 212);
            this.mrcOperacionesAlgebraicas.TabIndex = 2;
            this.mrcOperacionesAlgebraicas.TabStop = false;
            this.mrcOperacionesAlgebraicas.Text = "Operaciones Algebraicas";
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiferencia.ForeColor = System.Drawing.Color.Black;
            this.btnDiferencia.Location = new System.Drawing.Point(25, 152);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(198, 29);
            this.btnDiferencia.TabIndex = 5;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            this.btnDiferencia.Click += new System.EventHandler(this.btnDiferencia_Click);
            // 
            // btnInterseccion
            // 
            this.btnInterseccion.ForeColor = System.Drawing.Color.Black;
            this.btnInterseccion.Location = new System.Drawing.Point(25, 91);
            this.btnInterseccion.Name = "btnInterseccion";
            this.btnInterseccion.Size = new System.Drawing.Size(198, 29);
            this.btnInterseccion.TabIndex = 4;
            this.btnInterseccion.Text = "Interseccion";
            this.btnInterseccion.UseVisualStyleBackColor = true;
            this.btnInterseccion.Click += new System.EventHandler(this.btnInterseccion_Click);
            // 
            // btnUnion
            // 
            this.btnUnion.ForeColor = System.Drawing.Color.Black;
            this.btnUnion.Location = new System.Drawing.Point(25, 31);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(198, 29);
            this.btnUnion.TabIndex = 3;
            this.btnUnion.Text = "Union";
            this.btnUnion.UseVisualStyleBackColor = true;
            this.btnUnion.Click += new System.EventHandler(this.btnUnion_Click);
            // 
            // mrcOperacionDeProyeccion
            // 
            this.mrcOperacionDeProyeccion.Controls.Add(this.btnJuntar);
            this.mrcOperacionDeProyeccion.Controls.Add(this.btnProyeccionMultiAtributo);
            this.mrcOperacionDeProyeccion.Controls.Add(this.btnProyeccionSimple);
            this.mrcOperacionDeProyeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcOperacionDeProyeccion.ForeColor = System.Drawing.Color.White;
            this.mrcOperacionDeProyeccion.Location = new System.Drawing.Point(118, 319);
            this.mrcOperacionDeProyeccion.Name = "mrcOperacionDeProyeccion";
            this.mrcOperacionDeProyeccion.Size = new System.Drawing.Size(245, 212);
            this.mrcOperacionDeProyeccion.TabIndex = 1;
            this.mrcOperacionDeProyeccion.TabStop = false;
            this.mrcOperacionDeProyeccion.Text = "Operaciones de Proyeccion";
            // 
            // btnJuntar
            // 
            this.btnJuntar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJuntar.ForeColor = System.Drawing.Color.Black;
            this.btnJuntar.Location = new System.Drawing.Point(20, 161);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(198, 29);
            this.btnJuntar.TabIndex = 2;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            this.btnJuntar.Click += new System.EventHandler(this.btnJuntar_Click);
            // 
            // btnProyeccionMultiAtributo
            // 
            this.btnProyeccionMultiAtributo.ForeColor = System.Drawing.Color.Black;
            this.btnProyeccionMultiAtributo.Location = new System.Drawing.Point(20, 100);
            this.btnProyeccionMultiAtributo.Name = "btnProyeccionMultiAtributo";
            this.btnProyeccionMultiAtributo.Size = new System.Drawing.Size(198, 29);
            this.btnProyeccionMultiAtributo.TabIndex = 1;
            this.btnProyeccionMultiAtributo.Text = "Proyeccion Multitributo";
            this.btnProyeccionMultiAtributo.UseVisualStyleBackColor = true;
            this.btnProyeccionMultiAtributo.Click += new System.EventHandler(this.btnProyeccionMultiAtributo_Click);
            // 
            // btnProyeccionSimple
            // 
            this.btnProyeccionSimple.ForeColor = System.Drawing.Color.Black;
            this.btnProyeccionSimple.Location = new System.Drawing.Point(20, 40);
            this.btnProyeccionSimple.Name = "btnProyeccionSimple";
            this.btnProyeccionSimple.Size = new System.Drawing.Size(198, 29);
            this.btnProyeccionSimple.TabIndex = 0;
            this.btnProyeccionSimple.Text = "Proyeccion Simple";
            this.btnProyeccionSimple.UseVisualStyleBackColor = true;
            this.btnProyeccionSimple.Click += new System.EventHandler(this.btnProyeccionSimple_Click);
            // 
            // dgvBaseDeDatos
            // 
            this.dgvBaseDeDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaseDeDatos.Location = new System.Drawing.Point(118, 12);
            this.dgvBaseDeDatos.Name = "dgvBaseDeDatos";
            this.dgvBaseDeDatos.Size = new System.Drawing.Size(907, 287);
            this.dgvBaseDeDatos.TabIndex = 0;
            // 
            // frmOperacionesEnBaseDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 543);
            this.Controls.Add(this.PCentral);
            this.Name = "frmOperacionesEnBaseDeDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PCentral.ResumeLayout(false);
            this.mrcOperacionesDeSeleccion.ResumeLayout(false);
            this.mrcOperacionesAlgebraicas.ResumeLayout(false);
            this.mrcOperacionDeProyeccion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDeDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PCentral;
        private System.Windows.Forms.GroupBox mrcOperacionesDeSeleccion;
        private System.Windows.Forms.Button btnSeleccionPorConvolucion;
        private System.Windows.Forms.Button btnSeleccionMultiAtributo;
        private System.Windows.Forms.Button btnSeleccionSimple;
        private System.Windows.Forms.GroupBox mrcOperacionesAlgebraicas;
        private System.Windows.Forms.Button btnDiferencia;
        private System.Windows.Forms.Button btnInterseccion;
        private System.Windows.Forms.Button btnUnion;
        private System.Windows.Forms.GroupBox mrcOperacionDeProyeccion;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.Button btnProyeccionMultiAtributo;
        private System.Windows.Forms.Button btnProyeccionSimple;
        private System.Windows.Forms.DataGridView dgvBaseDeDatos;
        private System.Windows.Forms.Panel PLateral;
    }
}