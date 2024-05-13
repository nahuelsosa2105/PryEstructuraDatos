namespace PryEstructuraDatos
{
    partial class frmBaseDatosOperaciones
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
            this.dgvBaseDatos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnProySimple = new System.Windows.Forms.Button();
            this.btnProyMulti = new System.Windows.Forms.Button();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSelConvolucion = new System.Windows.Forms.Button();
            this.btnSelMulti = new System.Windows.Forms.Button();
            this.btnSelSimple = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDiferencia = new System.Windows.Forms.Button();
            this.btnInterseccion = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBaseDatos
            // 
            this.dgvBaseDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaseDatos.Location = new System.Drawing.Point(12, 12);
            this.dgvBaseDatos.Name = "dgvBaseDatos";
            this.dgvBaseDatos.Size = new System.Drawing.Size(870, 352);
            this.dgvBaseDatos.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnJuntar);
            this.groupBox1.Controls.Add(this.btnProyMulti);
            this.groupBox1.Controls.Add(this.btnProySimple);
            this.groupBox1.Location = new System.Drawing.Point(12, 388);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 162);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones de Proyección - SELECT";
            // 
            // btnProySimple
            // 
            this.btnProySimple.Location = new System.Drawing.Point(6, 30);
            this.btnProySimple.Name = "btnProySimple";
            this.btnProySimple.Size = new System.Drawing.Size(267, 23);
            this.btnProySimple.TabIndex = 2;
            this.btnProySimple.Text = "Proyección simple";
            this.btnProySimple.UseVisualStyleBackColor = true;
            // 
            // btnProyMulti
            // 
            this.btnProyMulti.Location = new System.Drawing.Point(6, 76);
            this.btnProyMulti.Name = "btnProyMulti";
            this.btnProyMulti.Size = new System.Drawing.Size(267, 23);
            this.btnProyMulti.TabIndex = 3;
            this.btnProyMulti.Text = "Proyección multiatributo";
            this.btnProyMulti.UseVisualStyleBackColor = true;
            // 
            // btnJuntar
            // 
            this.btnJuntar.Location = new System.Drawing.Point(6, 122);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(267, 23);
            this.btnJuntar.TabIndex = 4;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSelConvolucion);
            this.groupBox2.Controls.Add(this.btnSelMulti);
            this.groupBox2.Controls.Add(this.btnSelSimple);
            this.groupBox2.Location = new System.Drawing.Point(308, 388);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 162);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones de Selección - WHERE";
            // 
            // btnSelConvolucion
            // 
            this.btnSelConvolucion.Location = new System.Drawing.Point(6, 122);
            this.btnSelConvolucion.Name = "btnSelConvolucion";
            this.btnSelConvolucion.Size = new System.Drawing.Size(267, 23);
            this.btnSelConvolucion.TabIndex = 4;
            this.btnSelConvolucion.Text = "Selección por convolución";
            this.btnSelConvolucion.UseVisualStyleBackColor = true;
            // 
            // btnSelMulti
            // 
            this.btnSelMulti.Location = new System.Drawing.Point(6, 76);
            this.btnSelMulti.Name = "btnSelMulti";
            this.btnSelMulti.Size = new System.Drawing.Size(267, 23);
            this.btnSelMulti.TabIndex = 3;
            this.btnSelMulti.Text = "Selección multiatributo";
            this.btnSelMulti.UseVisualStyleBackColor = true;
            // 
            // btnSelSimple
            // 
            this.btnSelSimple.Location = new System.Drawing.Point(6, 30);
            this.btnSelSimple.Name = "btnSelSimple";
            this.btnSelSimple.Size = new System.Drawing.Size(267, 23);
            this.btnSelSimple.TabIndex = 2;
            this.btnSelSimple.Text = "Selección simple";
            this.btnSelSimple.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDiferencia);
            this.groupBox3.Controls.Add(this.btnInterseccion);
            this.groupBox3.Controls.Add(this.btnUnion);
            this.groupBox3.Location = new System.Drawing.Point(603, 388);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 162);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operaciones Algebraicas";
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Location = new System.Drawing.Point(6, 122);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(267, 23);
            this.btnDiferencia.TabIndex = 4;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            // 
            // btnInterseccion
            // 
            this.btnInterseccion.Location = new System.Drawing.Point(6, 76);
            this.btnInterseccion.Name = "btnInterseccion";
            this.btnInterseccion.Size = new System.Drawing.Size(267, 23);
            this.btnInterseccion.TabIndex = 3;
            this.btnInterseccion.Text = "Intersección";
            this.btnInterseccion.UseVisualStyleBackColor = true;
            // 
            // btnUnion
            // 
            this.btnUnion.Location = new System.Drawing.Point(6, 30);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(267, 23);
            this.btnUnion.TabIndex = 2;
            this.btnUnion.Text = "Unión";
            this.btnUnion.UseVisualStyleBackColor = true;
            // 
            // frmBaseDatosOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvBaseDatos);
            this.Name = "frmBaseDatosOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBaseDatos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.Button btnProyMulti;
        private System.Windows.Forms.Button btnProySimple;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSelConvolucion;
        private System.Windows.Forms.Button btnSelMulti;
        private System.Windows.Forms.Button btnSelSimple;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDiferencia;
        private System.Windows.Forms.Button btnInterseccion;
        private System.Windows.Forms.Button btnUnion;
    }
}