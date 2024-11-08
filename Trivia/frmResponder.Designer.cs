namespace Trivia
{
    partial class frmResponder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResponder));
            this.textEnunciado = new System.Windows.Forms.Label();
            this.boton = new System.Windows.Forms.Button();
            this.botonOp1 = new System.Windows.Forms.Button();
            this.botonOp2 = new System.Windows.Forms.Button();
            this.botonOp3 = new System.Windows.Forms.Button();
            this.mensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textEnunciado
            // 
            this.textEnunciado.BackColor = System.Drawing.Color.Transparent;
            this.textEnunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEnunciado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textEnunciado.Location = new System.Drawing.Point(111, 99);
            this.textEnunciado.MaximumSize = new System.Drawing.Size(872, 85);
            this.textEnunciado.Name = "textEnunciado";
            this.textEnunciado.Size = new System.Drawing.Size(872, 85);
            this.textEnunciado.TabIndex = 0;
            this.textEnunciado.Text = "Enunciado";
            this.textEnunciado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boton
            // 
            this.boton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.boton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.boton.Location = new System.Drawing.Point(431, 527);
            this.boton.Name = "boton";
            this.boton.Size = new System.Drawing.Size(232, 64);
            this.boton.TabIndex = 1;
            this.boton.Text = "SIGUIENTE";
            this.boton.UseVisualStyleBackColor = false;
            this.boton.Click += new System.EventHandler(this.boton_Click);
            // 
            // botonOp1
            // 
            this.botonOp1.BackColor = System.Drawing.Color.Transparent;
            this.botonOp1.BackgroundImage = global::Trivia.Properties.Resources.Botón_Opción_NO_Chequeado;
            this.botonOp1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonOp1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonOp1.FlatAppearance.BorderSize = 0;
            this.botonOp1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botonOp1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botonOp1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonOp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonOp1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.botonOp1.Location = new System.Drawing.Point(120, 197);
            this.botonOp1.Name = "botonOp1";
            this.botonOp1.Size = new System.Drawing.Size(872, 84);
            this.botonOp1.TabIndex = 5;
            this.botonOp1.UseVisualStyleBackColor = false;
            this.botonOp1.Click += new System.EventHandler(this.botonOp1_Click);
            // 
            // botonOp2
            // 
            this.botonOp2.BackColor = System.Drawing.Color.Transparent;
            this.botonOp2.BackgroundImage = global::Trivia.Properties.Resources.Botón_Opción_NO_Chequeado;
            this.botonOp2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonOp2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonOp2.FlatAppearance.BorderSize = 0;
            this.botonOp2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botonOp2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botonOp2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonOp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonOp2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.botonOp2.Location = new System.Drawing.Point(120, 300);
            this.botonOp2.Name = "botonOp2";
            this.botonOp2.Size = new System.Drawing.Size(872, 84);
            this.botonOp2.TabIndex = 6;
            this.botonOp2.UseVisualStyleBackColor = false;
            this.botonOp2.Click += new System.EventHandler(this.botonOp2_Click);
            // 
            // botonOp3
            // 
            this.botonOp3.BackColor = System.Drawing.Color.Transparent;
            this.botonOp3.BackgroundImage = global::Trivia.Properties.Resources.Botón_Opción_NO_Chequeado;
            this.botonOp3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonOp3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonOp3.FlatAppearance.BorderSize = 0;
            this.botonOp3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botonOp3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botonOp3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonOp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonOp3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.botonOp3.Location = new System.Drawing.Point(117, 406);
            this.botonOp3.Name = "botonOp3";
            this.botonOp3.Size = new System.Drawing.Size(872, 84);
            this.botonOp3.TabIndex = 7;
            this.botonOp3.UseVisualStyleBackColor = false;
            this.botonOp3.Click += new System.EventHandler(this.botonOp3_Click);
            // 
            // mensaje
            // 
            this.mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensaje.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mensaje.Location = new System.Drawing.Point(12, 313);
            this.mensaje.Name = "mensaje";
            this.mensaje.Size = new System.Drawing.Size(1120, 90);
            this.mensaje.TabIndex = 8;
            this.mensaje.Text = "Resultado";
            this.mensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmResponder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1144, 701);
            this.Controls.Add(this.mensaje);
            this.Controls.Add(this.botonOp3);
            this.Controls.Add(this.botonOp2);
            this.Controls.Add(this.textEnunciado);
            this.Controls.Add(this.boton);
            this.Controls.Add(this.botonOp1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmResponder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Responder";
            this.Load += new System.EventHandler(this.frmResponder_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label textEnunciado;
        private System.Windows.Forms.Button boton;
        private System.Windows.Forms.Button botonOp1;
        private System.Windows.Forms.Button botonOp2;
        private System.Windows.Forms.Button botonOp3;
        private System.Windows.Forms.Label mensaje;
    }
}