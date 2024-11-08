namespace Trivia
{
    partial class frmPreguntas
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPreguntas));
            this.textPregunta = new System.Windows.Forms.TextBox();
            this.labelPregunta = new System.Windows.Forms.Label();
            this.labelOp1 = new System.Windows.Forms.Label();
            this.textOp1 = new System.Windows.Forms.TextBox();
            this.labelOp2 = new System.Windows.Forms.Label();
            this.textOp2 = new System.Windows.Forms.TextBox();
            this.labelOp3 = new System.Windows.Forms.Label();
            this.textOp3 = new System.Windows.Forms.TextBox();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.checkBoxOp1 = new System.Windows.Forms.CheckBox();
            this.checkBoxOp2 = new System.Windows.Forms.CheckBox();
            this.checkBoxOp3 = new System.Windows.Forms.CheckBox();
            this.botonFinalizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textPregunta
            // 
            this.textPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPregunta.Location = new System.Drawing.Point(27, 77);
            this.textPregunta.Margin = new System.Windows.Forms.Padding(2);
            this.textPregunta.Name = "textPregunta";
            this.textPregunta.Size = new System.Drawing.Size(614, 29);
            this.textPregunta.TabIndex = 0;
            // 
            // labelPregunta
            // 
            this.labelPregunta.AutoSize = true;
            this.labelPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPregunta.ForeColor = System.Drawing.Color.White;
            this.labelPregunta.Location = new System.Drawing.Point(26, 51);
            this.labelPregunta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPregunta.Name = "labelPregunta";
            this.labelPregunta.Size = new System.Drawing.Size(86, 24);
            this.labelPregunta.TabIndex = 1;
            this.labelPregunta.Text = "Pregunta";
            // 
            // labelOp1
            // 
            this.labelOp1.AutoSize = true;
            this.labelOp1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelOp1.Location = new System.Drawing.Point(27, 170);
            this.labelOp1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOp1.Name = "labelOp1";
            this.labelOp1.Size = new System.Drawing.Size(50, 13);
            this.labelOp1.TabIndex = 3;
            this.labelOp1.Text = "Opción 1";
            // 
            // textOp1
            // 
            this.textOp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOp1.Location = new System.Drawing.Point(27, 185);
            this.textOp1.Margin = new System.Windows.Forms.Padding(2);
            this.textOp1.Name = "textOp1";
            this.textOp1.Size = new System.Drawing.Size(501, 26);
            this.textOp1.TabIndex = 2;
            // 
            // labelOp2
            // 
            this.labelOp2.AutoSize = true;
            this.labelOp2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelOp2.Location = new System.Drawing.Point(27, 219);
            this.labelOp2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOp2.Name = "labelOp2";
            this.labelOp2.Size = new System.Drawing.Size(50, 13);
            this.labelOp2.TabIndex = 5;
            this.labelOp2.Text = "Opción 2";
            // 
            // textOp2
            // 
            this.textOp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOp2.Location = new System.Drawing.Point(27, 234);
            this.textOp2.Margin = new System.Windows.Forms.Padding(2);
            this.textOp2.Name = "textOp2";
            this.textOp2.Size = new System.Drawing.Size(501, 26);
            this.textOp2.TabIndex = 4;
            // 
            // labelOp3
            // 
            this.labelOp3.AutoSize = true;
            this.labelOp3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelOp3.Location = new System.Drawing.Point(27, 271);
            this.labelOp3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOp3.Name = "labelOp3";
            this.labelOp3.Size = new System.Drawing.Size(50, 13);
            this.labelOp3.TabIndex = 7;
            this.labelOp3.Text = "Opción 3";
            // 
            // textOp3
            // 
            this.textOp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOp3.Location = new System.Drawing.Point(27, 289);
            this.textOp3.Margin = new System.Windows.Forms.Padding(2);
            this.textOp3.Name = "textOp3";
            this.textOp3.Size = new System.Drawing.Size(501, 26);
            this.textOp3.TabIndex = 6;
            // 
            // botonGuardar
            // 
            this.botonGuardar.BackColor = System.Drawing.Color.Green;
            this.botonGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.botonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonGuardar.Location = new System.Drawing.Point(524, 361);
            this.botonGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(117, 57);
            this.botonGuardar.TabIndex = 8;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = false;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // checkBoxOp1
            // 
            this.checkBoxOp1.AutoSize = true;
            this.checkBoxOp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOp1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxOp1.Location = new System.Drawing.Point(552, 185);
            this.checkBoxOp1.Name = "checkBoxOp1";
            this.checkBoxOp1.Size = new System.Drawing.Size(89, 24);
            this.checkBoxOp1.TabIndex = 9;
            this.checkBoxOp1.Text = "Correcto";
            this.checkBoxOp1.UseVisualStyleBackColor = true;
            // 
            // checkBoxOp2
            // 
            this.checkBoxOp2.AutoSize = true;
            this.checkBoxOp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOp2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxOp2.Location = new System.Drawing.Point(552, 236);
            this.checkBoxOp2.Name = "checkBoxOp2";
            this.checkBoxOp2.Size = new System.Drawing.Size(89, 24);
            this.checkBoxOp2.TabIndex = 10;
            this.checkBoxOp2.Text = "Correcto";
            this.checkBoxOp2.UseVisualStyleBackColor = true;
            // 
            // checkBoxOp3
            // 
            this.checkBoxOp3.AutoSize = true;
            this.checkBoxOp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOp3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxOp3.Location = new System.Drawing.Point(552, 289);
            this.checkBoxOp3.Name = "checkBoxOp3";
            this.checkBoxOp3.Size = new System.Drawing.Size(89, 24);
            this.checkBoxOp3.TabIndex = 11;
            this.checkBoxOp3.Text = "Correcto";
            this.checkBoxOp3.UseVisualStyleBackColor = true;
            // 
            // botonFinalizar
            // 
            this.botonFinalizar.BackColor = System.Drawing.Color.DodgerBlue;
            this.botonFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonFinalizar.FlatAppearance.BorderSize = 0;
            this.botonFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonFinalizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonFinalizar.Location = new System.Drawing.Point(378, 361);
            this.botonFinalizar.Margin = new System.Windows.Forms.Padding(2);
            this.botonFinalizar.Name = "botonFinalizar";
            this.botonFinalizar.Size = new System.Drawing.Size(117, 57);
            this.botonFinalizar.TabIndex = 12;
            this.botonFinalizar.Text = "Finalizar";
            this.botonFinalizar.UseVisualStyleBackColor = false;
            this.botonFinalizar.Click += new System.EventHandler(this.botonFinalizar_Click);
            // 
            // frmPreguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(673, 446);
            this.Controls.Add(this.botonFinalizar);
            this.Controls.Add(this.checkBoxOp3);
            this.Controls.Add(this.checkBoxOp2);
            this.Controls.Add(this.checkBoxOp1);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.labelOp3);
            this.Controls.Add(this.textOp3);
            this.Controls.Add(this.labelOp2);
            this.Controls.Add(this.textOp2);
            this.Controls.Add(this.labelOp1);
            this.Controls.Add(this.textOp1);
            this.Controls.Add(this.labelPregunta);
            this.Controls.Add(this.textPregunta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPreguntas";
            this.Text = "Preguntas";
            this.Load += new System.EventHandler(this.frmPreguntas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textPregunta;
        private System.Windows.Forms.Label labelPregunta;
        private System.Windows.Forms.Label labelOp1;
        private System.Windows.Forms.TextBox textOp1;
        private System.Windows.Forms.Label labelOp2;
        private System.Windows.Forms.TextBox textOp2;
        private System.Windows.Forms.Label labelOp3;
        private System.Windows.Forms.TextBox textOp3;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.CheckBox checkBoxOp1;
        private System.Windows.Forms.CheckBox checkBoxOp2;
        private System.Windows.Forms.CheckBox checkBoxOp3;
        private System.Windows.Forms.Button botonFinalizar;
    }
}

