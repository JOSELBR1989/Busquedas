namespace Busquedas.Sistema
{
    partial class Form1
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
            this.manejoLotes = new System.Windows.Forms.GroupBox();
            this.rdLoteNo = new System.Windows.Forms.RadioButton();
            this.rdLoteSi = new System.Windows.Forms.RadioButton();
            this.rdLoteTodos = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdActivosNo = new System.Windows.Forms.RadioButton();
            this.rdActivosSi = new System.Windows.Forms.RadioButton();
            this.rdActivosTodos = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdMigrarSAPNo = new System.Windows.Forms.RadioButton();
            this.rdMigrarSAPSi = new System.Windows.Forms.RadioButton();
            this.rdMigrarSAPTodos = new System.Windows.Forms.RadioButton();
            this.txtBusquedaMaterial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMaterialesBase = new System.Windows.Forms.TabPage();
            this.numTotalPaginas = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numHojaActual = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdelante = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.NumRegistroPorLote = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgMateriales = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBoxMostrar = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dtgEquivalentes = new System.Windows.Forms.DataGridView();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.manejoLotes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabMaterialesBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalPaginas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHojaActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRegistroPorLote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMateriales)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEquivalentes)).BeginInit();
            this.SuspendLayout();
            // 
            // manejoLotes
            // 
            this.manejoLotes.Controls.Add(this.rdLoteNo);
            this.manejoLotes.Controls.Add(this.rdLoteSi);
            this.manejoLotes.Controls.Add(this.rdLoteTodos);
            this.manejoLotes.Location = new System.Drawing.Point(12, 12);
            this.manejoLotes.Name = "manejoLotes";
            this.manejoLotes.Size = new System.Drawing.Size(277, 50);
            this.manejoLotes.TabIndex = 0;
            this.manejoLotes.TabStop = false;
            this.manejoLotes.Text = "Lotes";
            // 
            // rdLoteNo
            // 
            this.rdLoteNo.AutoSize = true;
            this.rdLoteNo.Location = new System.Drawing.Point(151, 20);
            this.rdLoteNo.Name = "rdLoteNo";
            this.rdLoteNo.Size = new System.Drawing.Size(94, 20);
            this.rdLoteNo.TabIndex = 5;
            this.rdLoteNo.Text = "No maneja lotes";
            this.rdLoteNo.UseVisualStyleBackColor = true;
            // 
            // rdLoteSi
            // 
            this.rdLoteSi.AutoSize = true;
            this.rdLoteSi.Location = new System.Drawing.Point(63, 20);
            this.rdLoteSi.Name = "rdLoteSi";
            this.rdLoteSi.Size = new System.Drawing.Size(82, 20);
            this.rdLoteSi.TabIndex = 4;
            this.rdLoteSi.Text = "Maneja Lotes";
            this.rdLoteSi.UseVisualStyleBackColor = true;
            // 
            // rdLoteTodos
            // 
            this.rdLoteTodos.AutoSize = true;
            this.rdLoteTodos.Checked = true;
            this.rdLoteTodos.Location = new System.Drawing.Point(6, 20);
            this.rdLoteTodos.Name = "rdLoteTodos";
            this.rdLoteTodos.Size = new System.Drawing.Size(51, 20);
            this.rdLoteTodos.TabIndex = 3;
            this.rdLoteTodos.TabStop = true;
            this.rdLoteTodos.Text = "Todos";
            this.rdLoteTodos.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdActivosNo);
            this.groupBox1.Controls.Add(this.rdActivosSi);
            this.groupBox1.Controls.Add(this.rdActivosTodos);
            this.groupBox1.Location = new System.Drawing.Point(295, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 50);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Activos";
            // 
            // rdActivosNo
            // 
            this.rdActivosNo.AutoSize = true;
            this.rdActivosNo.Location = new System.Drawing.Point(151, 20);
            this.rdActivosNo.Name = "rdActivosNo";
            this.rdActivosNo.Size = new System.Drawing.Size(83, 20);
            this.rdActivosNo.TabIndex = 5;
            this.rdActivosNo.Text = "Desactivados";
            this.rdActivosNo.UseVisualStyleBackColor = true;
            // 
            // rdActivosSi
            // 
            this.rdActivosSi.AutoSize = true;
            this.rdActivosSi.Checked = true;
            this.rdActivosSi.Location = new System.Drawing.Point(63, 20);
            this.rdActivosSi.Name = "rdActivosSi";
            this.rdActivosSi.Size = new System.Drawing.Size(78, 20);
            this.rdActivosSi.TabIndex = 4;
            this.rdActivosSi.TabStop = true;
            this.rdActivosSi.Text = "Solo activos";
            this.rdActivosSi.UseVisualStyleBackColor = true;
            // 
            // rdActivosTodos
            // 
            this.rdActivosTodos.AutoSize = true;
            this.rdActivosTodos.Location = new System.Drawing.Point(6, 20);
            this.rdActivosTodos.Name = "rdActivosTodos";
            this.rdActivosTodos.Size = new System.Drawing.Size(51, 20);
            this.rdActivosTodos.TabIndex = 3;
            this.rdActivosTodos.Text = "Todos";
            this.rdActivosTodos.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdMigrarSAPNo);
            this.groupBox2.Controls.Add(this.rdMigrarSAPSi);
            this.groupBox2.Controls.Add(this.rdMigrarSAPTodos);
            this.groupBox2.Location = new System.Drawing.Point(578, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 50);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Migrar a SAP";
            // 
            // rdMigrarSAPNo
            // 
            this.rdMigrarSAPNo.AutoSize = true;
            this.rdMigrarSAPNo.Location = new System.Drawing.Point(151, 20);
            this.rdMigrarSAPNo.Name = "rdMigrarSAPNo";
            this.rdMigrarSAPNo.Size = new System.Drawing.Size(101, 20);
            this.rdMigrarSAPNo.TabIndex = 5;
            this.rdMigrarSAPNo.Text = "No Migrar a SAP";
            this.rdMigrarSAPNo.UseVisualStyleBackColor = true;
            // 
            // rdMigrarSAPSi
            // 
            this.rdMigrarSAPSi.AutoSize = true;
            this.rdMigrarSAPSi.Location = new System.Drawing.Point(63, 20);
            this.rdMigrarSAPSi.Name = "rdMigrarSAPSi";
            this.rdMigrarSAPSi.Size = new System.Drawing.Size(85, 20);
            this.rdMigrarSAPSi.TabIndex = 4;
            this.rdMigrarSAPSi.Text = "Migrar a SAP";
            this.rdMigrarSAPSi.UseVisualStyleBackColor = true;
            // 
            // rdMigrarSAPTodos
            // 
            this.rdMigrarSAPTodos.AutoSize = true;
            this.rdMigrarSAPTodos.Checked = true;
            this.rdMigrarSAPTodos.Location = new System.Drawing.Point(6, 20);
            this.rdMigrarSAPTodos.Name = "rdMigrarSAPTodos";
            this.rdMigrarSAPTodos.Size = new System.Drawing.Size(51, 20);
            this.rdMigrarSAPTodos.TabIndex = 3;
            this.rdMigrarSAPTodos.TabStop = true;
            this.rdMigrarSAPTodos.Text = "Todos";
            this.rdMigrarSAPTodos.UseVisualStyleBackColor = true;
            // 
            // txtBusquedaMaterial
            // 
            this.txtBusquedaMaterial.Location = new System.Drawing.Point(705, 9);
            this.txtBusquedaMaterial.Name = "txtBusquedaMaterial";
            this.txtBusquedaMaterial.Size = new System.Drawing.Size(209, 21);
            this.txtBusquedaMaterial.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(636, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Buscar datos";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabMaterialesBase);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 216);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(931, 293);
            this.tabControl1.TabIndex = 10;
            // 
            // tabMaterialesBase
            // 
            this.tabMaterialesBase.Controls.Add(this.numTotalPaginas);
            this.tabMaterialesBase.Controls.Add(this.label4);
            this.tabMaterialesBase.Controls.Add(this.label1);
            this.tabMaterialesBase.Controls.Add(this.comboBox1);
            this.tabMaterialesBase.Controls.Add(this.txtBusquedaMaterial);
            this.tabMaterialesBase.Controls.Add(this.numHojaActual);
            this.tabMaterialesBase.Controls.Add(this.label3);
            this.tabMaterialesBase.Controls.Add(this.btnAdelante);
            this.tabMaterialesBase.Controls.Add(this.btnAtras);
            this.tabMaterialesBase.Controls.Add(this.NumRegistroPorLote);
            this.tabMaterialesBase.Controls.Add(this.label2);
            this.tabMaterialesBase.Controls.Add(this.dtgMateriales);
            this.tabMaterialesBase.Location = new System.Drawing.Point(4, 25);
            this.tabMaterialesBase.Name = "tabMaterialesBase";
            this.tabMaterialesBase.Padding = new System.Windows.Forms.Padding(3);
            this.tabMaterialesBase.Size = new System.Drawing.Size(923, 264);
            this.tabMaterialesBase.TabIndex = 0;
            this.tabMaterialesBase.Text = "Materiales";
            this.tabMaterialesBase.UseVisualStyleBackColor = true;
            // 
            // numTotalPaginas
            // 
            this.numTotalPaginas.Location = new System.Drawing.Point(403, 10);
            this.numTotalPaginas.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numTotalPaginas.Name = "numTotalPaginas";
            this.numTotalPaginas.ReadOnly = true;
            this.numTotalPaginas.Size = new System.Drawing.Size(48, 21);
            this.numTotalPaginas.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Orden";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(168, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(88, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // numHojaActual
            // 
            this.numHojaActual.Location = new System.Drawing.Point(349, 9);
            this.numHojaActual.Name = "numHojaActual";
            this.numHojaActual.Size = new System.Drawing.Size(48, 21);
            this.numHojaActual.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total de registros (0)";
            // 
            // btnAdelante
            // 
            this.btnAdelante.Location = new System.Drawing.Point(457, 9);
            this.btnAdelante.Name = "btnAdelante";
            this.btnAdelante.Size = new System.Drawing.Size(53, 23);
            this.btnAdelante.TabIndex = 4;
            this.btnAdelante.Tag = "1";
            this.btnAdelante.Text = "Adelante";
            this.btnAdelante.UseVisualStyleBackColor = true;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(288, 8);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(53, 23);
            this.btnAtras.TabIndex = 3;
            this.btnAtras.Tag = "-1";
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            // 
            // NumRegistroPorLote
            // 
            this.NumRegistroPorLote.Location = new System.Drawing.Point(73, 9);
            this.NumRegistroPorLote.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumRegistroPorLote.Name = "NumRegistroPorLote";
            this.NumRegistroPorLote.Size = new System.Drawing.Size(49, 21);
            this.NumRegistroPorLote.TabIndex = 2;
            this.NumRegistroPorLote.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reg. x Vista";
            // 
            // dtgMateriales
            // 
            this.dtgMateriales.AllowUserToAddRows = false;
            this.dtgMateriales.AllowUserToDeleteRows = false;
            this.dtgMateriales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgMateriales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMateriales.Location = new System.Drawing.Point(8, 39);
            this.dtgMateriales.MultiSelect = false;
            this.dtgMateriales.Name = "dtgMateriales";
            this.dtgMateriales.ReadOnly = true;
            this.dtgMateriales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMateriales.Size = new System.Drawing.Size(909, 219);
            this.dtgMateriales.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.richTextBox2);
            this.tabPage2.Controls.Add(this.dtgEquivalentes);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(923, 264);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Equivalentes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBoxMostrar);
            this.groupBox3.Location = new System.Drawing.Point(12, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(843, 142);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion de producto seleccionado";
            // 
            // groupBoxMostrar
            // 
            this.groupBoxMostrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMostrar.Controls.Add(this.checkBox1);
            this.groupBoxMostrar.Controls.Add(this.richTextBox1);
            this.groupBoxMostrar.Controls.Add(this.label5);
            this.groupBoxMostrar.Location = new System.Drawing.Point(6, 20);
            this.groupBoxMostrar.Name = "groupBoxMostrar";
            this.groupBoxMostrar.Size = new System.Drawing.Size(831, 116);
            this.groupBoxMostrar.TabIndex = 0;
            this.groupBoxMostrar.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Descripcion de material";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(129, 14);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(587, 96);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(737, 14);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 20);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Migrar a SAP";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dtgEquivalentes
            // 
            this.dtgEquivalentes.AllowUserToAddRows = false;
            this.dtgEquivalentes.AllowUserToDeleteRows = false;
            this.dtgEquivalentes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgEquivalentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgEquivalentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEquivalentes.Location = new System.Drawing.Point(7, 23);
            this.dtgEquivalentes.MultiSelect = false;
            this.dtgEquivalentes.Name = "dtgEquivalentes";
            this.dtgEquivalentes.ReadOnly = true;
            this.dtgEquivalentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgEquivalentes.Size = new System.Drawing.Size(829, 149);
            this.dtgEquivalentes.TabIndex = 1;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox2.Location = new System.Drawing.Point(7, 178);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(910, 80);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(842, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar Eq.";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 521);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.manejoLotes);
            this.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.manejoLotes.ResumeLayout(false);
            this.manejoLotes.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabMaterialesBase.ResumeLayout(false);
            this.tabMaterialesBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalPaginas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHojaActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRegistroPorLote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMateriales)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBoxMostrar.ResumeLayout(false);
            this.groupBoxMostrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEquivalentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox manejoLotes;
        private System.Windows.Forms.RadioButton rdLoteTodos;
        private System.Windows.Forms.RadioButton rdLoteSi;
        private System.Windows.Forms.RadioButton rdLoteNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdActivosNo;
        private System.Windows.Forms.RadioButton rdActivosSi;
        private System.Windows.Forms.RadioButton rdActivosTodos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdMigrarSAPNo;
        private System.Windows.Forms.RadioButton rdMigrarSAPSi;
        private System.Windows.Forms.RadioButton rdMigrarSAPTodos;
        private System.Windows.Forms.TextBox txtBusquedaMaterial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMaterialesBase;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtgMateriales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumRegistroPorLote;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnAdelante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numHojaActual;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numTotalPaginas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBoxMostrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView dtgEquivalentes;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button1;
    }
}

