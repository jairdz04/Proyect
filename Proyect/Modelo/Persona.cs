using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyect.Modelo
{
    public class Persona
    {
#region "Atributos"
        public string id;
        public string TipoID;
        public string identificacion;
        public string Nombres;
        public string Apellidos;
        public string sede;
        public string Sexo;
        public string F_Nacimiento;

#endregion

        #region "propiedades"
        public string ID {
            get { return id; }
            set { id = value; }
        }

        public string tipoId {
            get { return TipoID; }
            set { TipoID = value; }
        
        }

        public string identi {
            get { return identificacion; }
            set { identificacion = value; }
                          }

        public string nombres {
            get { return Nombres; }
            set { Nombres = value; }
                               }

        public string apellidos {
            get { return Apellidos; }
            set { Apellidos = value; }
                                }

        public string Sede {
            get { return sede; }
            set { sede = value; }
        }

        public string sexo {
            get { return Apellidos; }
            set { Sexo = value; }
                           }

        public string f_naci {
            get { return F_Nacimiento; }
            set { F_Nacimiento = value; }
                            }

        #endregion

        #region "constructores"

        public Persona() {
            this.id = "";
            this.TipoID = "";
            this.identificacion = "";
            this.Nombres = "";
            this.Apellidos = "";
            this.sede = "";
            this.Sexo = "";
            this.F_Nacimiento = "";
        }

        public Persona(string id, string TipoID, string identificacion, string Nombres, string Apellidos,string sede, string Sexo, string F_Nacimiento) {

            this.id = id;
            this.TipoID = TipoID;
            this.identificacion = identificacion;
            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
            this.sede = sede;
            this.Sexo = Sexo;
            this.F_Nacimiento = F_Nacimiento;
        
        }

        #endregion

        #region "metodos SobreEscritos"

        public override string ToString()
        {
            return "Id : " + this.id +
                "\nTipo Identificacion : " + this.TipoID +
                "\nIdentificacion :" + this.identificacion +
                "\nNombres : " + this.Nombres +
                "\nApellidos :" + this.Apellidos +
                "\nSede : " + this.sede +
                "\nSexo : " + this.Sexo +
                "\nFecha de Nacimiento :" + this.F_Nacimiento ;

        }

        public override int GetHashCode() {
            return this.ToString().GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Persona o = (Persona)obj;
            bool result = false;

            if ((this.id == o.id) &&
                (this.TipoID == o.TipoID) &&
                (this.identificacion == o.identificacion) &&
                (this.Nombres == o.Nombres) &&
                (this.Apellidos == o.Apellidos) &&
                (this.sede == o.sede)&&
                (this.Sexo == o.Sexo) &&
                (this.F_Nacimiento == o.F_Nacimiento))

                result = true;

            return result;
        }



        #endregion




    }
}