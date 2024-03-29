
namespace TP_GRUPO_19
{
    partial class FormEjercicio1
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
            this.lbNombres = new System.Windows.Forms.ListBox();
            this.textBoxNombres = new System.Windows.Forms.TextBox();
            this.labelEj1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNombres
            // 
            this.lbNombres.FormattingEnabled = true;
            this.lbNombres.Location = new System.Drawing.Point(174, 110);
            this.lbNombres.Name = "lbNombres";
            this.lbNombres.Size = new System.Drawing.Size(152, 212);
            this.lbNombres.TabIndex = 0;
            // 
            // textBoxNombres
            // 
            this.textBoxNombres.Location = new System.Drawing.Point(239, 41);
            this.textBoxNombres.Name = "textBoxNombres";
            this.textBoxNombres.Size = new System.Drawing.Size(335, 20);
            this.textBoxNombres.TabIndex = 1;
            // 
            // labelEj1
            // 
            this.labelEj1.AutoSize = true;
            this.labelEj1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEj1.Location = new System.Drawing.Point(92, 42);
            this.labelEj1.Name = "labelEj1";
            this.labelEj1.Size = new System.Drawing.Size(140, 16);
            this.labelEj1.TabIndex = 2;
            this.labelEj1.Text = "Ingrese un nombre:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(593, 35);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(82, 31);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FormEjercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.labelEj1);
            this.Controls.Add(this.textBoxNombres);
            this.Controls.Add(this.lbNombres);
            this.Name = "FormEjercicio1";
            this.Text = "Ejercicio 1";
            this.Load += new System.EventHandler(this.FormEjercicio1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbNombres;
        private System.Windows.Forms.TextBox textBoxNombres;
        private System.Windows.Forms.Label labelEj1;
        private System.Windows.Forms.Button btnAgregar;
    }
}