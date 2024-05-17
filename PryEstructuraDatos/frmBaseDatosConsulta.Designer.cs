namespace PryEstructuraDatos
{
    partial class frmBaseDatosConsulta
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
            this.txtListar = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvBaseDatos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtListar
            // 
            this.txtListar.Location = new System.Drawing.Point(12, 28);
            this.txtListar.Multiline = true;
            this.txtListar.Name = "txtListar";
            this.txtListar.Size = new System.Drawing.Size(822, 142);
            this.txtListar.TabIndex = 0;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(740, 191);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(94, 23);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvBaseDatos
            // 
            this.dgvBaseDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaseDatos.Location = new System.Drawing.Point(12, 232);
            this.dgvBaseDatos.Name = "dgvBaseDatos";
            this.dgvBaseDatos.Size = new System.Drawing.Size(822, 304);
            this.dgvBaseDatos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Consultas en SQL:";
            // 
            // frmBaseDatosConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 548);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBaseDatos);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txtListar);
            this.Name = "frmBaseDatosConsulta";
            this.Text = "Consulta en la Base de Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtListar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvBaseDatos;
        private System.Windows.Forms.Label label1;
    }
}