using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trivia
{
    public class Pregunta
    {
        public string Enunciado;
        public string Opcion1;
        public string Opcion2;
        public string Opcion3;
        public List<int> OpcionesCorrectas;
        public List<int> Respuestas;

        public Pregunta() { }

        public bool EsCorrecta(List<int> respuestas)
        {
            OpcionesCorrectas.Sort();
            respuestas.Sort();

            this.Respuestas = respuestas;

            if (OpcionesCorrectas.Count != respuestas.Count)
            {
                return false;
            }

            for (int i = 0; i < OpcionesCorrectas.Count; i++)
            {
                if (OpcionesCorrectas[i] != respuestas[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
