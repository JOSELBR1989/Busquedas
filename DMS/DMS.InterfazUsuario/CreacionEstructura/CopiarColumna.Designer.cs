namespace DMS.InterfazUsuario.CreacionEstructura
{
    partial class CopiarColumna
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
            this.lstCampoHacerReferencia = new System.Windows.Forms.ListBox();
            this.dtgBusquedaCatalogos = new System.Windows.Forms.DataGridView();
            this.dtNameIdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtNameNombreCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtNameIdCatalogo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtNameNombreCatalogo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtNameNombreFisicoCatalogo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtNameTablaCreada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtNameReferenciada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtNameActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBusquedaTabla = new System.Windows.Forms.TextBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBusquedaCatalogos)).BeginInit();
            this.SuspendLayout();
            // 
            // lstCampoHacerReferencia
            // 
            this.lstCampoHacerReferencia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCampoHacerReferencia.FormattingEnabled = true;
            this.lstCampoHacerReferencia.ItemHeight = 20;
            this.lstCampoHacerReferencia.Location = new System.Drawing.Point(12, 219);
            this.lstCampoHacerReferencia.Name = "lstCampoHacerReferencia";
            this.lstCampoHacerReferencia.Size = new System.Drawing.Size(732, 264);
            this.lstCampoHacerReferencia.TabIndex = 20;
            // 
            // dtgBusquedaCatalogos
            // 
            this.dtgBusquedaCatalogos.AllowUserToAddRows = false;
            this.dtgBusquedaCatalogos.AllowUserToDeleteRows = false;
            this.dtgBusquedaCatalogos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgBusquedaCatalogos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBusquedaCatalogos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtNameIdCategoria,
            this.dtNameNombreCategoria,
            this.dtNameIdCatalogo,
            this.dtNameNombreCatalogo,
            this.dtNameNombreFisicoCatalogo,
            this.dtNameTablaCreada,
            this.dtNameReferenciada,
            this.dtNameActivo});
            this.dtgBusquedaCatalogos.Location = new System.Drawing.Point(12, 73);
            this.dtgBusquedaCatalogos.MultiSelect = false;
            this.dtgBusquedaCatalogos.Name = "dtgBusquedaCatalogos";
            this.dtgBusquedaCatalogos.ReadOnly = true;
            this.dtgBusquedaCatalogos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgBusquedaCatalogos.Size = new System.Drawing.Size(732, 140);
            this.dtgBusquedaCatalogos.TabIndex = 19;
            // 
            // dtNameIdCategoria
            // 
            this.dtNameIdCategoria.DataPropertyName = "IdCategoria";
            this.dtNameIdCategoria.HeaderText = "IdCategoria";
            this.dtNameIdCategoria.Name = "dtNameIdCategoria";
            this.dtNameIdCategoria.ReadOnly = true;
            this.dtNameIdCategoria.Visible = false;
            // 
            // dtNameNombreCategoria
            // 
            this.dtNameNombreCategoria.DataPropertyName = "NombreCategoria";
            this.dtNameNombreCategoria.HeaderText = "Categoria";
            this.dtNameNombreCategoria.Name = "dtNameNombreCategoria";
            this.dtNameNombreCategoria.ReadOnly = true;
            // 
            // dtNameIdCatalogo
            // 
            this.dtNameIdCatalogo.DataPropertyName = "IdCatalogo";
            this.dtNameIdCatalogo.HeaderText = "IdCatalogo";
            this.dtNameIdCatalogo.Name = "dtNameIdCatalogo";
            this.dtNameIdCatalogo.ReadOnly = true;
            this.dtNameIdCatalogo.Visible = false;
            // 
            // dtNameNombreCatalogo
            // 
            this.dtNameNombreCatalogo.DataPropertyName = "NombreCatalogo";
            this.dtNameNombreCatalogo.HeaderText = "Catalogo";
            this.dtNameNombreCatalogo.Name = "dtNameNombreCatalogo";
            this.dtNameNombreCatalogo.ReadOnly = true;
            // 
            // dtNameNombreFisicoCatalogo
            // 
            this.dtNameNombreFisicoCatalogo.DataPropertyName = "NombreFisicoCatalogo";
            this.dtNameNombreFisicoCatalogo.HeaderText = "Tabla Física";
            this.dtNameNombreFisicoCatalogo.Name = "dtNameNombreFisicoCatalogo";
            this.dtNameNombreFisicoCatalogo.ReadOnly = true;
            // 
            // dtNameTablaCreada
            // 
            this.dtNameTablaCreada.DataPropertyName = "TablaCreada";
            this.dtNameTablaCreada.HeaderText = "Tabla Creada";
            this.dtNameTablaCreada.Name = "dtNameTablaCreada";
            this.dtNameTablaCreada.ReadOnly = true;
            this.dtNameTablaCreada.Visible = false;
            // 
            // dtNameReferenciada
            // 
            this.dtNameReferenciada.DataPropertyName = "Referenciada";
            this.dtNameReferenciada.HeaderText = "Referenciada";
            this.dtNameReferenciada.Name = "dtNameReferenciada";
            this.dtNameReferenciada.ReadOnly = true;
            this.dtNameReferenciada.Visible = false;
            // 
            // dtNameActivo
            // 
            this.dtNameActivo.DataPropertyName = "Activo";
            this.dtNameActivo.HeaderText = "Activo";
            this.dtNameActivo.Name = "dtNameActivo";
            this.dtNameActivo.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Buscar tabla";
            // 
            // txtBusquedaTabla
            // 
            this.txtBusquedaTabla.Location = new System.Drawing.Point(12, 41);
            this.txtBusquedaTabla.Name = "txtBusquedaTabla";
            this.txtBusquedaTabla.Size = new System.Drawing.Size(281, 26);
            this.txtBusquedaTabla.TabIndex = 17;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Location = new System.Drawing.Point(578, 44);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(166, 23);
            this.btnSeleccionar.TabIndex = 21;
            this.btnSeleccionar.Text = "Seleccionar campo";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            // 
            // CopiarColumna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 490);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.lstCampoHacerReferencia);
            this.Controls.Add(this.dtgBusquedaCatalogos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBusquedaTabla);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CopiarColumna";
            this.Text = "CopiarColumna";
            ((System.ComponentModel.ISupportInitialize)(this.dtgBusquedaCatalogos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCampoHacerReferencia;
        private System.Windows.Forms.DataGridView dtgBusquedaCatalogos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtNameIdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtNameNombreCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtNameIdCatalogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtNameNombreCatalogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtNameNombreFisicoCatalogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtNameTablaCreada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtNameReferenciada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtNameActivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBusquedaTabla;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}