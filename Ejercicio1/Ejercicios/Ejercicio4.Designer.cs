namespace Ejercicio1.Ejercicios
{
    partial class Ejercicio4
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
            this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btnBuscarIDLineal = new System.Windows.Forms.Button();
            this.btnBuscarNombreBinaria = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.AllowUserToOrderColumns = true;
            this.dgvEstudiantes.AllowUserToResizeColumns = false;
            this.dgvEstudiantes.AllowUserToResizeRows = false;
            this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiantes.Location = new System.Drawing.Point(115, 211);
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            this.dgvEstudiantes.RowHeadersWidth = 51;
            this.dgvEstudiantes.RowTemplate.Height = 24;
            this.dgvEstudiantes.Size = new System.Drawing.Size(342, 331);
            this.dgvEstudiantes.TabIndex = 0;
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(100, 37);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(189, 28);
            this.tbID.TabIndex = 1;
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(100, 117);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(189, 28);
            this.tbNombre.TabIndex = 2;
            // 
            // btnBuscarIDLineal
            // 
            this.btnBuscarIDLineal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarIDLineal.Location = new System.Drawing.Point(304, 20);
            this.btnBuscarIDLineal.Name = "btnBuscarIDLineal";
            this.btnBuscarIDLineal.Size = new System.Drawing.Size(166, 62);
            this.btnBuscarIDLineal.TabIndex = 3;
            this.btnBuscarIDLineal.Text = "Buscar ID (lineal)";
            this.btnBuscarIDLineal.UseVisualStyleBackColor = true;
            this.btnBuscarIDLineal.Click += new System.EventHandler(this.btnBuscarIDLineal_Click);
            // 
            // btnBuscarNombreBinaria
            // 
            this.btnBuscarNombreBinaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarNombreBinaria.Location = new System.Drawing.Point(304, 101);
            this.btnBuscarNombreBinaria.Name = "btnBuscarNombreBinaria";
            this.btnBuscarNombreBinaria.Size = new System.Drawing.Size(166, 61);
            this.btnBuscarNombreBinaria.TabIndex = 4;
            this.btnBuscarNombreBinaria.Text = "Buscar nombre (binaria)";
            this.btnBuscarNombreBinaria.UseVisualStyleBackColor = true;
            this.btnBuscarNombreBinaria.Click += new System.EventHandler(this.btnBuscarNombreBinaria_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(12, 177);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(573, 23);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "lblResultado";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResultado.Visible = false;
            // 
            // Ejercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(597, 569);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnBuscarNombreBinaria);
            this.Controls.Add(this.btnBuscarIDLineal);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.dgvEstudiantes);
            this.Name = "Ejercicio4";
            this.Text = "Ejercicio4";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEstudiantes;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button btnBuscarIDLineal;
        private System.Windows.Forms.Button btnBuscarNombreBinaria;
        private System.Windows.Forms.Label lblResultado;
    }
}