namespace DMS.InterfazUsuario.CreacionEstructura
{
    partial class NuevoCatalogo
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
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.txtCodigoCatalogo = new System.Windows.Forms.TextBox();
            this.cmbTipoCatalogo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCatalogo = new System.Windows.Forms.RichTextBox();
            this.txtNombreFisicoCatalogo = new System.Windows.Forms.TextBox();
            this.chkPendienteCrear = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Location = new System.Drawing.Point(114, 315);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(55, 20);
            this.chkActivo.TabIndex = 25;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // txtCodigoCatalogo
            // 
            this.txtCodigoCatalogo.Enabled = false;
            this.txtCodigoCatalogo.Location = new System.Drawing.Point(114, 84);
            this.txtCodigoCatalogo.Name = "txtCodigoCatalogo";
            this.txtCodigoCatalogo.Size = new System.Drawing.Size(281, 22);
            this.txtCodigoCatalogo.TabIndex = 23;
            // 
            // cmbTipoCatalogo
            // 
            this.cmbTipoCatalogo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCatalogo.FormattingEnabled = true;
            this.cmbTipoCatalogo.Location = new System.Drawing.Point(114, 112);
            this.cmbTipoCatalogo.Name = "cmbTipoCatalogo";
            this.cmbTipoCatalogo.Size = new System.Drawing.Size(281, 24);
            this.cmbTipoCatalogo.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre catalogo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tipo de catalogo";
            // 
            // txtNombreCatalogo
            // 
            this.txtNombreCatalogo.Location = new System.Drawing.Point(114, 142);
            this.txtNombreCatalogo.MaxLength = 200;
            this.txtNombreCatalogo.Name = "txtNombreCatalogo";
            this.txtNombreCatalogo.Size = new System.Drawing.Size(281, 57);
            this.txtNombreCatalogo.TabIndex = 18;
            this.txtNombreCatalogo.Text = "";
            // 
            // txtNombreFisicoCatalogo
            // 
            this.txtNombreFisicoCatalogo.Location = new System.Drawing.Point(114, 205);
            this.txtNombreFisicoCatalogo.MaxLength = 50;
            this.txtNombreFisicoCatalogo.Name = "txtNombreFisicoCatalogo";
            this.txtNombreFisicoCatalogo.Size = new System.Drawing.Size(281, 22);
            this.txtNombreFisicoCatalogo.TabIndex = 19;
            // 
            // chkPendienteCrear
            // 
            this.chkPendienteCrear.AutoSize = true;
            this.chkPendienteCrear.Location = new System.Drawing.Point(114, 289);
            this.chkPendienteCrear.Name = "chkPendienteCrear";
            this.chkPendienteCrear.Size = new System.Drawing.Size(93, 20);
            this.chkPendienteCrear.TabIndex = 21;
            this.chkPendienteCrear.Text = "Tabla Creada";
            this.chkPendienteCrear.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nombre fisico";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(114, 233);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 26;
            this.numericUpDown1.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Registros Esperados";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(114, 341);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 28;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(114, 261);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 29;
            this.numericUpDown2.ThousandsSeparator = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Registros en tabla";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(68, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(293, 42);
            this.label7.TabIndex = 31;
            this.label7.Text = "NUEVO CATÁLOGO";
            // 
            // NuevoCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 397);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.txtCodigoCatalogo);
            this.Controls.Add(this.cmbTipoCatalogo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreCatalogo);
            this.Controls.Add(this.txtNombreFisicoCatalogo);
            this.Controls.Add(this.chkPendienteCrear);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NuevoCatalogo";
            this.ShowIcon = false;
            this.Text = "Crear nuevo Catálogo";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.TextBox txtCodigoCatalogo;
        private System.Windows.Forms.ComboBox cmbTipoCatalogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtNombreCatalogo;
        private System.Windows.Forms.TextBox txtNombreFisicoCatalogo;
        private System.Windows.Forms.CheckBox chkPendienteCrear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}