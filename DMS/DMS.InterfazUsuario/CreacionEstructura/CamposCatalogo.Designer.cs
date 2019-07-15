namespace DMS.InterfazUsuario.CreacionEstructura
{
    partial class CamposCatalogo
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
            this.txtNombreColumna = new System.Windows.Forms.TextBox();
            this.cmbAgrupacion = new System.Windows.Forms.ComboBox();
            this.txtDescripcionColumna = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreTecnicoColumna = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipoDato = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuardarRegistro = new System.Windows.Forms.Button();
            this.lblEncabezadoCatalogo = new System.Windows.Forms.Label();
            this.numTamanio = new System.Windows.Forms.NumericUpDown();
            this.numPresicion = new System.Windows.Forms.NumericUpDown();
            this.txtOrden = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.chkRequerido = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numTamanio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPresicion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agrupacion";
            // 
            // txtNombreColumna
            // 
            this.txtNombreColumna.Location = new System.Drawing.Point(109, 121);
            this.txtNombreColumna.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreColumna.MaxLength = 100;
            this.txtNombreColumna.Name = "txtNombreColumna";
            this.txtNombreColumna.Size = new System.Drawing.Size(342, 22);
            this.txtNombreColumna.TabIndex = 3;
            this.txtNombreColumna.Tag = "Nombre";
            // 
            // cmbAgrupacion
            // 
            this.cmbAgrupacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAgrupacion.FormattingEnabled = true;
            this.cmbAgrupacion.Location = new System.Drawing.Point(109, 93);
            this.cmbAgrupacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbAgrupacion.Name = "cmbAgrupacion";
            this.cmbAgrupacion.Size = new System.Drawing.Size(192, 24);
            this.cmbAgrupacion.TabIndex = 2;
            // 
            // txtDescripcionColumna
            // 
            this.txtDescripcionColumna.Location = new System.Drawing.Point(109, 148);
            this.txtDescripcionColumna.Name = "txtDescripcionColumna";
            this.txtDescripcionColumna.Size = new System.Drawing.Size(342, 61);
            this.txtDescripcionColumna.TabIndex = 4;
            this.txtDescripcionColumna.Tag = "Descripción";
            this.txtDescripcionColumna.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descripción";
            // 
            // txtNombreTecnicoColumna
            // 
            this.txtNombreTecnicoColumna.Location = new System.Drawing.Point(109, 215);
            this.txtNombreTecnicoColumna.MaxLength = 20;
            this.txtNombreTecnicoColumna.Name = "txtNombreTecnicoColumna";
            this.txtNombreTecnicoColumna.Size = new System.Drawing.Size(192, 22);
            this.txtNombreTecnicoColumna.TabIndex = 7;
            this.txtNombreTecnicoColumna.Tag = "Nombre técnico";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 218);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nombre técnico";
            // 
            // cmbTipoDato
            // 
            this.cmbTipoDato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDato.FormattingEnabled = true;
            this.cmbTipoDato.Items.AddRange(new object[] {
            "NVARCHAR",
            "DECIMAL",
            "DATE"});
            this.cmbTipoDato.Location = new System.Drawing.Point(109, 243);
            this.cmbTipoDato.Name = "cmbTipoDato";
            this.cmbTipoDato.Size = new System.Drawing.Size(192, 24);
            this.cmbTipoDato.TabIndex = 9;
            this.cmbTipoDato.Tag = "Tipo de dato";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 246);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tipo de dato";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 218);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tamaño";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(390, 218);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Presición";
            // 
            // btnGuardarRegistro
            // 
            this.btnGuardarRegistro.Location = new System.Drawing.Point(109, 310);
            this.btnGuardarRegistro.Name = "btnGuardarRegistro";
            this.btnGuardarRegistro.Size = new System.Drawing.Size(161, 23);
            this.btnGuardarRegistro.TabIndex = 18;
            this.btnGuardarRegistro.Text = "Guardar registro";
            this.btnGuardarRegistro.UseVisualStyleBackColor = true;
            // 
            // lblEncabezadoCatalogo
            // 
            this.lblEncabezadoCatalogo.AutoSize = true;
            this.lblEncabezadoCatalogo.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezadoCatalogo.Location = new System.Drawing.Point(104, 9);
            this.lblEncabezadoCatalogo.Name = "lblEncabezadoCatalogo";
            this.lblEncabezadoCatalogo.Size = new System.Drawing.Size(0, 25);
            this.lblEncabezadoCatalogo.TabIndex = 19;
            // 
            // numTamanio
            // 
            this.numTamanio.Location = new System.Drawing.Point(307, 244);
            this.numTamanio.Name = "numTamanio";
            this.numTamanio.Size = new System.Drawing.Size(69, 22);
            this.numTamanio.TabIndex = 11;
            // 
            // numPresicion
            // 
            this.numPresicion.Location = new System.Drawing.Point(382, 244);
            this.numPresicion.Name = "numPresicion";
            this.numPresicion.Size = new System.Drawing.Size(69, 22);
            this.numPresicion.TabIndex = 12;
            // 
            // txtOrden
            // 
            this.txtOrden.Location = new System.Drawing.Point(109, 273);
            this.txtOrden.MaxLength = 20;
            this.txtOrden.Name = "txtOrden";
            this.txtOrden.Size = new System.Drawing.Size(192, 22);
            this.txtOrden.TabIndex = 24;
            this.txtOrden.Tag = "Orden";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 276);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Orden";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(109, 66);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(192, 22);
            this.txtCodigo.TabIndex = 27;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chkRequerido
            // 
            this.chkRequerido.AutoSize = true;
            this.chkRequerido.Location = new System.Drawing.Point(374, 93);
            this.chkRequerido.Name = "chkRequerido";
            this.chkRequerido.Size = new System.Drawing.Size(77, 20);
            this.chkRequerido.TabIndex = 28;
            this.chkRequerido.Text = "Requerido";
            this.chkRequerido.UseVisualStyleBackColor = true;
            // 
            // CamposCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 344);
            this.Controls.Add(this.chkRequerido);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtOrden);
            this.Controls.Add(this.numPresicion);
            this.Controls.Add(this.numTamanio);
            this.Controls.Add(this.lblEncabezadoCatalogo);
            this.Controls.Add(this.btnGuardarRegistro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbTipoDato);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombreTecnicoColumna);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescripcionColumna);
            this.Controls.Add(this.cmbAgrupacion);
            this.Controls.Add(this.txtNombreColumna);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CamposCatalogo";
            this.ShowIcon = false;
            this.Text = "Agregar campos a Catalogo";
            ((System.ComponentModel.ISupportInitialize)(this.numTamanio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPresicion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreColumna;
        private System.Windows.Forms.ComboBox cmbAgrupacion;
        private System.Windows.Forms.RichTextBox txtDescripcionColumna;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreTecnicoColumna;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipoDato;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGuardarRegistro;
        private System.Windows.Forms.Label lblEncabezadoCatalogo;
        private System.Windows.Forms.NumericUpDown numTamanio;
        private System.Windows.Forms.NumericUpDown numPresicion;
        private System.Windows.Forms.TextBox txtOrden;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.CheckBox chkRequerido;
    }
}