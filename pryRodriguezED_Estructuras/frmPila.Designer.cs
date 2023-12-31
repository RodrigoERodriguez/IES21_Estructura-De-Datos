﻿namespace pryRodriguezED_Estructuras
{
    partial class frmPila
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPila));
            this.PLateral = new System.Windows.Forms.Panel();
            this.PCentral = new System.Windows.Forms.Panel();
            this.PBImagen = new System.Windows.Forms.PictureBox();
            this.mrcElementoEliminado = new System.Windows.Forms.GroupBox();
            this.lblTramiteInfo = new System.Windows.Forms.Label();
            this.lblNombreInfo = new System.Windows.Forms.Label();
            this.lblCodigoInfo = new System.Windows.Forms.Label();
            this.lblTramiteEE = new System.Windows.Forms.Label();
            this.lblNombreEE = new System.Windows.Forms.Label();
            this.lblCodigoEE = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.mrcNuevoElemento = new System.Windows.Forms.GroupBox();
            this.txtTramiteNE = new System.Windows.Forms.TextBox();
            this.txtNombreNE = new System.Windows.Forms.TextBox();
            this.txtCodigoNE = new System.Windows.Forms.TextBox();
            this.lblTramiteNE = new System.Windows.Forms.Label();
            this.lblNombreNE = new System.Windows.Forms.Label();
            this.lblCodigoNE = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.mrcListado = new System.Windows.Forms.GroupBox();
            this.lstListado = new System.Windows.Forms.ListBox();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagen)).BeginInit();
            this.mrcElementoEliminado.SuspendLayout();
            this.mrcNuevoElemento.SuspendLayout();
            this.mrcListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // PLateral
            // 
            this.PLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(52)))));
            this.PLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PLateral.Location = new System.Drawing.Point(0, 0);
            this.PLateral.Name = "PLateral";
            this.PLateral.Size = new System.Drawing.Size(90, 543);
            this.PLateral.TabIndex = 42;
            // 
            // PCentral
            // 
            this.PCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.PCentral.Controls.Add(this.PBImagen);
            this.PCentral.Controls.Add(this.mrcElementoEliminado);
            this.PCentral.Controls.Add(this.mrcNuevoElemento);
            this.PCentral.Controls.Add(this.mrcListado);
            this.PCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PCentral.Location = new System.Drawing.Point(0, 0);
            this.PCentral.Name = "PCentral";
            this.PCentral.Size = new System.Drawing.Size(1037, 543);
            this.PCentral.TabIndex = 47;
            // 
            // PBImagen
            // 
            this.PBImagen.BackColor = System.Drawing.Color.White;
            this.PBImagen.Image = ((System.Drawing.Image)(resources.GetObject("PBImagen.Image")));
            this.PBImagen.Location = new System.Drawing.Point(133, 43);
            this.PBImagen.Name = "PBImagen";
            this.PBImagen.Size = new System.Drawing.Size(217, 216);
            this.PBImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBImagen.TabIndex = 45;
            this.PBImagen.TabStop = false;
            // 
            // mrcElementoEliminado
            // 
            this.mrcElementoEliminado.Controls.Add(this.lblTramiteInfo);
            this.mrcElementoEliminado.Controls.Add(this.lblNombreInfo);
            this.mrcElementoEliminado.Controls.Add(this.lblCodigoInfo);
            this.mrcElementoEliminado.Controls.Add(this.lblTramiteEE);
            this.mrcElementoEliminado.Controls.Add(this.lblNombreEE);
            this.mrcElementoEliminado.Controls.Add(this.lblCodigoEE);
            this.mrcElementoEliminado.Controls.Add(this.btnEliminar);
            this.mrcElementoEliminado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcElementoEliminado.ForeColor = System.Drawing.Color.White;
            this.mrcElementoEliminado.Location = new System.Drawing.Point(724, 43);
            this.mrcElementoEliminado.Name = "mrcElementoEliminado";
            this.mrcElementoEliminado.Size = new System.Drawing.Size(273, 222);
            this.mrcElementoEliminado.TabIndex = 44;
            this.mrcElementoEliminado.TabStop = false;
            this.mrcElementoEliminado.Text = "Elemento eliminado";
            // 
            // lblTramiteInfo
            // 
            this.lblTramiteInfo.BackColor = System.Drawing.Color.White;
            this.lblTramiteInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTramiteInfo.Location = new System.Drawing.Point(147, 124);
            this.lblTramiteInfo.Name = "lblTramiteInfo";
            this.lblTramiteInfo.Size = new System.Drawing.Size(100, 21);
            this.lblTramiteInfo.TabIndex = 7;
            this.lblTramiteInfo.Click += new System.EventHandler(this.lblTramiteInfo_Click);
            // 
            // lblNombreInfo
            // 
            this.lblNombreInfo.BackColor = System.Drawing.Color.White;
            this.lblNombreInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreInfo.Location = new System.Drawing.Point(147, 80);
            this.lblNombreInfo.Name = "lblNombreInfo";
            this.lblNombreInfo.Size = new System.Drawing.Size(100, 21);
            this.lblNombreInfo.TabIndex = 6;
            this.lblNombreInfo.Click += new System.EventHandler(this.lblNombreInfo_Click);
            // 
            // lblCodigoInfo
            // 
            this.lblCodigoInfo.BackColor = System.Drawing.Color.White;
            this.lblCodigoInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigoInfo.Location = new System.Drawing.Point(147, 34);
            this.lblCodigoInfo.Name = "lblCodigoInfo";
            this.lblCodigoInfo.Size = new System.Drawing.Size(100, 21);
            this.lblCodigoInfo.TabIndex = 5;
            this.lblCodigoInfo.Click += new System.EventHandler(this.lblCodigoInfo_Click);
            // 
            // lblTramiteEE
            // 
            this.lblTramiteEE.AutoSize = true;
            this.lblTramiteEE.Location = new System.Drawing.Point(32, 126);
            this.lblTramiteEE.Name = "lblTramiteEE";
            this.lblTramiteEE.Size = new System.Drawing.Size(60, 15);
            this.lblTramiteEE.TabIndex = 4;
            this.lblTramiteEE.Text = "Tramite:";
            // 
            // lblNombreEE
            // 
            this.lblNombreEE.AutoSize = true;
            this.lblNombreEE.Location = new System.Drawing.Point(32, 82);
            this.lblNombreEE.Name = "lblNombreEE";
            this.lblNombreEE.Size = new System.Drawing.Size(62, 15);
            this.lblNombreEE.TabIndex = 3;
            this.lblNombreEE.Text = "Nombre:";
            // 
            // lblCodigoEE
            // 
            this.lblCodigoEE.AutoSize = true;
            this.lblCodigoEE.Location = new System.Drawing.Point(32, 36);
            this.lblCodigoEE.Name = "lblCodigoEE";
            this.lblCodigoEE.Size = new System.Drawing.Size(56, 15);
            this.lblCodigoEE.TabIndex = 2;
            this.lblCodigoEE.Text = "Codigo:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(35, 174);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(213, 32);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // mrcNuevoElemento
            // 
            this.mrcNuevoElemento.Controls.Add(this.txtTramiteNE);
            this.mrcNuevoElemento.Controls.Add(this.txtNombreNE);
            this.mrcNuevoElemento.Controls.Add(this.txtCodigoNE);
            this.mrcNuevoElemento.Controls.Add(this.lblTramiteNE);
            this.mrcNuevoElemento.Controls.Add(this.lblNombreNE);
            this.mrcNuevoElemento.Controls.Add(this.lblCodigoNE);
            this.mrcNuevoElemento.Controls.Add(this.btnAgregar);
            this.mrcNuevoElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcNuevoElemento.ForeColor = System.Drawing.Color.White;
            this.mrcNuevoElemento.Location = new System.Drawing.Point(405, 43);
            this.mrcNuevoElemento.Name = "mrcNuevoElemento";
            this.mrcNuevoElemento.Size = new System.Drawing.Size(273, 222);
            this.mrcNuevoElemento.TabIndex = 43;
            this.mrcNuevoElemento.TabStop = false;
            this.mrcNuevoElemento.Text = "Nuevo elemento";
            // 
            // txtTramiteNE
            // 
            this.txtTramiteNE.BackColor = System.Drawing.Color.White;
            this.txtTramiteNE.Location = new System.Drawing.Point(138, 123);
            this.txtTramiteNE.Name = "txtTramiteNE";
            this.txtTramiteNE.Size = new System.Drawing.Size(100, 21);
            this.txtTramiteNE.TabIndex = 6;
            this.txtTramiteNE.TextChanged += new System.EventHandler(this.txtTramiteNE_TextChanged);
            this.txtTramiteNE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTramiteNE_KeyPress);
            // 
            // txtNombreNE
            // 
            this.txtNombreNE.BackColor = System.Drawing.Color.White;
            this.txtNombreNE.Location = new System.Drawing.Point(138, 82);
            this.txtNombreNE.Name = "txtNombreNE";
            this.txtNombreNE.Size = new System.Drawing.Size(100, 21);
            this.txtNombreNE.TabIndex = 5;
            this.txtNombreNE.TextChanged += new System.EventHandler(this.txtNombreNE_TextChanged);
            this.txtNombreNE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreNE_KeyPress);
            // 
            // txtCodigoNE
            // 
            this.txtCodigoNE.BackColor = System.Drawing.Color.White;
            this.txtCodigoNE.Location = new System.Drawing.Point(138, 36);
            this.txtCodigoNE.Name = "txtCodigoNE";
            this.txtCodigoNE.Size = new System.Drawing.Size(100, 21);
            this.txtCodigoNE.TabIndex = 4;
            this.txtCodigoNE.TextChanged += new System.EventHandler(this.txtCodigoNE_TextChanged);
            this.txtCodigoNE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoNE_KeyPress);
            // 
            // lblTramiteNE
            // 
            this.lblTramiteNE.AutoSize = true;
            this.lblTramiteNE.Location = new System.Drawing.Point(18, 126);
            this.lblTramiteNE.Name = "lblTramiteNE";
            this.lblTramiteNE.Size = new System.Drawing.Size(60, 15);
            this.lblTramiteNE.TabIndex = 3;
            this.lblTramiteNE.Text = "Tramite:";
            // 
            // lblNombreNE
            // 
            this.lblNombreNE.AutoSize = true;
            this.lblNombreNE.Location = new System.Drawing.Point(18, 82);
            this.lblNombreNE.Name = "lblNombreNE";
            this.lblNombreNE.Size = new System.Drawing.Size(62, 15);
            this.lblNombreNE.TabIndex = 2;
            this.lblNombreNE.Text = "Nombre:";
            // 
            // lblCodigoNE
            // 
            this.lblCodigoNE.AutoSize = true;
            this.lblCodigoNE.Location = new System.Drawing.Point(18, 36);
            this.lblCodigoNE.Name = "lblCodigoNE";
            this.lblCodigoNE.Size = new System.Drawing.Size(56, 15);
            this.lblCodigoNE.TabIndex = 1;
            this.lblCodigoNE.Text = "Codigo:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Lime;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Enabled = false;
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(29, 174);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(213, 32);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // mrcListado
            // 
            this.mrcListado.Controls.Add(this.lstListado);
            this.mrcListado.Controls.Add(this.dgvGrilla);
            this.mrcListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcListado.ForeColor = System.Drawing.Color.White;
            this.mrcListado.Location = new System.Drawing.Point(113, 305);
            this.mrcListado.Name = "mrcListado";
            this.mrcListado.Size = new System.Drawing.Size(884, 196);
            this.mrcListado.TabIndex = 42;
            this.mrcListado.TabStop = false;
            this.mrcListado.Text = "Listado en una lista y una grilla";
            // 
            // lstListado
            // 
            this.lstListado.FormattingEnabled = true;
            this.lstListado.ItemHeight = 15;
            this.lstListado.Location = new System.Drawing.Point(20, 30);
            this.lstListado.Name = "lstListado";
            this.lstListado.Size = new System.Drawing.Size(222, 139);
            this.lstListado.TabIndex = 1;
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Tramite});
            this.dgvGrilla.Location = new System.Drawing.Point(315, 30);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.Size = new System.Drawing.Size(538, 139);
            this.dgvGrilla.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Tramite
            // 
            this.Tramite.HeaderText = "Tramite";
            this.Tramite.Name = "Tramite";
            // 
            // frmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 543);
            this.Controls.Add(this.PLateral);
            this.Controls.Add(this.PCentral);
            this.Name = "frmPila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBImagen)).EndInit();
            this.mrcElementoEliminado.ResumeLayout(false);
            this.mrcElementoEliminado.PerformLayout();
            this.mrcNuevoElemento.ResumeLayout(false);
            this.mrcNuevoElemento.PerformLayout();
            this.mrcListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PLateral;
        private System.Windows.Forms.Panel PCentral;
        private System.Windows.Forms.PictureBox PBImagen;
        private System.Windows.Forms.GroupBox mrcElementoEliminado;
        private System.Windows.Forms.Label lblTramiteInfo;
        private System.Windows.Forms.Label lblNombreInfo;
        private System.Windows.Forms.Label lblCodigoInfo;
        private System.Windows.Forms.Label lblTramiteEE;
        private System.Windows.Forms.Label lblNombreEE;
        private System.Windows.Forms.Label lblCodigoEE;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox mrcNuevoElemento;
        private System.Windows.Forms.TextBox txtTramiteNE;
        private System.Windows.Forms.TextBox txtNombreNE;
        private System.Windows.Forms.TextBox txtCodigoNE;
        private System.Windows.Forms.Label lblTramiteNE;
        private System.Windows.Forms.Label lblNombreNE;
        private System.Windows.Forms.Label lblCodigoNE;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox mrcListado;
        private System.Windows.Forms.ListBox lstListado;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramite;
    }
}