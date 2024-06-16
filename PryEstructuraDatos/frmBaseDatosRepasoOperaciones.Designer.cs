namespace PryEstructuraDatos
{
    partial class frmBaseDatosRepasoOperaciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbListar = new System.Windows.Forms.ComboBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblListar = new System.Windows.Forms.Label();
            this.dgvBaseDatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operación a realizar en la base de datos:";
            // 
            // cmbListar
            // 
            this.cmbListar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListar.FormattingEnabled = true;
            this.cmbListar.Items.AddRange(new object[] {
            "Diferencia",
            "Intersección",
            "Unión",
            "Selección Simple",
            "Selección por multiatributo por Intersección",
            "Selección por multiatributo por Convolución",
            "Orden",
            "Proyección por un atributo",
            "Proyección por multiatributo",
            "Juntar",
            "Diferencia",
            "Intersección",
            "Unión",
            "Selección Simple",
            "Selección por multiatributo por Intersección",
            "Selección por multiatributo por Convolución",
            "Orden",
            "Proyección por un atributo",
            "Proyección por multiatributo",
            "Juntar"});
            this.cmbListar.Location = new System.Drawing.Point(218, 11);
            this.cmbListar.Name = "cmbListar";
            this.cmbListar.Size = new System.Drawing.Size(479, 21);
            this.cmbListar.TabIndex = 1;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(720, 9);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(109, 23);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblListar
            // 
            this.lblListar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListar.Location = new System.Drawing.Point(12, 47);
            this.lblListar.Name = "lblListar";
            this.lblListar.Size = new System.Drawing.Size(817, 138);
            this.lblListar.TabIndex = 3;
            // 
            // dgvBaseDatos
            // 
            this.dgvBaseDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaseDatos.Location = new System.Drawing.Point(7, 200);
            this.dgvBaseDatos.Name = "dgvBaseDatos";
            this.dgvBaseDatos.Size = new System.Drawing.Size(822, 289);
            this.dgvBaseDatos.TabIndex = 4;
            // 
            // frmBaseDatosRepasoOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 501);
            this.Controls.Add(this.dgvBaseDatos);
            this.Controls.Add(this.lblListar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.cmbListar);
            this.Controls.Add(this.label1);
            this.Name = "frmBaseDatosRepasoOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBaseDatosRepasoOperaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbListar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblListar;
        private System.Windows.Forms.DataGridView dgvBaseDatos;
    }
}