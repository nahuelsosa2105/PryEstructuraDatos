namespace PryEstructuraDatos
{
    partial class frmArbolBinario
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
            this.gpListado = new System.Windows.Forms.GroupBox();
            this.optPostOrden = new System.Windows.Forms.RadioButton();
            this.optPreOrden = new System.Windows.Forms.RadioButton();
            this.optInOrdenDesc = new System.Windows.Forms.RadioButton();
            this.optInOrdenAsc = new System.Windows.Forms.RadioButton();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpElementoEliminado = new System.Windows.Forms.GroupBox();
            this.cmbCodigo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gpNuevoElemento = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnEquilibrar = new System.Windows.Forms.Button();
            this.trvMostrar = new System.Windows.Forms.TreeView();
            this.gpListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.gpElementoEliminado.SuspendLayout();
            this.gpNuevoElemento.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpListado
            // 
            this.gpListado.Controls.Add(this.optPostOrden);
            this.gpListado.Controls.Add(this.optPreOrden);
            this.gpListado.Controls.Add(this.optInOrdenDesc);
            this.gpListado.Controls.Add(this.optInOrdenAsc);
            this.gpListado.Controls.Add(this.dgvListado);
            this.gpListado.Location = new System.Drawing.Point(8, 272);
            this.gpListado.Name = "gpListado";
            this.gpListado.Size = new System.Drawing.Size(876, 221);
            this.gpListado.TabIndex = 20;
            this.gpListado.TabStop = false;
            this.gpListado.Text = "Listado en una Lista y una Grilla";
            // 
            // optPostOrden
            // 
            this.optPostOrden.AutoSize = true;
            this.optPostOrden.Location = new System.Drawing.Point(36, 173);
            this.optPostOrden.Name = "optPostOrden";
            this.optPostOrden.Size = new System.Drawing.Size(78, 17);
            this.optPostOrden.TabIndex = 5;
            this.optPostOrden.TabStop = true;
            this.optPostOrden.Text = "Post-Orden";
            this.optPostOrden.UseVisualStyleBackColor = true;
            // 
            // optPreOrden
            // 
            this.optPreOrden.AutoSize = true;
            this.optPreOrden.Location = new System.Drawing.Point(36, 136);
            this.optPreOrden.Name = "optPreOrden";
            this.optPreOrden.Size = new System.Drawing.Size(73, 17);
            this.optPreOrden.TabIndex = 4;
            this.optPreOrden.TabStop = true;
            this.optPreOrden.Text = "Pre-Orden";
            this.optPreOrden.UseVisualStyleBackColor = true;
            // 
            // optInOrdenDesc
            // 
            this.optInOrdenDesc.AutoSize = true;
            this.optInOrdenDesc.Location = new System.Drawing.Point(36, 95);
            this.optInOrdenDesc.Name = "optInOrdenDesc";
            this.optInOrdenDesc.Size = new System.Drawing.Size(133, 17);
            this.optInOrdenDesc.TabIndex = 3;
            this.optInOrdenDesc.TabStop = true;
            this.optInOrdenDesc.Text = "In-Orden-Descendente";
            this.optInOrdenDesc.UseVisualStyleBackColor = true;
            // 
            // optInOrdenAsc
            // 
            this.optInOrdenAsc.AutoSize = true;
            this.optInOrdenAsc.Location = new System.Drawing.Point(36, 54);
            this.optInOrdenAsc.Name = "optInOrdenAsc";
            this.optInOrdenAsc.Size = new System.Drawing.Size(126, 17);
            this.optInOrdenAsc.TabIndex = 2;
            this.optInOrdenAsc.TabStop = true;
            this.optInOrdenAsc.Text = "In-Orden-Ascendente";
            this.optInOrdenAsc.UseVisualStyleBackColor = true;
            // 
            // dgvListado
            // 
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvListado.Location = new System.Drawing.Point(287, 19);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.Size = new System.Drawing.Size(559, 186);
            this.dgvListado.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Trámite";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // gpElementoEliminado
            // 
            this.gpElementoEliminado.Controls.Add(this.cmbCodigo);
            this.gpElementoEliminado.Controls.Add(this.label4);
            this.gpElementoEliminado.Controls.Add(this.btnEliminar);
            this.gpElementoEliminado.Location = new System.Drawing.Point(635, 27);
            this.gpElementoEliminado.Name = "gpElementoEliminado";
            this.gpElementoEliminado.Size = new System.Drawing.Size(238, 125);
            this.gpElementoEliminado.TabIndex = 19;
            this.gpElementoEliminado.TabStop = false;
            this.gpElementoEliminado.Text = "Elemento a eliminar";
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Location = new System.Drawing.Point(73, 27);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(156, 21);
            this.cmbCodigo.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Código:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(6, 73);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(223, 43);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // gpNuevoElemento
            // 
            this.gpNuevoElemento.Controls.Add(this.label3);
            this.gpNuevoElemento.Controls.Add(this.label2);
            this.gpNuevoElemento.Controls.Add(this.label1);
            this.gpNuevoElemento.Controls.Add(this.btnAgregar);
            this.gpNuevoElemento.Controls.Add(this.txtNombre);
            this.gpNuevoElemento.Controls.Add(this.txtTramite);
            this.gpNuevoElemento.Controls.Add(this.txtCodigo);
            this.gpNuevoElemento.Location = new System.Drawing.Point(369, 27);
            this.gpNuevoElemento.Name = "gpNuevoElemento";
            this.gpNuevoElemento.Size = new System.Drawing.Size(238, 218);
            this.gpNuevoElemento.TabIndex = 18;
            this.gpNuevoElemento.TabStop = false;
            this.gpNuevoElemento.Text = "Nuevo Elemento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Trámite:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Código:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(9, 169);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(223, 43);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(59, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(173, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(59, 85);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(173, 20);
            this.txtTramite.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(132, 26);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // btnEquilibrar
            // 
            this.btnEquilibrar.Location = new System.Drawing.Point(641, 196);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(223, 43);
            this.btnEquilibrar.TabIndex = 21;
            this.btnEquilibrar.Text = "Equilibrar";
            this.btnEquilibrar.UseVisualStyleBackColor = true;
            // 
            // trvMostrar
            // 
            this.trvMostrar.Location = new System.Drawing.Point(28, 24);
            this.trvMostrar.Name = "trvMostrar";
            this.trvMostrar.Size = new System.Drawing.Size(297, 221);
            this.trvMostrar.TabIndex = 22;
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 526);
            this.Controls.Add(this.trvMostrar);
            this.Controls.Add(this.btnEquilibrar);
            this.Controls.Add(this.gpListado);
            this.Controls.Add(this.gpElementoEliminado);
            this.Controls.Add(this.gpNuevoElemento);
            this.Name = "frmArbolBinario";
            this.Text = "frmArbolBinario";
            this.gpListado.ResumeLayout(false);
            this.gpListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.gpElementoEliminado.ResumeLayout(false);
            this.gpElementoEliminado.PerformLayout();
            this.gpNuevoElemento.ResumeLayout(false);
            this.gpNuevoElemento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpListado;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox gpElementoEliminado;
        private System.Windows.Forms.ComboBox cmbCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox gpNuevoElemento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnEquilibrar;
        private System.Windows.Forms.RadioButton optPostOrden;
        private System.Windows.Forms.RadioButton optPreOrden;
        private System.Windows.Forms.RadioButton optInOrdenDesc;
        private System.Windows.Forms.RadioButton optInOrdenAsc;
        private System.Windows.Forms.TreeView trvMostrar;
    }
}