namespace ProgramacionExamenII
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEgresos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIngresos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtValorS = new System.Windows.Forms.TextBox();
            this.txtInflacion = new System.Windows.Forms.TextBox();
            this.txtTasa = new System.Windows.Forms.TextBox();
            this.txtPlazo = new System.Windows.Forms.TextBox();
            this.txtInvertir = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFinan = new System.Windows.Forms.DataGridView();
            this.lblVPN = new System.Windows.Forms.Label();
            this.lblPR = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtEgresos);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtIngresos);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnCrear);
            this.groupBox1.Controls.Add(this.txtValorS);
            this.groupBox1.Controls.Add(this.txtInflacion);
            this.groupBox1.Controls.Add(this.txtTasa);
            this.groupBox1.Controls.Add(this.txtPlazo);
            this.groupBox1.Controls.Add(this.txtInvertir);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(144, 559);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtEgresos
            // 
            this.txtEgresos.Location = new System.Drawing.Point(6, 473);
            this.txtEgresos.Name = "txtEgresos";
            this.txtEgresos.Size = new System.Drawing.Size(127, 22);
            this.txtEgresos.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 444);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Egresos";
            // 
            // txtIngresos
            // 
            this.txtIngresos.Location = new System.Drawing.Point(6, 409);
            this.txtIngresos.Name = "txtIngresos";
            this.txtIngresos.Size = new System.Drawing.Size(127, 22);
            this.txtIngresos.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ingresos";
            // 
            // btnCrear
            // 
            this.btnCrear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCrear.Location = new System.Drawing.Point(11, 514);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(100, 25);
            this.btnCrear.TabIndex = 10;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // txtValorS
            // 
            this.txtValorS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorS.Location = new System.Drawing.Point(6, 343);
            this.txtValorS.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorS.Name = "txtValorS";
            this.txtValorS.Size = new System.Drawing.Size(127, 22);
            this.txtValorS.TabIndex = 9;
            // 
            // txtInflacion
            // 
            this.txtInflacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInflacion.Location = new System.Drawing.Point(6, 271);
            this.txtInflacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtInflacion.Name = "txtInflacion";
            this.txtInflacion.Size = new System.Drawing.Size(123, 22);
            this.txtInflacion.TabIndex = 8;
            // 
            // txtTasa
            // 
            this.txtTasa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTasa.Location = new System.Drawing.Point(6, 200);
            this.txtTasa.Margin = new System.Windows.Forms.Padding(4);
            this.txtTasa.Name = "txtTasa";
            this.txtTasa.Size = new System.Drawing.Size(123, 22);
            this.txtTasa.TabIndex = 7;
            // 
            // txtPlazo
            // 
            this.txtPlazo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPlazo.Location = new System.Drawing.Point(8, 134);
            this.txtPlazo.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlazo.Name = "txtPlazo";
            this.txtPlazo.Size = new System.Drawing.Size(123, 22);
            this.txtPlazo.TabIndex = 6;
            // 
            // txtInvertir
            // 
            this.txtInvertir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtInvertir.Location = new System.Drawing.Point(8, 63);
            this.txtInvertir.Margin = new System.Windows.Forms.Padding(4);
            this.txtInvertir.Name = "txtInvertir";
            this.txtInvertir.Size = new System.Drawing.Size(125, 22);
            this.txtInvertir.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 312);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valor Salvaguardar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 240);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Inflaciòn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tasa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Plazo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invertir";
            // 
            // dgvFinan
            // 
            this.dgvFinan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFinan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinan.Location = new System.Drawing.Point(196, 46);
            this.dgvFinan.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFinan.Name = "dgvFinan";
            this.dgvFinan.RowHeadersWidth = 51;
            this.dgvFinan.Size = new System.Drawing.Size(859, 483);
            this.dgvFinan.TabIndex = 1;
            // 
            // lblVPN
            // 
            this.lblVPN.AutoSize = true;
            this.lblVPN.Location = new System.Drawing.Point(368, 553);
            this.lblVPN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVPN.Name = "lblVPN";
            this.lblVPN.Size = new System.Drawing.Size(44, 17);
            this.lblVPN.TabIndex = 2;
            this.lblVPN.Text = "VPN :";
            // 
            // lblPR
            // 
            this.lblPR.AutoSize = true;
            this.lblPR.Location = new System.Drawing.Point(758, 553);
            this.lblPR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPR.Name = "lblPR";
            this.lblPR.Size = new System.Drawing.Size(35, 17);
            this.lblPR.TabIndex = 3;
            this.lblPR.Text = "PR :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 593);
            this.Controls.Add(this.lblPR);
            this.Controls.Add(this.lblVPN);
            this.Controls.Add(this.dgvFinan);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtValorS;
        private System.Windows.Forms.TextBox txtInflacion;
        private System.Windows.Forms.TextBox txtTasa;
        private System.Windows.Forms.TextBox txtPlazo;
        private System.Windows.Forms.TextBox txtInvertir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFinan;
        private System.Windows.Forms.Label lblVPN;
        private System.Windows.Forms.Label lblPR;
        private System.Windows.Forms.TextBox txtEgresos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIngresos;
        private System.Windows.Forms.Label label6;
    }
}

