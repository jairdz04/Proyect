using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyect.Modelo
{
    public class Admin : Persona
    {
        #region "atributos"

        private string Cargo;

        #endregion

        #region "propiedades"

        public string cargo {
            get { return Cargo; }
            set { Cargo = value; }
        }
        #endregion

        #region "Constructores"

        public Admin() : base() {
            this.Cargo = "";
        }

        public Admin(string id, string TipoID, string identificacion, string Nombres, string Apellidos, string sede, string Sexo, string F_Nacimiento, string Cargo) 
            : base(id, TipoID, identificacion,Nombres,Apellidos,sede,Sexo,F_Nacimiento) {
                this.Cargo = Cargo;
            
         }

        #endregion

        #region "Metodos SobreEscritos"

        public override string ToString()
        {
            return base.ToString() + "\nCargo : " + this.Cargo; 
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Admin a = (Admin)obj;
            bool result = false;

            if (base.Equals(a) && (this.Cargo == a.Cargo))
                result = true;
            return result;
        }
        #endregion
    }
}