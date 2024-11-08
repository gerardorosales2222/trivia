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
    public partial class frmPreguntas : Form
    {
        private List<Pregunta> preguntas = new List<Pregunta>();

        public frmPreguntas(List<Pregunta> preguntasGuardadas)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            preguntas = preguntasGuardadas;
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            Pregunta preg = new Pregunta();
            preg.Enunciado = textPregunta.Text;
            preg.Opcion1 = textOp1.Text;
            preg.Opcion2 = textOp2.Text;
            preg.Opcion3 = textOp3.Text;
            preg.OpcionesCorrectas = new List<int>();

            if (checkBoxOp1.Checked)
            {
                preg.OpcionesCorrectas.Add(1);
            }
            if (checkBoxOp2.Checked)
            {
                preg.OpcionesCorrectas.Add(2);
            }
            if (checkBoxOp3.Checked)
            {
                preg.OpcionesCorrectas.Add(3);
            }

            if (preg.OpcionesCorrectas.Count > 0)
            {                
                preguntas.Add(preg);

                checkBoxOp1.Checked = false;
                checkBoxOp2.Checked = false;
                checkBoxOp3.Checked = false;
                textPregunta.Text = string.Empty;
                textOp1.Text = string.Empty;
                textOp2.Text = string.Empty;
                textOp3.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("No seleccionaste ninguna opción.", "Preguntas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void botonFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
            string mensaje = "";
            if (preguntas.Count > 0)
            {
                foreach (var pregunta in preguntas)
                {
                    mensaje += "Pregunta: " + pregunta.Enunciado + "\n";
                    mensaje += "1. " + pregunta.Opcion1 + "\n";
                    mensaje += "2. " + pregunta.Opcion2 + "\n";
                    mensaje += "3. " + pregunta.Opcion3 + "\n\n";
                    mensaje += "Correcta(s): " + string.Join(", ", pregunta.OpcionesCorrectas) + "\n\n";
                }
            }
            else
            {
                mensaje = "No hay preguntas para mostrar.";
            }

            MessageBox.Show(mensaje, "Preguntas Guardadas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmPreguntas_Load(object sender, EventArgs e)
        {

        }
    }
}
