using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyect.Modelo
{
    public class Docente : Persona
    {

         #region "atributos"

        private string Area;

        #endregion

        #region "propiedades"

        public string area {
            get { return Area; }
            set { Area = value; }
        }
        #endregion

        #region "Constructores"

        public Docente() : base() {
            this.Area = "";
        }

        public Docente(string id, string TipoID, string identificacion, string Nombres, string Apellidos, string sede, string Sexo, string F_Nacimiento, string Area) 
            : base(id, TipoID, identificacion,Nombres,Apellidos,sede,Sexo,F_Nacimiento) {
                this.Area = Area;
            
         }

        #endregion

        #region "Metodos SobreEscritos"

        public override string ToString()
        {
            return base.ToString() + "\nCargo : " + this.Area; 
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Docente d = (Docente)obj;
            bool result = false;

            if (base.Equals(d) && (this.Area == d.Area))
                result = true;
            return result;
        }
        #endregion
    }
}