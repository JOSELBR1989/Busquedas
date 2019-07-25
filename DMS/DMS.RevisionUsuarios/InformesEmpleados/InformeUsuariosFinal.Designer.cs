namespace DMS.RevisionUsuarios.InformesEmpleados
{
    partial class InformeUsuariosFinal
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rdbtnInactivo = new System.Windows.Forms.RadioButton();
            this.rdbtnActivo = new System.Windows.Forms.RadioButton();
            this.rdbtnTodos = new System.Windows.Forms.RadioButton();
            this.lstCategorias = new System.Windows.Forms.ListBox();
            this.txtBuscarCatalogo = new System.Windows.Forms.TextBox();
            this.dtgCatalogos = new System.Windows.Forms.DataGridView();
            this.IdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCatalogo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCatalogo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreFisicoCatalogo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TablaCreada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Referenciada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtBusquedaGenerica = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cmbScriptsDisponibles = new System.Windows.Forms.ComboBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCatalogos)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1178, 421);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rdbtnInactivo);
            this.tabPage1.Controls.Add(this.rdbtnActivo);
            this.tabPage1.Controls.Add(this.rdbtnTodos);
            this.tabPage1.Controls.Add(this.lstCategorias);
            this.tabPage1.Controls.Add(this.txtBuscarCatalogo);
            this.tabPage1.Controls.Add(this.dtgCatalogos);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(1170, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Busquedas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rdbtnInactivo
            // 
            this.rdbtnInactivo.AutoSize = true;
            this.rdbtnInactivo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnInactivo.Location = new System.Drawing.Point(12, 96);
            this.rdbtnInactivo.Name = "rdbtnInactivo";
            this.rdbtnInactivo.Size = new System.Drawing.Size(67, 20);
            this.rdbtnInactivo.TabIndex = 13;
            this.rdbtnInactivo.Text = "Inactivos";
            this.rdbtnInactivo.UseVisualStyleBackColor = true;
            // 
            // rdbtnActivo
            // 
            this.rdbtnActivo.AutoSize = true;
            this.rdbtnActivo.Checked = true;
            this.rdbtnActivo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnActivo.Location = new System.Drawing.Point(12, 70);
            this.rdbtnActivo.Name = "rdbtnActivo";
            this.rdbtnActivo.Size = new System.Drawing.Size(59, 20);
            this.rdbtnActivo.TabIndex = 12;
            this.rdbtnActivo.TabStop = true;
            this.rdbtnActivo.Text = "Activos";
            this.rdbtnActivo.UseVisualStyleBackColor = true;
            // 
            // rdbtnTodos
            // 
            this.rdbtnTodos.AutoSize = true;
            this.rdbtnTodos.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnTodos.Location = new System.Drawing.Point(12, 44);
            this.rdbtnTodos.Name = "rdbtnTodos";
            this.rdbtnTodos.Size = new System.Drawing.Size(56, 20);
            this.rdbtnTodos.TabIndex = 11;
            this.rdbtnTodos.Text = "Todos";
            this.rdbtnTodos.UseVisualStyleBackColor = true;
            // 
            // lstCategorias
            // 
            this.lstCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstCategorias.FormattingEnabled = true;
            this.lstCategorias.ItemHeight = 16;
            this.lstCategorias.Location = new System.Drawing.Point(12, 124);
            this.lstCategorias.Name = "lstCategorias";
            this.lstCategorias.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstCategorias.Size = new System.Drawing.Size(179, 244);
            this.lstCategorias.TabIndex = 10;
            // 
            // txtBuscarCatalogo
            // 
            this.txtBuscarCatalogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarCatalogo.Location = new System.Drawing.Point(12, 12);
            this.txtBuscarCatalogo.Name = "txtBuscarCatalogo";
            this.txtBuscarCatalogo.Size = new System.Drawing.Size(1152, 22);
            this.txtBuscarCatalogo.TabIndex = 9;
            // 
            // dtgCatalogos
            // 
            this.dtgCatalogos.AllowUserToAddRows = false;
            this.dtgCatalogos.AllowUserToDeleteRows = false;
            this.dtgCatalogos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgCatalogos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCatalogos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCategoria,
            this.NombreCategoria,
            this.IdCatalogo,
            this.NombreCatalogo,
            this.NombreFisicoCatalogo,
            this.TablaCreada,
            this.Referenciada,
            this.Activo});
            this.dtgCatalogos.Location = new System.Drawing.Point(197, 44);
            this.dtgCatalogos.MultiSelect = false;
            this.dtgCatalogos.Name = "dtgCatalogos";
            this.dtgCatalogos.ReadOnly = true;
            this.dtgCatalogos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCatalogos.Size = new System.Drawing.Size(967, 341);
            this.dtgCatalogos.TabIndex = 8;
            // 
            // IdCategoria
            // 
            this.IdCategoria.DataPropertyName = "IdCategoria";
            this.IdCategoria.HeaderText = "IdCategoria";
            this.IdCategoria.Name = "IdCategoria";
            this.IdCategoria.ReadOnly = true;
            this.IdCategoria.Visible = false;
            // 
            // NombreCategoria
            // 
            this.NombreCategoria.DataPropertyName = "NombreCategoria";
            this.NombreCategoria.HeaderText = "Categoria";
            this.NombreCategoria.Name = "NombreCategoria";
            this.NombreCategoria.ReadOnly = true;
            // 
            // IdCatalogo
            // 
            this.IdCatalogo.DataPropertyName = "IdCatalogo";
            this.IdCatalogo.HeaderText = "IdCatalogo";
            this.IdCatalogo.Name = "IdCatalogo";
            this.IdCatalogo.ReadOnly = true;
            this.IdCatalogo.Visible = false;
            // 
            // NombreCatalogo
            // 
            this.NombreCatalogo.DataPropertyName = "NombreCatalogo";
            this.NombreCatalogo.HeaderText = "Catalogo";
            this.NombreCatalogo.Name = "NombreCatalogo";
            this.NombreCatalogo.ReadOnly = true;
            // 
            // NombreFisicoCatalogo
            // 
            this.NombreFisicoCatalogo.DataPropertyName = "NombreFisicoCatalogo";
            this.NombreFisicoCatalogo.HeaderText = "Tabla Física";
            this.NombreFisicoCatalogo.Name = "NombreFisicoCatalogo";
            this.NombreFisicoCatalogo.ReadOnly = true;
            // 
            // TablaCreada
            // 
            this.TablaCreada.DataPropertyName = "TablaCreada";
            this.TablaCreada.HeaderText = "Tabla Creada";
            this.TablaCreada.Name = "TablaCreada";
            this.TablaCreada.ReadOnly = true;
            // 
            // Referenciada
            // 
            this.Referenciada.DataPropertyName = "Referenciada";
            this.Referenciada.HeaderText = "Referenciada";
            this.Referenciada.Name = "Referenciada";
            this.Referenciada.ReadOnly = true;
            // 
            // Activo
            // 
            this.Activo.DataPropertyName = "Activo";
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelTotal);
            this.tabPage2.Controls.Add(this.txtBusquedaGenerica);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.cmbScriptsDisponibles);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(1170, 392);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Tag = "0";
            this.tabPage2.Text = "Informacion";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtBusquedaGenerica
            // 
            this.txtBusquedaGenerica.Location = new System.Drawing.Point(6, 56);
            this.txtBusquedaGenerica.Name = "txtBusquedaGenerica";
            this.txtBusquedaGenerica.Size = new System.Drawing.Size(383, 22);
            this.txtBusquedaGenerica.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1158, 301);
            this.dataGridView1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(549, 7);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(615, 71);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // cmbScriptsDisponibles
            // 
            this.cmbScriptsDisponibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScriptsDisponibles.FormattingEnabled = true;
            this.cmbScriptsDisponibles.Location = new System.Drawing.Point(6, 7);
            this.cmbScriptsDisponibles.Name = "cmbScriptsDisponibles";
            this.cmbScriptsDisponibles.Size = new System.Drawing.Size(537, 24);
            this.cmbScriptsDisponibles.TabIndex = 0;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(395, 59);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(0, 16);
            this.labelTotal.TabIndex = 4;
            // 
            // InformeUsuariosFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 449);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "InformeUsuariosFinal";
            this.Text = "Informes de usuario Final";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCatalogos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton rdbtnInactivo;
        private System.Windows.Forms.RadioButton rdbtnActivo;
        private System.Windows.Forms.RadioButton rdbtnTodos;
        private System.Windows.Forms.ListBox lstCategorias;
        private System.Windows.Forms.TextBox txtBuscarCatalogo;
        private System.Windows.Forms.DataGridView dtgCatalogos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCatalogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCatalogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreFisicoCatalogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TablaCreada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referenciada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
        private System.Windows.Forms.ComboBox cmbScriptsDisponibles;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBusquedaGenerica;
        private System.Windows.Forms.Label labelTotal;
    }
}