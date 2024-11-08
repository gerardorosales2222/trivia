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
    public partial class frmResponder : Form
    {
        private int indicePregunta = 0;
        Pregunta preg;
        private List<Pregunta> preguntas;
        private List<int> respuestas;
        int cantCorrectas = 0;
        private bool primerClic = true;
        private bool opcion1Seleccionada = false;
        private bool opcion2Seleccionada = false;
        private bool opcion3Seleccionada = false;

        public frmResponder(List<Pregunta> preguntasGuardadas)
        {
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\ResponderFondo.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.MaximizeBox = false;
            preguntas = preguntasGuardadas;
        }

        public void responderPreguntas(List<int> respuestas)
        {
            if (indicePregunta < preguntas.Count)
            {
                if (preg != null)
                {
                    if (preg.EsCorrecta(respuestas))
                    {                        
                        cantCorrectas++;
                    }
                }

                preg = preguntas[indicePregunta];
                textEnunciado.Text = preg.Enunciado;
                botonOp1.Text = preg.Opcion1;
                botonOp2.Text = preg.Opcion2;
                botonOp3.Text = preg.Opcion3;
                indicePregunta++;
            }
            else
            {
                if (preg != null)
                {
                    if (preg.EsCorrecta(respuestas))
                    {                        
                        cantCorrectas++;
                    }
                }
                this.Close();
                frmResultados info = new frmResultados(cantCorrectas, preguntas);
                info.Show();
            }

        }

        private void frmResponder_Load(object sender, EventArgs e)
        {
            boton.Text = "Verificar";
            mensaje.Visible = false;
            respuestas = new List<int>();
            responderPreguntas(respuestas);
        }

        private void boton_Click(object sender, EventArgs e)
        {      
            if (primerClic)
            {
                mensaje.Visible = true;
                this.Text = "Verificando...";
                boton.Text = "Siguiente";
                textEnunciado.Text = preg.Enunciado;
                botonOp1.Visible = false;
                botonOp2.Visible = false;
                botonOp3.Visible = false;
                string resultado;
                resultado = String.Join(", ", preg.OpcionesCorrectas);
                if (preg.EsCorrecta(respuestas))
                {                    
                    mensaje.Text = " CORRECTO \n La respuesta correcta era la: " + resultado;
                }
                else {
                    mensaje.Text = " INCORRECTO \n La respuesta correcta era la: " + resultado;                
                }                
                primerClic = false;
            }
            else
            {
                mensaje.Visible = false;
                botonOp1.Visible = true;
                botonOp2.Visible = true;
                botonOp3.Visible = true;
                botonOp1.BackgroundImage = Properties.Resources.Botón_Opción_NO_Chequeado;
                botonOp2.BackgroundImage = Properties.Resources.Botón_Opción_NO_Chequeado;
                botonOp3.BackgroundImage = Properties.Resources.Botón_Opción_NO_Chequeado;
                responderPreguntas(respuestas);
                respuestas = new List<int>();
                primerClic = true;
            }

        }

        private void botonOp1_Click(object sender, EventArgs e)
        {
            opcion1Seleccionada = !opcion1Seleccionada;

            if (opcion1Seleccionada)
            {
                botonOp1.BackgroundImage = Properties.Resources.Botón_Opción_Chequeado;
                respuestas.Add(1);
            }
            else
            {
                botonOp1.BackgroundImage = Properties.Resources.Botón_Opción_NO_Chequeado;
                while (respuestas.Contains(1))
                {
                    respuestas.Remove(1);
                }
            }
        }

        private void botonOp2_Click(object sender, EventArgs e)
        {
            opcion2Seleccionada = !opcion2Seleccionada;

            if (opcion2Seleccionada)
            {
                botonOp2.BackgroundImage = Properties.Resources.Botón_Opción_Chequeado;
                respuestas.Add(2);
            }
            else
            {
                botonOp2.BackgroundImage = Properties.Resources.Botón_Opción_NO_Chequeado;
                while (respuestas.Contains(2))
                {
                    respuestas.Remove(2);
                }
            }
        }

        private void botonOp3_Click(object sender, EventArgs e)
        {
            opcion3Seleccionada = !opcion3Seleccionada;

            if (opcion3Seleccionada)
            {
                botonOp3.BackgroundImage = Properties.Resources.Botón_Opción_Chequeado;
                respuestas.Add(3);
            }
            else
            {
                botonOp3.BackgroundImage = Properties.Resources.Botón_Opción_NO_Chequeado;
                while (respuestas.Contains(3))
                {
                    respuestas.Remove(3);
                }
            }
        }

    }
}