using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Examen_Practico_RA2
{
    internal class Estudiante
    {
        private string text1;
        private string text2;
        private string text3;
        private string text4;
        private string text5;

        public Estudiante(string text1, string text2, string text3, string text4, string text5)
        {
            this.text1 = text1;
            this.text2 = text2;
            this.text3 = text3;
            this.text4 = text4;
            this.text5 = text5;
        }

        public Estudiante(string text1, string text2, string text3, string text4, string text5, System.Windows.Forms.RadioButton radioButton1, System.Windows.Forms.RadioButton radioButton2)
        {
            this.text1 = text1;
            this.text2 = text2;
            this.text3 = text3;
            this.text4 = text4;
            this.text5 = text5;
        }

        public object Matricula { get; internal set; }
        public object Nombre { get; internal set; }
        public object Curso { get; internal set; }
        public object Seccion { get; internal set; }
        public object AreaTecnica { get; internal set; }
    }
}
