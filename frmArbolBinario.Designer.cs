namespace TrabajoED
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
            this.twArbolBinario = new System.Windows.Forms.TreeView();
            this.gbNuevoElemento = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbArbolBinario = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEquilibrar = new System.Windows.Forms.Button();
            this.rdInOrden = new System.Windows.Forms.RadioButton();
            this.rdPreOrden = new System.Windows.Forms.RadioButton();
            this.rdPostOrden = new System.Windows.Forms.RadioButton();
            this.dgvArbolBinario = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdInOrdenDes = new System.Windows.Forms.RadioButton();
            this.gbNuevoElemento.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbolBinario)).BeginInit();
            this.SuspendLayout();
            // 
            // twArbolBinario
            // 
            this.twArbolBinario.Location = new System.Drawing.Point(16, 15);
            this.twArbolBinario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.twArbolBinario.Name = "twArbolBinario";
            this.twArbolBinario.Size = new System.Drawing.Size(259, 200);
            this.twArbolBinario.TabIndex = 0;
            // 
            // gbNuevoElemento
            // 
            this.gbNuevoElemento.Controls.Add(this.button1);
            this.gbNuevoElemento.Controls.Add(this.txtTramite);
            this.gbNuevoElemento.Controls.Add(this.txtNombre);
            this.gbNuevoElemento.Controls.Add(this.txtCodigo);
            this.gbNuevoElemento.Controls.Add(this.label3);
            this.gbNuevoElemento.Controls.Add(this.label2);
            this.gbNuevoElemento.Controls.Add(this.label1);
            this.gbNuevoElemento.Location = new System.Drawing.Point(320, 15);
            this.gbNuevoElemento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbNuevoElemento.Name = "gbNuevoElemento";
            this.gbNuevoElemento.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbNuevoElemento.Size = new System.Drawing.Size(244, 201);
            this.gbNuevoElemento.TabIndex = 12;
            this.gbNuevoElemento.TabStop = false;
            this.gbNuevoElemento.Text = "Nuevo Elemento";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 140);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(85, 108);
            this.txtTramite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(149, 22);
            this.txtTramite.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(85, 63);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(149, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(85, 25);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(149, 22);
            this.txtCodigo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tramite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbArbolBinario);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(611, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(280, 105);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elelemento Eliminado";
            // 
            // cmbArbolBinario
            // 
            this.cmbArbolBinario.FormattingEnabled = true;
            this.cmbArbolBinario.Location = new System.Drawing.Point(71, 21);
            this.cmbArbolBinario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbArbolBinario.Name = "cmbArbolBinario";
            this.cmbArbolBinario.Size = new System.Drawing.Size(160, 24);
            this.cmbArbolBinario.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(71, 63);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Codigo";
            // 
            // btnEquilibrar
            // 
            this.btnEquilibrar.Location = new System.Drawing.Point(647, 155);
            this.btnEquilibrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(175, 44);
            this.btnEquilibrar.TabIndex = 9;
            this.btnEquilibrar.Text = "Equilibrar";
            this.btnEquilibrar.UseVisualStyleBackColor = true;
            this.btnEquilibrar.Click += new System.EventHandler(this.btnEquilibrar_Click);
            // 
            // rdInOrden
            // 
            this.rdInOrden.AutoSize = true;
            this.rdInOrden.Location = new System.Drawing.Point(85, 270);
            this.rdInOrden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdInOrden.Name = "rdInOrden";
            this.rdInOrden.Size = new System.Drawing.Size(79, 20);
            this.rdInOrden.TabIndex = 14;
            this.rdInOrden.TabStop = true;
            this.rdInOrden.Text = "In-Orden";
            this.rdInOrden.UseVisualStyleBackColor = true;
            this.rdInOrden.CheckedChanged += new System.EventHandler(this.rdInOrden_CheckedChanged);
            // 
            // rdPreOrden
            // 
            this.rdPreOrden.AutoSize = true;
            this.rdPreOrden.Location = new System.Drawing.Point(85, 326);
            this.rdPreOrden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdPreOrden.Name = "rdPreOrden";
            this.rdPreOrden.Size = new System.Drawing.Size(90, 20);
            this.rdPreOrden.TabIndex = 15;
            this.rdPreOrden.TabStop = true;
            this.rdPreOrden.Text = "Pre-Orden";
            this.rdPreOrden.UseVisualStyleBackColor = true;
            this.rdPreOrden.CheckedChanged += new System.EventHandler(this.rdPreOrden_CheckedChanged);
            // 
            // rdPostOrden
            // 
            this.rdPostOrden.AutoSize = true;
            this.rdPostOrden.Location = new System.Drawing.Point(85, 354);
            this.rdPostOrden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdPostOrden.Name = "rdPostOrden";
            this.rdPostOrden.Size = new System.Drawing.Size(96, 20);
            this.rdPostOrden.TabIndex = 16;
            this.rdPostOrden.TabStop = true;
            this.rdPostOrden.Text = "Post-Orden";
            this.rdPostOrden.UseVisualStyleBackColor = true;
            this.rdPostOrden.CheckedChanged += new System.EventHandler(this.rdPostOrden_CheckedChanged);
            // 
            // dgvArbolBinario
            // 
            this.dgvArbolBinario.AllowUserToAddRows = false;
            this.dgvArbolBinario.AllowUserToDeleteRows = false;
            this.dgvArbolBinario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArbolBinario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Tramite});
            this.dgvArbolBinario.Location = new System.Drawing.Point(320, 223);
            this.dgvArbolBinario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvArbolBinario.Name = "dgvArbolBinario";
            this.dgvArbolBinario.ReadOnly = true;
            this.dgvArbolBinario.RowHeadersWidth = 51;
            this.dgvArbolBinario.Size = new System.Drawing.Size(567, 213);
            this.dgvArbolBinario.TabIndex = 17;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // Tramite
            // 
            this.Tramite.HeaderText = "Tramite";
            this.Tramite.MinimumWidth = 6;
            this.Tramite.Name = "Tramite";
            this.Tramite.ReadOnly = true;
            this.Tramite.Width = 125;
            // 
            // rdInOrdenDes
            // 
            this.rdInOrdenDes.AutoSize = true;
            this.rdInOrdenDes.Location = new System.Drawing.Point(85, 298);
            this.rdInOrdenDes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdInOrdenDes.Name = "rdInOrdenDes";
            this.rdInOrdenDes.Size = new System.Drawing.Size(104, 20);
            this.rdInOrdenDes.TabIndex = 18;
            this.rdInOrdenDes.TabStop = true;
            this.rdInOrdenDes.Text = "In-OrdenDes";
            this.rdInOrdenDes.UseVisualStyleBackColor = true;
            this.rdInOrdenDes.CheckedChanged += new System.EventHandler(this.rdInOrdenDes_CheckedChanged);
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 450);
            this.Controls.Add(this.rdInOrdenDes);
            this.Controls.Add(this.dgvArbolBinario);
            this.Controls.Add(this.rdPostOrden);
            this.Controls.Add(this.rdPreOrden);
            this.Controls.Add(this.rdInOrden);
            this.Controls.Add(this.btnEquilibrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbNuevoElemento);
            this.Controls.Add(this.twArbolBinario);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmArbolBinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmArbolBinario";
            this.Load += new System.EventHandler(this.frmArbolBinario_Load);
            this.gbNuevoElemento.ResumeLayout(false);
            this.gbNuevoElemento.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbolBinario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView twArbolBinario;
        private System.Windows.Forms.GroupBox gbNuevoElemento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbArbolBinario;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEquilibrar;
        private System.Windows.Forms.RadioButton rdInOrden;
        private System.Windows.Forms.RadioButton rdPreOrden;
        private System.Windows.Forms.RadioButton rdPostOrden;
        private System.Windows.Forms.DataGridView dgvArbolBinario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramite;
        private System.Windows.Forms.RadioButton rdInOrdenDes;
    }
}