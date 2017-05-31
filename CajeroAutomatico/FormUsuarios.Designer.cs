namespace CajeroAutomatico
{
    partial class FormUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuarios));
            this.RegName = new System.Windows.Forms.Label();
            this.textBoxRegName = new System.Windows.Forms.TextBox();
            this.textBoxCuenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ApellidosReg = new System.Windows.Forms.Label();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.label3Balance = new System.Windows.Forms.Label();
            this.btnValidarReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegName
            // 
            this.RegName.AutoSize = true;
            this.RegName.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegName.ForeColor = System.Drawing.SystemColors.Control;
            this.RegName.Location = new System.Drawing.Point(41, 13);
            this.RegName.Name = "RegName";
            this.RegName.Size = new System.Drawing.Size(64, 16);
            this.RegName.TabIndex = 0;
            this.RegName.Text = "Nombre;";
            // 
            // textBoxRegName
            // 
            this.textBoxRegName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegName.Location = new System.Drawing.Point(44, 29);
            this.textBoxRegName.Name = "textBoxRegName";
            this.textBoxRegName.Size = new System.Drawing.Size(177, 23);
            this.textBoxRegName.TabIndex = 1;
            // 
            // textBoxCuenta
            // 
            this.textBoxCuenta.Location = new System.Drawing.Point(44, 128);
            this.textBoxCuenta.Name = "textBoxCuenta";
            this.textBoxCuenta.Size = new System.Drawing.Size(177, 20);
            this.textBoxCuenta.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(41, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero de cuenta;";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(44, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(177, 20);
            this.textBox2.TabIndex = 5;
            // 
            // ApellidosReg
            // 
            this.ApellidosReg.AutoSize = true;
            this.ApellidosReg.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApellidosReg.ForeColor = System.Drawing.SystemColors.Control;
            this.ApellidosReg.Location = new System.Drawing.Point(41, 61);
            this.ApellidosReg.Name = "ApellidosReg";
            this.ApellidosReg.Size = new System.Drawing.Size(71, 16);
            this.ApellidosReg.TabIndex = 4;
            this.ApellidosReg.Text = "Apellidos;";
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Location = new System.Drawing.Point(44, 177);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.Size = new System.Drawing.Size(177, 20);
            this.textBoxBalance.TabIndex = 7;
            // 
            // label3Balance
            // 
            this.label3Balance.AutoSize = true;
            this.label3Balance.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3Balance.ForeColor = System.Drawing.SystemColors.Control;
            this.label3Balance.Location = new System.Drawing.Point(41, 161);
            this.label3Balance.Name = "label3Balance";
            this.label3Balance.Size = new System.Drawing.Size(135, 16);
            this.label3Balance.TabIndex = 6;
            this.label3Balance.Text = "Balance disponible;";
            // 
            // btnValidarReg
            // 
            this.btnValidarReg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnValidarReg.BackgroundImage")));
            this.btnValidarReg.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidarReg.Location = new System.Drawing.Point(93, 216);
            this.btnValidarReg.Name = "btnValidarReg";
            this.btnValidarReg.Size = new System.Drawing.Size(75, 23);
            this.btnValidarReg.TabIndex = 8;
            this.btnValidarReg.Text = "Validar";
            this.btnValidarReg.UseVisualStyleBackColor = true;
            this.btnValidarReg.Click += new System.EventHandler(this.btnValidarReg_Click);
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(270, 251);
            this.Controls.Add(this.btnValidarReg);
            this.Controls.Add(this.textBoxBalance);
            this.Controls.Add(this.label3Balance);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ApellidosReg);
            this.Controls.Add(this.textBoxCuenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRegName);
            this.Controls.Add(this.RegName);
            this.Name = "FormUsuarios";
            this.Text = "Registro de Usuarios";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RegName;
        private System.Windows.Forms.TextBox textBoxRegName;
        private System.Windows.Forms.TextBox textBoxCuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label ApellidosReg;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.Label label3Balance;
        private System.Windows.Forms.Button btnValidarReg;
    }
}