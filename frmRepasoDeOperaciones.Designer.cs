namespace TrabajoED
{
    partial class frmRepasoDeOperaciones
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
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cmdListar = new System.Windows.Forms.Button();
            this.cboLista = new System.Windows.Forms.ComboBox();
            this.lblTexto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.AllowUserToAddRows = false;
            this.dgvGrilla.AllowUserToDeleteRows = false;
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Location = new System.Drawing.Point(6, 176);
            this.dgvGrilla.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            this.dgvGrilla.RowHeadersWidth = 51;
            this.dgvGrilla.Size = new System.Drawing.Size(1135, 375);
            this.dgvGrilla.TabIndex = 9;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDescripcion.Location = new System.Drawing.Point(6, 55);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(1135, 104);
            this.txtDescripcion.TabIndex = 8;
            // 
            // cmdListar
            // 
            this.cmdListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListar.Location = new System.Drawing.Point(966, 19);
            this.cmdListar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(175, 28);
            this.cmdListar.TabIndex = 7;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // cboLista
            // 
            this.cboLista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLista.FormattingEnabled = true;
            this.cboLista.Items.AddRange(new object[] {
            "Proyeccion Simple I",
            "Proyeccion Simple II",
            "Proyeccion Multiatributo",
            "Proyeccion Multiatributo II",
            "Juntar",
            "Juntar II",
            "Seleccion Simple",
            "Seleccion Simple II",
            "Seleccion Multiatributo",
            "Seleccion Multiatributo II",
            "Seleccion Convulcion",
            "Seleccion Convulcion II",
            "Union",
            "Union II",
            "Interseccion",
            "Interseccion II",
            "Diferencia",
            "Diferencia II",
            "Proyeccion Simple III",
            "Proyeccion Simple IV"});
            this.cboLista.Location = new System.Drawing.Point(396, 19);
            this.cboLista.Margin = new System.Windows.Forms.Padding(4);
            this.cboLista.Name = "cboLista";
            this.cboLista.Size = new System.Drawing.Size(562, 24);
            this.cboLista.TabIndex = 6;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(1, 18);
            this.lblTexto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(368, 25);
            this.lblTexto.TabIndex = 5;
            this.lblTexto.Text = "Operacion a realizar en la base de datos:\r\n";
            // 
            // frmRepasoDeOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 562);
            this.Controls.Add(this.dgvGrilla);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.cboLista);
            this.Controls.Add(this.lblTexto);
            this.Name = "frmRepasoDeOperaciones";
            this.Text = "frmRepasoDeOperaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.ComboBox cboLista;
        private System.Windows.Forms.Label lblTexto;
    }
}