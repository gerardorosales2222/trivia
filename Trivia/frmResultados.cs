using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Trivia
{
    public partial class frmResultados : Form
    {
        private int cantidadDeCorrectas;
        private Label textoCorrectas;
        private List<Pregunta> misPreguntas;
    
        public frmResultados(int cantCorrectas, List<Pregunta> preguntas)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            misPreguntas = preguntas;
            cantidadDeCorrectas = cantCorrectas;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResultados));
            this.textoCorrectas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textoCorrectas
            // 
            this.textoCorrectas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoCorrectas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textoCorrectas.Location = new System.Drawing.Point(5, 104);
            this.textoCorrectas.Name = "textoCorrectas";
            this.textoCorrectas.Size = new System.Drawing.Size(678, 199);
            this.textoCorrectas.TabIndex = 0;
            this.textoCorrectas.Text = "Puntos Obtenidos ";
            this.textoCorrectas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmResultados
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.textoCorrectas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultados";
            this.Load += new System.EventHandler(this.frmResultados_Load);
            this.ResumeLayout(false);

        }

        private void frmResultados_Load(object sender, EventArgs e)
        {
            if (misPreguntas.Count > 0)
            {
                int cantRespondidas = misPreguntas.Count();

                foreach (Pregunta pregunta in misPreguntas)
                {
                    
                }

                textoCorrectas.Text += cantidadDeCorrectas.ToString() + "/" + cantRespondidas;
            }
            else {
                textoCorrectas.Text = "Aún no se cargaron preguntas.";
            }
        }
    }
}
