namespace DMS.InterfazUsuario.CreacionEstructura
{
    partial class SeleccionarTabla
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBuscarCatalogo = new System.Windows.Forms.TextBox();
            this.lstCategorias = new System.Windows.Forms.ListBox();
            this.dtgCatalogos = new System.Windows.Forms.DataGridView();
            this.IdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCatalogo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCatalogo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreFisicoCatalogo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TablaCreada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Referenciada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCatalogos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarCatalogo
            // 
            this.txtBuscarCatalogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarCatalogo.Location = new System.Drawing.Point(12, 28);
            this.txtBuscarCatalogo.Name = "txtBuscarCatalogo";
            this.txtBuscarCatalogo.Size = new System.Drawing.Size(1022, 25);
            this.txtBuscarCatalogo.TabIndex = 0;
            // 
            // lstCategorias
            // 
            this.lstCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstCategorias.FormattingEnabled = true;
            this.lstCategorias.ItemHeight = 20;
            this.lstCategorias.Location = new System.Drawing.Point(12, 59);
            this.lstCategorias.Name = "lstCategorias";
            this.lstCategorias.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstCategorias.Size = new System.Drawing.Size(247, 344);
            this.lstCategorias.TabIndex = 1;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgCatalogos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgCatalogos.Location = new System.Drawing.Point(265, 58);
            this.dtgCatalogos.MultiSelect = false;
            this.dtgCatalogos.Name = "dtgCatalogos";
            this.dtgCatalogos.ReadOnly = true;
            this.dtgCatalogos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCatalogos.Size = new System.Drawing.Size(769, 345);
            this.dtgCatalogos.TabIndex = 3;
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
            this.TablaCreada.Visible = false;
            // 
            // Referenciada
            // 
            this.Referenciada.DataPropertyName = "Referenciada";
            this.Referenciada.HeaderText = "Referenciada";
            this.Referenciada.Name = "Referenciada";
            this.Referenciada.ReadOnly = true;
            this.Referenciada.Visible = false;
            // 
            // Activo
            // 
            this.Activo.DataPropertyName = "Activo";
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            // 
            // SeleccionarTabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 420);
            this.Controls.Add(this.dtgCatalogos);
            this.Controls.Add(this.lstCategorias);
            this.Controls.Add(this.txtBuscarCatalogo);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "SeleccionarTabla";
            this.Text = "SeleccionarTabla";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCatalogos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarCatalogo;
        private System.Windows.Forms.ListBox lstCategorias;
        private System.Windows.Forms.DataGridView dtgCatalogos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCatalogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCatalogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreFisicoCatalogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TablaCreada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referenciada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
    }
}