using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICOPROYECTOUNO
{
    internal class Parlamento
    {


        private List<Legislador> listaLegisladores;

        public Parlamento()
        {
            listaLegisladores = new List<Legislador>();
        }


        public void ListarCamaras(List<Legislador> listaLegisladores)
        {

           
            foreach (Legislador legislador in listaLegisladores)
            {
                Console.WriteLine($"\nPartido politico\t\t\t\t: {legislador.getpartidoPolitico()}");
                Console.WriteLine($"El legislador pertenece a la\t\t\t: {legislador.getcamara()}");
                Console.WriteLine($"El departamento al que representa es\t\t: {legislador.getdepartamentoRepresenta()}");
                Console.WriteLine($"El numero de despacho es\t\t\t: {legislador.getnumDespacho()}");
               //Console.WriteLine($"El numero de asiento de la camara alta es: {((Senador)legislador).getnumAsientoCamaraAlta()}");
                if (legislador.getcamara() == "Camara de Senadores")
                {
                    Console.WriteLine($"El numero de asiento de la camara alta es\t: {((Senador)legislador).getnumAsientoCamaraAlta()}");
                }
                else if (legislador.getcamara() == "Camara de Diputados")

                {
                    Console.WriteLine($"El numero de asiento de la camara baja es\t: {((Diputado)legislador).getnumAsientoCamaraBaja()}");
                }
                Console.WriteLine($"El nombre del legislador es \t\t\t: {legislador.getnombre()}");
                Console.WriteLine($"El Apellido del legislador es\t\t\t: {legislador.getapellido()}");
                Console.WriteLine($"La edad del legislador es\t\t\t: {legislador.getedad()}");
                Console.WriteLine($"El estado civil del legislador es\t\t: {legislador.getcasado()}");
                Console.WriteLine(legislador.presentarPropuestaLegislativa("No hay propuesta "));
                Console.WriteLine("Presione una enter para continuar ..");
                Console.ReadLine();
            }
        }

        public List<Legislador> getListaLegislador()
        {
            return listaLegisladores;
        }

        public void setListaLegislador(List<Legislador> listaLegisladores)
        {
            this.listaLegisladores = listaLegisladores;
        }

        public void registrarSenador(string partidoPolitico, string departamentoRepresenta, int numDespacho,string nombre, string apellido, int edad, bool casado, string camara, int numAsientoCamaraAlta)
        {
            Senador senador = new Senador();
            senador.setpartidoPolitico(partidoPolitico);
            senador.setcamara(camara);
            senador.setcasado(casado);
            senador.setedad(edad);
            senador.setnumDespacho(numDespacho);
            senador.setNombre(nombre);
            senador.setapellido(apellido);
            senador.setdepartamentoRepresenta(departamentoRepresenta);
            senador.setnumAsientoCamaraAlta(numAsientoCamaraAlta);
            
            listaLegisladores.Add(senador);
        }
        public void registrarDiputado(string partidoPolitico, string departamentoRepresenta, int numDespacho,string nombre, string apellido, int edad, bool casado, string camara, int numAsientoCamaraBaja)
        {
            Diputado diputado = new Diputado();
            diputado.setpartidoPolitico(partidoPolitico);
            diputado.setcamara(camara);
            diputado.setcasado(casado);
            diputado.setedad(edad);
            diputado.setnumDespacho(numDespacho);
            diputado.setNombre(nombre);
            diputado.setapellido(apellido);
            diputado.setdepartamentoRepresenta(departamentoRepresenta);
            diputado.setnumAsientoCamaraBaja(numAsientoCamaraBaja);            
            listaLegisladores.Add(diputado);

        }
        public void mostrarTotal(List<Legislador> listaLegisladores)
        {
            Console.Clear();

            Console.WriteLine($"\n\n\tLa cantidad actual de senadores es \t: {listaLegisladores.OfType<Senador>().Count()}");
            Console.WriteLine($"\n\tLa cantidad actual de diputados es \t: {listaLegisladores.OfType<Diputado>().Count()}");

        }

        public bool NumeroDespachoExistente(int numDespacho)
        {
            foreach (var legislador in listaLegisladores)
            {
                if (legislador.getnumDespacho() == numDespacho)
                {
                    return true; // El número de despacho ya existe
                }
            }
            return false; // El número de despacho no existe
        }
    }
}
