namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelegrama = new System.Windows.Forms.TextBox();
            this.rdOrdinario = new System.Windows.Forms.RadioButton();
            this.rdUrgente = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(525, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(106, 234);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Coste";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Texto";
            // 
            // txtTelegrama
            // 
            this.txtTelegrama.Location = new System.Drawing.Point(70, 29);
            this.txtTelegrama.Multiline = true;
            this.txtTelegrama.Name = "txtTelegrama";
            this.txtTelegrama.Size = new System.Drawing.Size(571, 144);
            this.txtTelegrama.TabIndex = 6;
            this.txtTelegrama.TextChanged += new System.EventHandler(this.txtTelegrama_TextChanged);
            // 
            // rdOrdinario
            // 
            this.rdOrdinario.AutoSize = true;
            this.rdOrdinario.Checked = true;
            this.rdOrdinario.Location = new System.Drawing.Point(69, 198);
            this.rdOrdinario.Name = "rdOrdinario";
            this.rdOrdinario.Size = new System.Drawing.Size(67, 17);
            this.rdOrdinario.TabIndex = 7;
            this.rdOrdinario.TabStop = true;
            this.rdOrdinario.Text = "Ordinario";
            this.rdOrdinario.UseVisualStyleBackColor = true;
            // 
            // rdUrgente
            // 
            this.rdUrgente.AutoSize = true;
            this.rdUrgente.Location = new System.Drawing.Point(143, 198);
            this.rdUrgente.Name = "rdUrgente";
            this.rdUrgente.Size = new System.Drawing.Size(63, 17);
            this.rdUrgente.TabIndex = 8;
            this.rdUrgente.Text = "Urgente";
            this.rdUrgente.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 316);
            this.Controls.Add(this.rdUrgente);
            this.Controls.Add(this.rdOrdinario);
            this.Controls.Add(this.txtTelegrama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Practica git";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1; 
        private System.Windows.Forms.TextBox txtPrecio; 
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelegrama;
        private System.Windows.Forms.RadioButton rdOrdinario;
        private System.Windows.Forms.RadioButton rdUrgente;
    }
}

