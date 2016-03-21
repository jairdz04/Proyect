using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyect.Modelo
{
    public class Estudiante : Persona
    {
        #region "atributos"
        private string curso;
        private string deficiencia;
        private string recomendaciones;
        #endregion

        #region "propiedades"

        public string Curso {
            get { return curso; }
            set { curso = value; }
        }

        public string Deficiencia
        {
            get { return deficiencia; }
            set { deficiencia = value; }
        }

        public string Recomendaciones
        {
            get { return recomendaciones; }
            set { recomendaciones = value; }
        }


        #endregion


        #region "Constructores"

        public Estudiante(): base(){
            this.curso = "";
            this.deficiencia = "";
            this.recomendaciones = "";
    
    }

        public Estudiante(string id, string TipoID, string identificacion, string Nombres, string Apellidos, string sede, string Sexo, string F_Nacimiento, string curso, string deficiencia, string recomendaciones) 
            : base(id, TipoID, identificacion,Nombres,Apellidos,sede,Sexo,F_Nacimiento) {
                this.curso = curso;
            this.deficiencia= deficiencia;
            this.recomendaciones = recomendaciones;
         }


        #endregion

        #region "Metodos SobreEscritos"

        public override string ToString()
        {
            return base.ToString() + "\nCurso : " + this.curso +
                "\nDeficiencia :" + this.deficiencia +
        "\nRecomendaciones : " + this.recomendaciones;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Estudiante e = (Estudiante)obj;
            bool result = false;

            if (base.Equals(e)&& (this.curso == e.curso)&& (this.deficiencia== e.deficiencia)&& (this.recomendaciones== e.recomendaciones))
                result = true;
            return result; 
        }
        #endregion

    }
}