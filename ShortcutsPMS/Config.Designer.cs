namespace ShortcutsPMS
{
    partial class Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxConceptoSrv = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtBxConceptoProd = new System.Windows.Forms.TextBox();
            this.lblServ = new System.Windows.Forms.Label();
            this.lblProd = new System.Windows.Forms.Label();
            this.txtCodServ = new System.Windows.Forms.TextBox();
            this.txtCodProd = new System.Windows.Forms.TextBox();
            this.txtInstancia = new System.Windows.Forms.TextBox();
            this.txtBdd = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodTrat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBxConceptoTrat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(290, 299);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(121, 34);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "SALIR";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Concepto :";
            // 
            // txtBxConceptoSrv
            // 
            this.txtBxConceptoSrv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxConceptoSrv.Location = new System.Drawing.Point(253, 37);
            this.txtBxConceptoSrv.MaxLength = 100;
            this.txtBxConceptoSrv.Name = "txtBxConceptoSrv";
            this.txtBxConceptoSrv.Size = new System.Drawing.Size(180, 26);
            this.txtBxConceptoSrv.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(327, 253);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(84, 26);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtBxConceptoProd
            // 
            this.txtBxConceptoProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxConceptoProd.Location = new System.Drawing.Point(253, 69);
            this.txtBxConceptoProd.Name = "txtBxConceptoProd";
            this.txtBxConceptoProd.Size = new System.Drawing.Size(180, 26);
            this.txtBxConceptoProd.TabIndex = 7;
            // 
            // lblServ
            // 
            this.lblServ.AutoSize = true;
            this.lblServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServ.Location = new System.Drawing.Point(72, 40);
            this.lblServ.Name = "lblServ";
            this.lblServ.Size = new System.Drawing.Size(72, 20);
            this.lblServ.TabIndex = 8;
            this.lblServ.Text = "Servicios";
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProd.Location = new System.Drawing.Point(63, 72);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(81, 20);
            this.lblProd.TabIndex = 9;
            this.lblProd.Text = "Productos";
            // 
            // txtCodServ
            // 
            this.txtCodServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodServ.Location = new System.Drawing.Point(175, 37);
            this.txtCodServ.Name = "txtCodServ";
            this.txtCodServ.Size = new System.Drawing.Size(72, 26);
            this.txtCodServ.TabIndex = 10;
            // 
            // txtCodProd
            // 
            this.txtCodProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProd.Location = new System.Drawing.Point(175, 69);
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.Size = new System.Drawing.Size(72, 26);
            this.txtCodProd.TabIndex = 11;
            // 
            // txtInstancia
            // 
            this.txtInstancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstancia.Location = new System.Drawing.Point(175, 154);
            this.txtInstancia.Name = "txtInstancia";
            this.txtInstancia.Size = new System.Drawing.Size(180, 26);
            this.txtInstancia.TabIndex = 12;
            // 
            // txtBdd
            // 
            this.txtBdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBdd.Location = new System.Drawing.Point(175, 186);
            this.txtBdd.Name = "txtBdd";
            this.txtBdd.Size = new System.Drawing.Size(180, 26);
            this.txtBdd.TabIndex = 13;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(175, 218);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(180, 26);
            this.txtPass.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Instancia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Base de Datos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Password";
            // 
            // txtCodTrat
            // 
            this.txtCodTrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodTrat.Location = new System.Drawing.Point(175, 103);
            this.txtCodTrat.Name = "txtCodTrat";
            this.txtCodTrat.Size = new System.Drawing.Size(72, 26);
            this.txtCodTrat.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tratamientos";
            // 
            // txtBxConceptoTrat
            // 
            this.txtBxConceptoTrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxConceptoTrat.Location = new System.Drawing.Point(253, 103);
            this.txtBxConceptoTrat.Name = "txtBxConceptoTrat";
            this.txtBxConceptoTrat.Size = new System.Drawing.Size(180, 26);
            this.txtBxConceptoTrat.TabIndex = 18;
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(445, 336);
            this.Controls.Add(this.txtCodTrat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBxConceptoTrat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtBdd);
            this.Controls.Add(this.txtInstancia);
            this.Controls.Add(this.txtCodProd);
            this.Controls.Add(this.txtCodServ);
            this.Controls.Add(this.lblProd);
            this.Controls.Add(this.lblServ);
            this.Controls.Add(this.txtBxConceptoProd);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtBxConceptoSrv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Config";
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.Config_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxConceptoSrv;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtBxConceptoProd;
        private System.Windows.Forms.Label lblServ;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.TextBox txtCodServ;
        private System.Windows.Forms.TextBox txtCodProd;
        private System.Windows.Forms.TextBox txtInstancia;
        private System.Windows.Forms.TextBox txtBdd;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodTrat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBxConceptoTrat;
    }
}