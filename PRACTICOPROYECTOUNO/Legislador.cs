using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICOPROYECTOUNO
{
    internal class Legislador
    {
        private string partidoPolitico;
        private string departamentoRepresenta;
        private int numDespacho;
        private string nombre;
        private string apellido;
        private int edad;
        private bool casado;
        private string camara;
        private string propuestaLegislativa = "El legislador no presente propuesta";
        private string opcionLegislador;
        

       

        public Legislador()
        {

        }

        public Legislador(string partidoPolitico, string departamentoRepresenta, int numDespacho,string nombre, string apellido, int edad, bool casado, string camara, string opcionLegislador)
        {
            this.partidoPolitico = partidoPolitico;
            this.departamentoRepresenta = departamentoRepresenta;
            this.numDespacho = numDespacho;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.casado = casado;
            this.camara = camara;
            this.opcionLegislador = opcionLegislador;           
            

        }


        public void setcamara(string camara) => this.camara = camara;
        public string getcamara() => camara;
        public void setdepartamentoRepresenta(string departamentoRepresenta) => this.departamentoRepresenta = departamentoRepresenta;
        public string getdepartamentoRepresenta() => departamentoRepresenta;
        public void setpartidoPolitico(string partidoPolitico) => this.partidoPolitico = partidoPolitico;
        public string getpartidoPolitico() => partidoPolitico;
        public void setnumDespacho(int numDespacho) => this.numDespacho = numDespacho;
        public int getnumDespacho() => numDespacho;
        public void setapellido(string apellido) => this.apellido = apellido;
        public string getapellido() => apellido;
        public int getedad() => edad;
        public void setedad(int edad) => this.edad = edad;
        public bool getcasado() => casado;
        public void setcasado(bool casado) => this.casado = casado;
        public void setNombre(string nombre)=> this.nombre = nombre;
        public string getnombre() => nombre;       
        public void setopcionLegislador(string opcionLegislador) => this.opcionLegislador = opcionLegislador;
        public string getopcionLegislador() => opcionLegislador;

        public virtual string presentarPropuestaLegislativa(string propuestaLegislativa)
        {
            propuestaLegislativa = "No tiene propuesta";
            return propuestaLegislativa;
        }        
        public virtual string votoLegislador(string votacion)
        {
            votacion = "No tiene votos";
            return votacion;
        }  
        
        public virtual string participarDebate(string debateLegislador)
        {

            debateLegislador = "El legislador no debate";
            return debateLegislador;
        }
        public static bool CadenaSinEspacio(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                return false;
            }
            if (nombre.Contains(" "))
            {
                return false;
            }
            return true;
        }
       

    }
}


