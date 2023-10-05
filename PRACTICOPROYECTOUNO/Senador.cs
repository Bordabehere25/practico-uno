using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICOPROYECTOUNO
{
    internal class Senador : Legislador
    {

        private int numAsientoCamaraAlta;
        
        public Senador()
        {

        }

        public Senador(string partidoPolitico, string departamentoRepresenta, int numDespacho,string nombre, string apellido, int edad, bool casado, string camara, string opcionLegislador, int numAsientoCamaraAlta) : base(partidoPolitico, departamentoRepresenta, numDespacho,nombre, apellido, edad, casado, camara, opcionLegislador)
        {
            this.numAsientoCamaraAlta = numAsientoCamaraAlta;
        }
        public void setnumAsientoCamaraAlta(int numAsientoCamaraAlta) => this.numAsientoCamaraAlta = numAsientoCamaraAlta;
        public int getnumAsientoCamaraAlta() => numAsientoCamaraAlta;


        public override string presentarPropuestaLegislativa(string propuestaLegislativa)
        {
            return propuestaLegislativa;
        }

        public override string participarDebate(string debateLegislador)
        {
            debateLegislador = "El Senador ";
            return debateLegislador;
        }


    }




}
