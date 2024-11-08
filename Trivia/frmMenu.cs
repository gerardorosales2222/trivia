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
    public partial class frmMenu : Form
    {
        private List<Pregunta> preguntas;

        public frmMenu()
        {
            InitializeComponent();
            this.preguntas = new List<Pregunta>();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\T_Fondo.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.MaximizeBox = false;
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cargarPreguntasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPreguntas Preguntas = new frmPreguntas(preguntas);
            Preguntas.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmResponder Jugar = new frmResponder(preguntas);
            Jugar.Show();
        }

        private void jugarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmResponder Jugar = new frmResponder(preguntas);
            Jugar.Show();
        }
    }
}
