namespace Ejercicio1.Ejercicios
{
    partial class Ejercicio5
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
            this.btnAddNumero = new System.Windows.Forms.Button();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEncontrar = new System.Windows.Forms.Button();
            this.rtbListaNumeros = new System.Windows.Forms.RichTextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddNumero
            // 
            this.btnAddNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNumero.Location = new System.Drawing.Point(403, 27);
            this.btnAddNumero.Name = "btnAddNumero";
            this.btnAddNumero.Size = new System.Drawing.Size(104, 41);
            this.btnAddNumero.TabIndex = 1;
            this.btnAddNumero.Text = "Añadir";
            this.btnAddNumero.UseVisualStyleBackColor = true;
            this.btnAddNumero.Click += new System.EventHandler(this.btnAddNumero_Click);
            // 
            // tbNumero
            // 
            this.tbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumero.Location = new System.Drawing.Point(183, 33);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(214, 28);
            this.tbNumero.TabIndex = 2;
            this.tbNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumero_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese un entero:";
            // 
            // btnEncontrar
            // 
            this.btnEncontrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncontrar.Location = new System.Drawing.Point(123, 237);
            this.btnEncontrar.Name = "btnEncontrar";
            this.btnEncontrar.Size = new System.Drawing.Size(274, 41);
            this.btnEncontrar.TabIndex = 4;
            this.btnEncontrar.Text = "Encontrar máximo y mínimo";
            this.btnEncontrar.UseVisualStyleBackColor = true;
            this.btnEncontrar.Click += new System.EventHandler(this.btnEncontrar_Click);
            // 
            // rtbListaNumeros
            // 
            this.rtbListaNumeros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbListaNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbListaNumeros.Location = new System.Drawing.Point(26, 94);
            this.rtbListaNumeros.Name = "rtbListaNumeros";
            this.rtbListaNumeros.ReadOnly = true;
            this.rtbListaNumeros.Size = new System.Drawing.Size(481, 112);
            this.rtbListaNumeros.TabIndex = 5;
            this.rtbListaNumeros.Text = "";
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(37, 307);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(450, 80);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "lblResultado";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblResultado.Visible = false;
            // 
            // Ejercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.rtbListaNumeros);
            this.Controls.Add(this.btnEncontrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.btnAddNumero);
            this.Name = "Ejercicio5";
            this.Text = "Ejercicio5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddNumero;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEncontrar;
        private System.Windows.Forms.RichTextBox rtbListaNumeros;
        private System.Windows.Forms.Label lblResultado;
    }
}