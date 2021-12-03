
namespace PF.InterfazUsuario
{
    partial class Plazo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this._cbTipoPf = new System.Windows.Forms.ComboBox();
            this._txtTasa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._txtCapitalInv = new System.Windows.Forms.TextBox();
            this._txtDias = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._txtInteresARecibir = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._txtMontoFinal = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this._btnAlta = new System.Windows.Forms.Button();
            this._btnLimpiar = new System.Windows.Forms.Button();
            this._btnSimular = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this._txtComisonTotal = new System.Windows.Forms.TextBox();
            this._txtMontoTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._lstPlazos = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo plazo Fijo";
            // 
            // _cbTipoPf
            // 
            this._cbTipoPf.FormattingEnabled = true;
            this._cbTipoPf.Location = new System.Drawing.Point(175, 24);
            this._cbTipoPf.Name = "_cbTipoPf";
            this._cbTipoPf.Size = new System.Drawing.Size(121, 21);
            this._cbTipoPf.TabIndex = 1;
            this._cbTipoPf.SelectedIndexChanged += new System.EventHandler(this._cbTipoPf_SelectedIndexChanged);
            // 
            // _txtTasa
            // 
            this._txtTasa.Enabled = false;
            this._txtTasa.Location = new System.Drawing.Point(175, 66);
            this._txtTasa.Name = "_txtTasa";
            this._txtTasa.Size = new System.Drawing.Size(121, 20);
            this._txtTasa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tasa de Interes";
            // 
            // _txtCapitalInv
            // 
            this._txtCapitalInv.Location = new System.Drawing.Point(175, 112);
            this._txtCapitalInv.Name = "_txtCapitalInv";
            this._txtCapitalInv.Size = new System.Drawing.Size(121, 20);
            this._txtCapitalInv.TabIndex = 4;
            // 
            // _txtDias
            // 
            this._txtDias.Location = new System.Drawing.Point(175, 156);
            this._txtDias.Name = "_txtDias";
            this._txtDias.Size = new System.Drawing.Size(121, 20);
            this._txtDias.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Capital a Invertir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dias";
            // 
            // _txtInteresARecibir
            // 
            this._txtInteresARecibir.Enabled = false;
            this._txtInteresARecibir.Location = new System.Drawing.Point(175, 202);
            this._txtInteresARecibir.Name = "_txtInteresARecibir";
            this._txtInteresARecibir.Size = new System.Drawing.Size(121, 20);
            this._txtInteresARecibir.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Interes a Recibir";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Monto Final";
            // 
            // _txtMontoFinal
            // 
            this._txtMontoFinal.Enabled = false;
            this._txtMontoFinal.Location = new System.Drawing.Point(175, 255);
            this._txtMontoFinal.Name = "_txtMontoFinal";
            this._txtMontoFinal.Size = new System.Drawing.Size(121, 20);
            this._txtMontoFinal.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._btnAlta);
            this.panel1.Controls.Add(this._btnLimpiar);
            this.panel1.Controls.Add(this._btnSimular);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this._txtMontoFinal);
            this.panel1.Controls.Add(this._cbTipoPf);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this._txtTasa);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this._txtInteresARecibir);
            this.panel1.Controls.Add(this._txtCapitalInv);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this._txtDias);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 402);
            this.panel1.TabIndex = 12;
            // 
            // _btnAlta
            // 
            this._btnAlta.Location = new System.Drawing.Point(28, 355);
            this._btnAlta.Name = "_btnAlta";
            this._btnAlta.Size = new System.Drawing.Size(246, 23);
            this._btnAlta.TabIndex = 14;
            this._btnAlta.Text = "ALTA";
            this._btnAlta.UseVisualStyleBackColor = true;
            this._btnAlta.Click += new System.EventHandler(this._btnAlta_Click);
            // 
            // _btnLimpiar
            // 
            this._btnLimpiar.Location = new System.Drawing.Point(175, 309);
            this._btnLimpiar.Name = "_btnLimpiar";
            this._btnLimpiar.Size = new System.Drawing.Size(99, 23);
            this._btnLimpiar.TabIndex = 13;
            this._btnLimpiar.Text = "LIMPIAR";
            this._btnLimpiar.UseVisualStyleBackColor = true;
            this._btnLimpiar.Click += new System.EventHandler(this._btnLimpiar_Click);
            // 
            // _btnSimular
            // 
            this._btnSimular.Location = new System.Drawing.Point(28, 309);
            this._btnSimular.Name = "_btnSimular";
            this._btnSimular.Size = new System.Drawing.Size(99, 23);
            this._btnSimular.TabIndex = 12;
            this._btnSimular.Text = "SIMULAR";
            this._btnSimular.UseVisualStyleBackColor = true;
            this._btnSimular.Click += new System.EventHandler(this._btnSimular_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._txtComisonTotal);
            this.panel2.Controls.Add(this._txtMontoTotal);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this._lstPlazos);
            this.panel2.Location = new System.Drawing.Point(389, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 402);
            this.panel2.TabIndex = 15;
            // 
            // _txtComisonTotal
            // 
            this._txtComisonTotal.Enabled = false;
            this._txtComisonTotal.Location = new System.Drawing.Point(181, 360);
            this._txtComisonTotal.Name = "_txtComisonTotal";
            this._txtComisonTotal.Size = new System.Drawing.Size(121, 20);
            this._txtComisonTotal.TabIndex = 16;
            // 
            // _txtMontoTotal
            // 
            this._txtMontoTotal.Enabled = false;
            this._txtMontoTotal.Location = new System.Drawing.Point(181, 321);
            this._txtMontoTotal.Name = "_txtMontoTotal";
            this._txtMontoTotal.Size = new System.Drawing.Size(121, 20);
            this._txtMontoTotal.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Comision Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Monto Total";
            // 
            // _lstPlazos
            // 
            this._lstPlazos.FormattingEnabled = true;
            this._lstPlazos.Location = new System.Drawing.Point(0, 0);
            this._lstPlazos.Name = "_lstPlazos";
            this._lstPlazos.Size = new System.Drawing.Size(372, 290);
            this._lstPlazos.TabIndex = 0;
            // 
            // Plazo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Plazo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Plazo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _cbTipoPf;
        private System.Windows.Forms.TextBox _txtTasa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtCapitalInv;
        private System.Windows.Forms.TextBox _txtDias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _txtInteresARecibir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _txtMontoFinal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button _btnAlta;
        private System.Windows.Forms.Button _btnLimpiar;
        private System.Windows.Forms.Button _btnSimular;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox _txtComisonTotal;
        private System.Windows.Forms.TextBox _txtMontoTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox _lstPlazos;
    }
}

