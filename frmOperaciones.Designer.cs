namespace TrabajoED
{
    partial class frmOperaciones
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
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.gbOpAlge = new System.Windows.Forms.GroupBox();
            this.cmdDiferencia = new System.Windows.Forms.Button();
            this.cmdInterseccion = new System.Windows.Forms.Button();
            this.cmdUnion = new System.Windows.Forms.Button();
            this.gbWhere = new System.Windows.Forms.GroupBox();
            this.cmdSeleccionXConvul = new System.Windows.Forms.Button();
            this.cmdSeleccionMulti = new System.Windows.Forms.Button();
            this.cmdSeleccionSimple = new System.Windows.Forms.Button();
            this.gbSelect = new System.Windows.Forms.GroupBox();
            this.cmdJuntar = new System.Windows.Forms.Button();
            this.cmdProyeccionMulti = new System.Windows.Forms.Button();
            this.cmdProyeccionSimple = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.gbOpAlge.SuspendLayout();
            this.gbWhere.SuspendLayout();
            this.gbSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.AllowUserToAddRows = false;
            this.dgvMostrar.AllowUserToDeleteRows = false;
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Location = new System.Drawing.Point(13, 13);
            this.dgvMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.ReadOnly = true;
            this.dgvMostrar.RowHeadersWidth = 51;
            this.dgvMostrar.Size = new System.Drawing.Size(816, 351);
            this.dgvMostrar.TabIndex = 7;
            // 
            // gbOpAlge
            // 
            this.gbOpAlge.Controls.Add(this.cmdDiferencia);
            this.gbOpAlge.Controls.Add(this.cmdInterseccion);
            this.gbOpAlge.Controls.Add(this.cmdUnion);
            this.gbOpAlge.Location = new System.Drawing.Point(562, 371);
            this.gbOpAlge.Margin = new System.Windows.Forms.Padding(4);
            this.gbOpAlge.Name = "gbOpAlge";
            this.gbOpAlge.Padding = new System.Windows.Forms.Padding(4);
            this.gbOpAlge.Size = new System.Drawing.Size(267, 146);
            this.gbOpAlge.TabIndex = 6;
            this.gbOpAlge.TabStop = false;
            this.gbOpAlge.Text = "Operaciones Algebraicas";
            // 
            // cmdDiferencia
            // 
            this.cmdDiferencia.Location = new System.Drawing.Point(8, 105);
            this.cmdDiferencia.Margin = new System.Windows.Forms.Padding(4);
            this.cmdDiferencia.Name = "cmdDiferencia";
            this.cmdDiferencia.Size = new System.Drawing.Size(251, 28);
            this.cmdDiferencia.TabIndex = 4;
            this.cmdDiferencia.Text = "Diferencia";
            this.cmdDiferencia.UseVisualStyleBackColor = true;
            this.cmdDiferencia.Click += new System.EventHandler(this.cmdDiferencia_Click);
            // 
            // cmdInterseccion
            // 
            this.cmdInterseccion.Location = new System.Drawing.Point(8, 69);
            this.cmdInterseccion.Margin = new System.Windows.Forms.Padding(4);
            this.cmdInterseccion.Name = "cmdInterseccion";
            this.cmdInterseccion.Size = new System.Drawing.Size(251, 28);
            this.cmdInterseccion.TabIndex = 3;
            this.cmdInterseccion.Text = "Interseccion";
            this.cmdInterseccion.UseVisualStyleBackColor = true;
            this.cmdInterseccion.Click += new System.EventHandler(this.cmdInterseccion_Click);
            // 
            // cmdUnion
            // 
            this.cmdUnion.Location = new System.Drawing.Point(8, 34);
            this.cmdUnion.Margin = new System.Windows.Forms.Padding(4);
            this.cmdUnion.Name = "cmdUnion";
            this.cmdUnion.Size = new System.Drawing.Size(251, 28);
            this.cmdUnion.TabIndex = 2;
            this.cmdUnion.Text = "Union";
            this.cmdUnion.UseVisualStyleBackColor = true;
            this.cmdUnion.Click += new System.EventHandler(this.cmdUnion_Click);
            // 
            // gbWhere
            // 
            this.gbWhere.Controls.Add(this.cmdSeleccionXConvul);
            this.gbWhere.Controls.Add(this.cmdSeleccionMulti);
            this.gbWhere.Controls.Add(this.cmdSeleccionSimple);
            this.gbWhere.Location = new System.Drawing.Point(288, 371);
            this.gbWhere.Margin = new System.Windows.Forms.Padding(4);
            this.gbWhere.Name = "gbWhere";
            this.gbWhere.Padding = new System.Windows.Forms.Padding(4);
            this.gbWhere.Size = new System.Drawing.Size(267, 146);
            this.gbWhere.TabIndex = 5;
            this.gbWhere.TabStop = false;
            this.gbWhere.Text = "Operaciones de seleccion-WHERE";
            // 
            // cmdSeleccionXConvul
            // 
            this.cmdSeleccionXConvul.Location = new System.Drawing.Point(8, 105);
            this.cmdSeleccionXConvul.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSeleccionXConvul.Name = "cmdSeleccionXConvul";
            this.cmdSeleccionXConvul.Size = new System.Drawing.Size(251, 28);
            this.cmdSeleccionXConvul.TabIndex = 3;
            this.cmdSeleccionXConvul.Text = "Seleccion por Convulciòn\r\n";
            this.cmdSeleccionXConvul.UseVisualStyleBackColor = true;
            this.cmdSeleccionXConvul.Click += new System.EventHandler(this.cmdSeleccionXConvul_Click);
            // 
            // cmdSeleccionMulti
            // 
            this.cmdSeleccionMulti.Location = new System.Drawing.Point(8, 69);
            this.cmdSeleccionMulti.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSeleccionMulti.Name = "cmdSeleccionMulti";
            this.cmdSeleccionMulti.Size = new System.Drawing.Size(251, 28);
            this.cmdSeleccionMulti.TabIndex = 2;
            this.cmdSeleccionMulti.Text = "Seleccion Multiatributo";
            this.cmdSeleccionMulti.UseVisualStyleBackColor = true;
            this.cmdSeleccionMulti.Click += new System.EventHandler(this.cmdSeleccionMulti_Click);
            // 
            // cmdSeleccionSimple
            // 
            this.cmdSeleccionSimple.Location = new System.Drawing.Point(8, 34);
            this.cmdSeleccionSimple.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSeleccionSimple.Name = "cmdSeleccionSimple";
            this.cmdSeleccionSimple.Size = new System.Drawing.Size(251, 28);
            this.cmdSeleccionSimple.TabIndex = 1;
            this.cmdSeleccionSimple.Text = "Seleccion Simple";
            this.cmdSeleccionSimple.UseVisualStyleBackColor = true;
            this.cmdSeleccionSimple.Click += new System.EventHandler(this.cmdSeleccionSimple_Click);
            // 
            // gbSelect
            // 
            this.gbSelect.Controls.Add(this.cmdJuntar);
            this.gbSelect.Controls.Add(this.cmdProyeccionMulti);
            this.gbSelect.Controls.Add(this.cmdProyeccionSimple);
            this.gbSelect.Location = new System.Drawing.Point(13, 371);
            this.gbSelect.Margin = new System.Windows.Forms.Padding(4);
            this.gbSelect.Name = "gbSelect";
            this.gbSelect.Padding = new System.Windows.Forms.Padding(4);
            this.gbSelect.Size = new System.Drawing.Size(267, 146);
            this.gbSelect.TabIndex = 4;
            this.gbSelect.TabStop = false;
            this.gbSelect.Text = "Operaciones de Proyeccion-SELECT";
            // 
            // cmdJuntar
            // 
            this.cmdJuntar.Location = new System.Drawing.Point(8, 105);
            this.cmdJuntar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdJuntar.Name = "cmdJuntar";
            this.cmdJuntar.Size = new System.Drawing.Size(251, 28);
            this.cmdJuntar.TabIndex = 2;
            this.cmdJuntar.Text = "Juntar";
            this.cmdJuntar.UseVisualStyleBackColor = true;
            this.cmdJuntar.Click += new System.EventHandler(this.cmdJuntar_Click);
            // 
            // cmdProyeccionMulti
            // 
            this.cmdProyeccionMulti.Location = new System.Drawing.Point(8, 69);
            this.cmdProyeccionMulti.Margin = new System.Windows.Forms.Padding(4);
            this.cmdProyeccionMulti.Name = "cmdProyeccionMulti";
            this.cmdProyeccionMulti.Size = new System.Drawing.Size(251, 28);
            this.cmdProyeccionMulti.TabIndex = 1;
            this.cmdProyeccionMulti.Text = "Proyeccion multiatributo";
            this.cmdProyeccionMulti.UseVisualStyleBackColor = true;
            this.cmdProyeccionMulti.Click += new System.EventHandler(this.cmdProyeccionMulti_Click);
            // 
            // cmdProyeccionSimple
            // 
            this.cmdProyeccionSimple.Location = new System.Drawing.Point(8, 34);
            this.cmdProyeccionSimple.Margin = new System.Windows.Forms.Padding(4);
            this.cmdProyeccionSimple.Name = "cmdProyeccionSimple";
            this.cmdProyeccionSimple.Size = new System.Drawing.Size(251, 28);
            this.cmdProyeccionSimple.TabIndex = 0;
            this.cmdProyeccionSimple.Text = "Proyeccion Simple";
            this.cmdProyeccionSimple.UseVisualStyleBackColor = true;
            this.cmdProyeccionSimple.Click += new System.EventHandler(this.cmdProyeccionSimple_Click);
            // 
            // frmOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 537);
            this.Controls.Add(this.dgvMostrar);
            this.Controls.Add(this.gbOpAlge);
            this.Controls.Add(this.gbWhere);
            this.Controls.Add(this.gbSelect);
            this.Name = "frmOperaciones";
            this.Text = "frmOperaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.gbOpAlge.ResumeLayout(false);
            this.gbWhere.ResumeLayout(false);
            this.gbSelect.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.GroupBox gbOpAlge;
        private System.Windows.Forms.Button cmdDiferencia;
        private System.Windows.Forms.Button cmdInterseccion;
        private System.Windows.Forms.Button cmdUnion;
        private System.Windows.Forms.GroupBox gbWhere;
        private System.Windows.Forms.Button cmdSeleccionXConvul;
        private System.Windows.Forms.Button cmdSeleccionMulti;
        private System.Windows.Forms.Button cmdSeleccionSimple;
        private System.Windows.Forms.GroupBox gbSelect;
        private System.Windows.Forms.Button cmdJuntar;
        private System.Windows.Forms.Button cmdProyeccionMulti;
        private System.Windows.Forms.Button cmdProyeccionSimple;
    }
}