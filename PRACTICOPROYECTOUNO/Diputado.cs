using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICOPROYECTOUNO
{
    internal class Diputado : Legislador
    {
        public Diputado() { }
        private int numAsientoCamaraBaja;
        private string presentarPropuesta;
        //public void setnumAsientoCamaraBaja(int numAsientoCamaraBaja) => this.numAsientoCamaraBaja = numAsientoCamaraBaja;
        // public override int getnumAsientoCamaraBaja() => numAsientoCamaraBaja;


        public Diputado(string partidoPolitico, string departamentoRepresenta, int numDespacho,string nombre, string apellido, int edad, bool casado, string camara, string opcionLegislador, int numAsientoCamaraBaja) : base(partidoPolitico, departamentoRepresenta, numDespacho,nombre, apellido, edad, casado, camara, opcionLegislador)
        {
            this.numAsientoCamaraBaja = numAsientoCamaraBaja;
        }
        public void setnumAsientoCamaraBaja(int numAsientoCamaraBaja) => this.numAsientoCamaraBaja = numAsientoCamaraBaja;
        public int getnumAsientoCamaraBaja() => numAsientoCamaraBaja;

        public override string presentarPropuestaLegislativa(string propuestaLegislativa)
        {
            return propuestaLegislativa;
        }

         public override string participarDebate(string debateLegislador)
        {
            debateLegislador = "El Diputado ";
            return debateLegislador;
        }

    }
}
