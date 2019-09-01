namespace TempConverter
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtcen = new System.Windows.Forms.TextBox();
            this.txtfar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(35, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grados Centigrados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(35, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grados Farenheit:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // txtcen
            // 
            this.txtcen.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtcen.Location = new System.Drawing.Point(251, 81);
            this.txtcen.Name = "txtcen";
            this.txtcen.Size = new System.Drawing.Size(143, 20);
            this.txtcen.TabIndex = 2;
            this.txtcen.TextChanged += new System.EventHandler(this.Txtcen_TextChanged);
            this.txtcen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtcen_KeyPress);
            // 
            // txtfar
            // 
            this.txtfar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtfar.Location = new System.Drawing.Point(251, 155);
            this.txtfar.Name = "txtfar";
            this.txtfar.Size = new System.Drawing.Size(143, 20);
            this.txtfar.TabIndex = 3;
            this.txtfar.TextChanged += new System.EventHandler(this.Txtfar_TextChanged);
            this.txtfar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtfar_KeyPress);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(251, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 80);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(427, 311);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtfar);
            this.Controls.Add(this.txtcen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Convertidor de Temperaturas";
            this.TransparencyKey = System.Drawing.SystemColors.Desktop;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcen;
        private System.Windows.Forms.TextBox txtfar;
        private System.Windows.Forms.Button button1;
    }
}

