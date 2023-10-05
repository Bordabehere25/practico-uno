using System;

namespace PRACTICOPROYECTOUNO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numAsientoCamaraAlta = 0;
            int numAsientoCamaraBaja = 0;
            int contadoraFavor = 0;
            int contadorEnContra = 0;
            int contadorAbstenerse = 0;
            int numDespachoVotar = 0;
            string input;
            Parlamento parlamento = new Parlamento();
            Console.Clear();
            Console.WriteLine("\n\tSeleccione accion a realizar: \n\n\t\t\t\t\t1) Agregar Legislador. \n\n\t\t\t\t\t2) Listar camaras.\n\n\t\t\t\t\t3) Ver la cantidad de legisladores registrados. \n\n\t\t\t\t\t4) Agregar propuesta Legislativa. \n\n\t\t\t\t\t5) Votar. \n\n\t\t\t\t\t6) Ver votacion. \n\n\t\t\t\t\t7) Debate.\n\n\t\t\t\t\t8) Salir del programa.");
            Console.Write("\n\t\t\t\t\t");
            string eleccion = Console.ReadLine();
            while (eleccion != "1" && eleccion != "2" && eleccion != "3" && eleccion != "4" && eleccion != "5" && eleccion != "6" && eleccion != "7" && eleccion != "8")
            {
                Console.Clear();
                Console.WriteLine("\n\tSeleccione accion a realizar: \n\n\t\t\t\t\t1) Agregar Legislador. \n\n\t\t\t\t\t2) Listar camaras.\n\n\t\t\t\t\t3) Ver la cantidad de legisladores registrados. \n\n\t\t\t\t\t4) Agregar propuesta Legislativa. \n\n\t\t\t\t\t5) Votar. \n\n\t\t\t\t\t6) Ver votacion. \n\n\t\t\t\t\t7) Debate.\n\n\t\t\t\t\t8) Salir del programa.");
                Console.Write("\n\tPor favor seleccione entre 1 y 7. . ");
                eleccion = Console.ReadLine();
            }
            //int contadorLegislador = 0;
            while (eleccion == "1" || eleccion == "2" || eleccion == "3" || eleccion == "4" || eleccion == "5" || eleccion == "6" || eleccion == "7" || eleccion == "8")
            {
                if (eleccion == "1")
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\tQue legislador desea registrar: \n\n\t\t\t\t\t1) Senador. \n\n\t\t\t\t\t2) Diputado. ");
                    Console.Write("\n\t\t\t\t\t");
                    string opcionLegislador = Console.ReadLine();
                    while (opcionLegislador != "1" && opcionLegislador != "2")
                    {
                        Console.Clear();
                        Console.WriteLine("\n\tIngrese opcion correcta ( 1 o 2 ).\n");
                        Console.WriteLine("\n\n\tQue legislador desea registrar: \n\n\t\t\t\t\t1) Senador. \n\n\t\t\t\t\t2) Diputado. ");
                        Console.Write("\n\t\t\t\t\t");
                        opcionLegislador = Console.ReadLine();
                    }
                    string camara = "";
                    switch (opcionLegislador)
                    {
                        case "1":
                            opcionLegislador = "Senador";
                            camara = "Camara de Senadores";
                            input = "";
                            Console.Clear();
                            Console.WriteLine($"\n\n\t\t\t\t\t{camara}\n\n");
                            Console.WriteLine("\n\tIngrese el numero de asiento de la camara alta: ");
                            input = Console.ReadLine();
                            while (true)
                            {
                                if (!string.IsNullOrWhiteSpace(input) && int.TryParse(input, out numAsientoCamaraAlta))
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("\n\tLa entrada no es un número válido o ingresó letras , por favor ingrese un número correcto.");
                                    Console.WriteLine("\n\tIngrese el numero de asiento de la camara alta: ");
                                    input = Console.ReadLine();
                                    Console.Clear();
                                }
                            }
                            break;
                        case "2":
                            opcionLegislador = "Diputado";
                            camara = "Camara de Diputados";
                            Console.Clear();
                            Console.WriteLine($"\n\n\t\t\t\t{camara}\n\n");
                            Console.WriteLine("\n\tIngrese el numero de asiento de la camara baja: ");
                            input = Console.ReadLine();
                            while (true)
                            {
                                if (!string.IsNullOrWhiteSpace(input) && int.TryParse(input, out numAsientoCamaraBaja))
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("\n\tLa entrada no es un número válido o ingresó letras , por favor ingrese un número correcto.");
                                    Console.WriteLine("\n\tIngrese el numero de asiento de la camara baja: ");
                                    input = Console.ReadLine();
                                    Console.Clear();
                                }
                            }
                            break;
                    }
                    Console.Clear();
                    Console.WriteLine($"\n\n\t\t\t\t{camara}\n\n\n");
                    switch (camara)
                    {
                        case "Camara de Senadores":
                            Console.WriteLine($"\tEl numero de asiento es : {numAsientoCamaraAlta}\n");
                            break;
                        case "Camara de Diputados":
                            Console.WriteLine($"\tEl numero de asiento es : {numAsientoCamaraBaja}\n");
                            break;
                    }
                    Console.WriteLine("\tIngrese partido politico al que representa :\n\n\t\t\t\t\t\t\t1)Frente Amplio.\n\n\t\t\t\t\t\t\t2)Partido Nacional.\n\n\t\t\t\t\t\t\t3)Partido Colorado. ");
                    string partidoPolitico = Console.ReadLine();
                    while (partidoPolitico != "1" && partidoPolitico != "2" && partidoPolitico != "3")
                    {
                        Console.Clear();
                        Console.WriteLine($"\n\n\t\t\t\t{camara}\n\n\n");
                        Console.WriteLine("\n\tIngrese un numero entre 1 - 2- 3 ");
                        Console.WriteLine("\n\tIngrese partido politico al que representa :\n\n\t\t\t\t\t\t\t1)Frente Amplio.\n\n\t\t\t\t\t\t\t2)Partido Nacional.\n\n\t\t\t\t\t\t\t3)Partido Colorado. ");
                        partidoPolitico = Console.ReadLine();
                    }
                    Console.Clear();
                    Console.WriteLine($"\n\n\t\t\t\t{camara}\n");
                    switch (camara)
                    {
                        case "Camara de Senadores":
                            Console.WriteLine($"\tEl numero de asiento es \t: \t{numAsientoCamaraAlta}\n");
                            break;
                        case "Camara de Diputados":
                            Console.WriteLine($"\tEl numero de asiento es \t: \t{numAsientoCamaraBaja}\n");
                            break;
                    }
                    switch (partidoPolitico)
                    {
                        case "1":
                            partidoPolitico = "Frente Amplio";
                            break;
                        case "2":
                            partidoPolitico = "Partido Nacional";
                            break;
                        case "3":
                            partidoPolitico = "Partido Colorado";
                            break;
                    }
                    Console.WriteLine($"\tPartido politico \t\t: \t{partidoPolitico} ");
                    Console.WriteLine("\n\tIngrese departamento al que representa :\n\n\t1)Montevideo.\t2)Maldonado.\t3)Colonia.\t4)Rocha.\t5)Lavalleja.\t6)Treinta y tres.\n\t7)Flores.\t8)Durazno.\t9)Florida.\t10)Soriano.\t11)Rio Negro.\t12)Paysandu.\n\t13)Salto.\t14)Tacuarembo.\t15)Rivera.\t16)Artigas.\t17)Cerro Largo.\t18)Mercedes.\n\t19)San Jose.");
                    string departamentoRepresenta = Console.ReadLine();
                    while (departamentoRepresenta != "1" && departamentoRepresenta != "2" && departamentoRepresenta != "3" && departamentoRepresenta != "4" && departamentoRepresenta != "5" && departamentoRepresenta != "6" && departamentoRepresenta != "7" && departamentoRepresenta != "8" && departamentoRepresenta != "9" && departamentoRepresenta != "10" && departamentoRepresenta != "11" && departamentoRepresenta != "12" && departamentoRepresenta != "13" && departamentoRepresenta != "14" && departamentoRepresenta != "15" && departamentoRepresenta != "16" && departamentoRepresenta != "17" && departamentoRepresenta != "18" && departamentoRepresenta != "19")
                    {
                        Console.Clear();
                        Console.WriteLine($"\n\n\t\t\t\t{camara}\n");
                        switch (camara)
                        {
                            case "Camara de Senadores":
                                Console.WriteLine($"\tEl numero de asiento es \t: \t{numAsientoCamaraAlta}\n");
                                break;
                            case "Camara de Diputados":
                                Console.WriteLine($"\tEl numero de asiento es \t: \t{numAsientoCamaraBaja}\n");
                                break;
                        }
                        switch (partidoPolitico)
                        {
                            case "1":
                                partidoPolitico = "Frente Amplio";
                                break;
                            case "2":
                                partidoPolitico = "Partido Nacional";
                                break;
                            case "3":
                                partidoPolitico = "Partido Colorado";
                                break;
                        }
                        Console.WriteLine($"\tPartido politico \t\t: \t{partidoPolitico} ");
                        Console.WriteLine("\n\tPor favor ingrese una opcion correcta ( entre 1 y 19)");
                        Console.WriteLine("\n\tIngrese departamento al que representa :\n\n\t1)Montevideo.\t2)Maldonado.\t3)Colonia.\t4)Rocha.\t5)Lavalleja.\t6)Treinta y tres.\n\t7)Flores.\t8)Durazno.\t9)Florida.\t10)Soriano.\t11)Rio Negro.\t12)Paysandu.\n\t13)Salto.\t14)Tacuarembo.\t15)Rivera.\t16)Artigas.\t17)Cerro Largo.\t18)Mercedes.\n\t19)San Jose.");
                        departamentoRepresenta = Console.ReadLine();

                    }
                    switch (departamentoRepresenta)
                    {
                        case "1":
                            departamentoRepresenta = "Montevideo";
                            break;
                        case "2":
                            departamentoRepresenta = "Maldonado";
                            break;
                        case "3":
                            departamentoRepresenta = "Colonia";
                            break;
                        case "4":
                            departamentoRepresenta = "Rocha";
                            break;
                        case "5":
                            departamentoRepresenta = "Lavalleja";
                            break;
                        case "6":
                            departamentoRepresenta = "Treinta y tres";
                            break;
                        case "7":
                            departamentoRepresenta = "Flores";
                            break;
                        case "8":
                            departamentoRepresenta = "Durazno";
                            break;
                        case "9":
                            departamentoRepresenta = "Florida";
                            break;
                        case "10":
                            departamentoRepresenta = "Soriano";
                            break;
                        case "11":
                            departamentoRepresenta = "Rio Negro";
                            break;
                        case "12":
                            departamentoRepresenta = "Paysandu";
                            break;
                        case "13":
                            departamentoRepresenta = "Salto";
                            break;
                        case "14":
                            departamentoRepresenta = "Tacuarembo";
                            break;
                        case "15":
                            departamentoRepresenta = "Rivera";
                            break;
                        case "16":
                            departamentoRepresenta = "Artigas";
                            break;
                        case "17":
                            departamentoRepresenta = "Cerro Largo";
                            break;
                        case "18":
                            departamentoRepresenta = "Mercedes";
                            break;
                        case "19":
                            departamentoRepresenta = "San Jose";
                            break;
                    }
                    Console.Clear();
                    Console.WriteLine($"\n\n\t\t\t\t{camara}\n\n\n");
                    switch (camara)
                    {
                        case "Camara de Senadores":
                            Console.WriteLine($"\tEl numero de asiento es \t: \t{numAsientoCamaraAlta}\n");
                            break;
                        case "Camara de Diputados":
                            Console.WriteLine($"\tEl numero de asiento es \t: \t{numAsientoCamaraBaja}\n");
                            break;
                    }
                    Console.WriteLine($"\tPartido politico \t\t: \t{partidoPolitico} \n");
                    Console.WriteLine($"\tDepartamento que representa \t:\t {departamentoRepresenta}\n");
                    // numero de despacho
                    Console.WriteLine("\tIngrese numero de despacho      :        (1 a 129)");
                    input = Console.ReadLine();
                    int numDespacho = 0;
                    while (true)
                    {
                        if (!string.IsNullOrWhiteSpace(input) && int.TryParse(input, out numDespacho))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\n\tLa entrada no es un número válido o ingresó letras , por favor ingrese un número correcto.");
                            Console.WriteLine("\n\tIngrese el numero de despacho      :        (1 a 129) ");
                            input = Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    while (parlamento.NumeroDespachoExistente(numDespacho))
                    {
                        Console.WriteLine("\n\tEl numero de despacho ya esta ocupado ");
                        Console.WriteLine("\tIngrese numero de despacho (esta vez bien):        (1 a 129)");
                        numDespacho = int.Parse(Console.ReadLine());
                    }
                    Console.Clear();
                    Console.WriteLine($"\n\n\t\t\t\t{camara}\n\n\n");
                    switch (camara)
                    {
                        case "Camara de Senadores":
                            Console.WriteLine($"\tEl numero de asiento es \t: \t{numAsientoCamaraAlta}\n");
                            break;
                        case "Camara de Diputados":
                            Console.WriteLine($"\tEl numero de asiento es \t: \t{numAsientoCamaraBaja}\n");
                            break;
                    }
                    Console.WriteLine($"\tPartido politico \t\t :\t {partidoPolitico} \n");
                    Console.WriteLine($"\tDepartamento que representa \t:\t {departamentoRepresenta}\n");
                    Console.WriteLine($"\tNumero de despacho \t\t :\t {numDespacho}\n");
                    //nombre
                    Console.Write("\tIngrese Nombre \t\t\t:\t ");
                    string nombre = Console.ReadLine();
                    while (nombre == "")
                    {
                        Console.Write("\tIngrese Nombre ( correctamente ) \t\t\t:\t ");
                        nombre = Console.ReadLine();
                    }
                    nombre = nombre.ToLower();
                    nombre = char.ToUpper(nombre[0]) + nombre.Substring(1);
                    Console.Clear();
                    Console.WriteLine($"\n\n\t\t\t\t{camara}\n\n\n");
                    switch (camara)
                    {
                        case "Camara de Senadores":
                            Console.WriteLine($"\tEl numero de asiento es \t: \t{numAsientoCamaraAlta}\n");
                            break;
                        case "Camara de Diputados":
                            Console.WriteLine($"\tEl numero de asiento es \t: \t{numAsientoCamaraBaja}\n");
                            break;
                    }
                    Console.WriteLine($"\tPartido politico \t\t:\t {partidoPolitico} \n");
                    Console.WriteLine($"\tDepartamento que representa \t:\t {departamentoRepresenta}\n");
                    Console.WriteLine($"\tNumero de despacho \t\t :\t {numDespacho}\n");
                    Console.WriteLine($"\tNombre del legislador \t\t:\t {nombre}\n");
                    // apellido
                    Console.WriteLine("\tIngrese Apellido : ");
                    string apellido = Console.ReadLine();
                    while (apellido == "")
                    {
                        Console.WriteLine("\tIngrese Apellido ( correctamente : ");
                        apellido = Console.ReadLine();
                    }
                    apellido = apellido.ToLower();
                    apellido = char.ToUpper(apellido[0]) + apellido.Substring(1);
                    Console.Clear();
                    Console.WriteLine($"\n\n\t\t\t\t{camara}\n\n\n");
                    switch (camara)
                    {
                        case "Camara de Senadores":
                            Console.WriteLine($"\tEl numero de asiento es \t: \t{numAsientoCamaraAlta}\n");
                            break;
                        case "Camara de Diputados":
                            Console.WriteLine($"\tEl numero de asiento es \t: \t{numAsientoCamaraBaja}\n");
                            break;
                    }
                    Console.WriteLine($"\tPartido politico \t\t:\t {partidoPolitico} \n");
                    Console.WriteLine($"\tDepartamento que representa \t:\t {departamentoRepresenta}\n");
                    Console.WriteLine($"\tNumero de despacho \t\t :\t {numDespacho}\n");
                    Console.WriteLine($"\tNombre del legislador \t\t: \t{nombre}\n");
                    Console.WriteLine($"\tApellido del legislador \t: \t{apellido}\n");
                    //edad
                    int edad;
                    Console.WriteLine("\tIngrese edad del Legislador \t:");
                    input = Console.ReadLine();
                    while (true)
                    {
                        if (!string.IsNullOrWhiteSpace(input) && int.TryParse(input, out edad))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\n\tLa entrada no es un número válido o ingresó letras , por favor ingrese un número correcto.");
                            Console.WriteLine("\n\tIngrese una edad correcta      : ");
                            input = Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    //int edad = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine($"\n\n\t\t\t\t{camara}\n\n\n");
                    switch (camara)
                    {
                        case "Camara de Senadores":
                            Console.WriteLine($"\tEl numero de asiento es \t: \t{numAsientoCamaraAlta}\n");
                            break;
                        case "Camara de Diputados":
                            Console.WriteLine($"\tEl numero de asiento es \t: \t{numAsientoCamaraBaja}\n");
                            break;
                    }
                    Console.WriteLine($"\tPartido politico \t\t:\t {partidoPolitico} \n");
                    Console.WriteLine($"\tDepartamento que representa \t:\t {departamentoRepresenta}\n");
                    Console.WriteLine($"\tNumero de despacho\t\t:\t {numDespacho}\n");
                    Console.WriteLine($"\tNombre del legislador \t\t:\t {nombre}\n");
                    Console.WriteLine($"\tApellido del legislador \t:\t {apellido}\n");
                    Console.WriteLine($"\tLa edad es \t\t\t:\t {edad}\n");                    
                    string castrado = "";
                    Console.WriteLine("\tSeleccione estado civil (true = casado // false = soltero ). ");
                    castrado = Console.ReadLine();
                    while (castrado != "true" && castrado != "false")
                    {
                        Console.WriteLine("\tPor favor escriba bien . . . ");
                        Console.WriteLine("\tSeleccione estado civil (true = casado // false = soltero ). ");
                        castrado = Console.ReadLine();
                    }
                    bool casado = true;
                    if (castrado == "true")
                    {
                        casado = true;
                    }
                    else if (castrado == "false")
                    {
                        casado = false;
                    }
                    if (casado == true)
                    {
                        castrado = "Casado";
                    }
                    else if (casado == false)
                    {
                        castrado = "Soltero";
                    }
                    Console.Clear();
                    Console.WriteLine($"\n\n\t\t\t\t{camara}\n\n\n");
                    switch (camara)
                    {
                        case "Camara de Senadores":
                            Console.WriteLine($"\tEl numero de asiento es \t: \t{numAsientoCamaraAlta}\n");
                            break;
                        case "Camara de Diputados":
                            Console.WriteLine($"\tEl numero de asiento es \t: \t{numAsientoCamaraBaja}\n");
                            break;
                    }
                    Console.WriteLine($"\tPartido politico \t\t: \t{partidoPolitico} \n");
                    Console.WriteLine($"\tDepartamento que representa \t: \t{departamentoRepresenta}\n");
                    Console.WriteLine($"\tNumero de despacho \t\t: \t{numDespacho}\n");
                    Console.WriteLine($"\tNombre del legislador \t\t: \t{nombre}\n");
                    Console.WriteLine($"\tApellido del legislador \t: \t{apellido}\n");
                    Console.WriteLine($"\tLa edad es \t\t\t: \t{edad}\n");
                    Console.WriteLine($"\tEstado civil \t\t\t: \t{castrado}\n");
                    Console.WriteLine("\n\tPresione enter para continuar");
                    Console.Read();
                    if (opcionLegislador == "Senador")
                    {
                        parlamento.registrarSenador(partidoPolitico, departamentoRepresenta, numDespacho, nombre, apellido, edad, casado, camara, numAsientoCamaraAlta);
                        Console.WriteLine($"\tSe registro al senador {nombre + " " + apellido} con exito!");
                    }
                    else
                    {
                        parlamento.registrarDiputado(partidoPolitico, departamentoRepresenta, numDespacho, nombre, apellido, edad, casado, camara, numAsientoCamaraBaja);
                        Console.WriteLine($"Se registro al diputado {nombre + " " + apellido} con exito!");
                        //parlamento.ListarCamaras(parlamento.getListaLegislador());
                    }
                }
                else if (eleccion == "2")
                {
                    Console.Clear();
                    foreach (var legislador in parlamento.getListaLegislador())
                    {
                        Console.WriteLine("\n\tEL numero de despacho  " + legislador.getnumDespacho() + " pertenece a : " + legislador.getnombre() + " " + legislador.getapellido() + " " + " perteneciente a la " + legislador.getcamara() + ".");
                    }
                    Console.Read();
                }
                else if (eleccion == "3")
                {
                    parlamento.mostrarTotal(parlamento.getListaLegislador());
                    Console.Read();
                }
                else if (eleccion == "4")
                {
                    Console.Clear();
                    Console.WriteLine("\tAgregar propuesta legislativa.\n");
                    Console.WriteLine("\tIngrese numero del despacho del legislador ");
                    input = Console.ReadLine();
                    while (true)
                    {
                        if (!string.IsNullOrWhiteSpace(input) && int.TryParse(input, out numDespachoVotar))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\n\tLa entrada no es un número válido o ingresó letras , por favor ingrese un número correcto.");
                            Console.WriteLine("\n\tIngrese el numero de despacho      :        (1 a 129) ");
                            input = Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    foreach (var legislador in parlamento.getListaLegislador())
                    {
                        if (legislador.getnumDespacho() == numDespachoVotar)
                        {
                            Console.WriteLine($"\n\tLegislador {legislador.getapellido()}");
                            Console.Write("\n\tEscriba su propuesta :\t");
                            string propuestaLegislativa = Console.ReadLine();
                            if (legislador.getcamara() == "Camara de Senadores")
                            {
                                Console.WriteLine("\n\tLa propuesta del Senador " + legislador.getapellido() + " es : " + ((Senador)legislador).presentarPropuestaLegislativa(propuestaLegislativa + "."));
                            }
                            else if (legislador.getcamara() == "Camara de Diputados")
                            {
                                Console.WriteLine("\n\tLa propuesta del Diputado " + legislador.getapellido() + " es : " + ((Diputado)legislador).presentarPropuestaLegislativa(propuestaLegislativa + "."));
                            }
                        }
                    }
                }
                else if (eleccion == "5")
                {
                    Console.Clear();
                    Console.WriteLine("\n\tLlamar a legislador a votar.\n");
                    Console.WriteLine("\tIngrese numero del despacho del legislador  \n");
                    input = Console.ReadLine();
                    while (true)
                    {
                        if (!string.IsNullOrWhiteSpace(input) && int.TryParse(input, out numDespachoVotar))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\n\tLa entrada no es un número válido o ingresó letras , por favor ingrese un número correcto.");
                            Console.WriteLine("\n\tIngrese el numero de despacho      :        (1 a 129) ");
                            input = Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    int verificarContador = 0;
                    foreach (var legislador in parlamento.getListaLegislador())
                    {
                        if (legislador.getnumDespacho() == numDespachoVotar)
                        {
                            Console.WriteLine("\n\tVota a favor presione \t\t-1)\n\tVota en contra presione \t-2)\n\tVota Abstenerse \t\t-3)\n");
                            string votolegislador = Console.ReadLine();
                            while (votolegislador != "1" && votolegislador != "2" && votolegislador != "3")
                            {
                                Console.WriteLine("\n\tTiene que seleccionar entre 1 - 2 - 3 ");
                                Console.WriteLine("\n\tVota a favor presione \t\t-1)\n\tVota en contra presione \t-2)\n\tVota Abstenerse \t\t-3)\n");
                                votolegislador = Console.ReadLine();
                            }
                            if (votolegislador == "1")
                            {
                                if (legislador.getcamara() == "Camara de Senadores")
                                {
                                    Console.WriteLine("\n\tEl voto del Senador " + legislador.getapellido() + " es : es a favor.");
                                    Console.WriteLine("\n\tPresione enter para continuar");
                                    Console.Read();
                                }
                                else if (legislador.getcamara() == "Camara de Diputados")
                                {
                                    Console.WriteLine("\n\tEl voto del Diputado " + legislador.getapellido() + " es : es a favor.");
                                    Console.WriteLine("\n\tPresione enter para continuar");
                                    Console.Read();
                                }
                                contadoraFavor++;
                            }
                            else if (votolegislador == "2")
                            {
                                if (legislador.getcamara() == "Camara de Senadores")
                                {
                                    Console.WriteLine("El voto del Senador " + legislador.getapellido() + " es : es en contra.");
                                    Console.WriteLine("\n\tPresione enter para continuar");
                                    Console.Read();
                                }
                                else if (legislador.getcamara() == "Camara de Diputados")
                                {
                                    Console.WriteLine("El voto del Diputado " + legislador.getapellido() + " es : es en contra.");
                                    Console.WriteLine("\n\tPresione enter para continuar");
                                    Console.Read();
                                }
                                contadorEnContra++;
                            }
                            else if (votolegislador == "3")
                            {
                                Console.WriteLine($"El legislador {legislador.getapellido()} se  abstiene");
                                Console.WriteLine("\n\tPresione enter para continuar");
                                Console.Read();
                                contadorAbstenerse++;
                            }
                            verificarContador++;
                        }
                    }
                    if (verificarContador == 0)
                    {
                        Console.WriteLine($"\n\tNo hay legislador asignado a este despacho {numDespachoVotar}");
                        Console.ReadLine();
                        verificarContador = 0;
                    }
                }
                else if (eleccion == "6")
                {
                    Console.WriteLine($"\n\tAl momento la votacion es : \n\t\t\t\tVotos a favor \t: {contadoraFavor}\n\t\t\t\tVotos en contra : {contadorEnContra}\n\t\t\t\tSe abstienen \t: {contadorAbstenerse}");
                    Console.ReadLine();
                }
                else if (eleccion == "7")
                {
                    Console.Clear();
                    int numDespachoDebate = 0;
                    Console.WriteLine("debate");
                    Console.WriteLine("\n\tLlamar a legislador a debatir la propuesta.\n");
                    Console.WriteLine("\tIngrese numero del despacho del legislador  \n");
                    input = Console.ReadLine();
                    while (true)
                    {
                        if (!string.IsNullOrWhiteSpace(input) && int.TryParse(input, out numDespachoDebate))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\n\tLa entrada no es un número válido o ingresó letras , por favor ingrese un número correcto.");
                            Console.WriteLine("\n\tIngrese el numero de despacho      :        (1 a 129) ");
                            input = Console.ReadLine();
                            Console.Clear();
                        }
                    }                    
                    foreach (var legislador in parlamento.getListaLegislador())
                    {
                        if (legislador.getnumDespacho() == numDespachoDebate)
                        {                            
                            if (legislador.getcamara() == "Camara de Senadores")
                            {                                
                                string debateLegislador = "";
                                Console.WriteLine("\n\t" + legislador.participarDebate(debateLegislador) + legislador.getapellido() + " participa del debate.");
                                Console.WriteLine("\n\n\tPresione enter para continuar . . ");
                                Console.ReadLine();
                            }
                            else if (legislador.getcamara() == "Camara de Diputados")
                            {
                                string debateLegislador = "";
                                Console.WriteLine("\n\t" + legislador.participarDebate(debateLegislador) + legislador.getapellido() + " participa del debate.");
                                Console.WriteLine("\n\n\tPresione enter para continuar . . ");
                                Console.ReadLine();
                            }
                        }
                    }
                }
                else if (eleccion == "8")
                {
                    break;
                }
               // contadorLegislador++;
                Console.Clear();
                Console.WriteLine("\n\tSeleccione accion a realizar: \n\n\t\t\t\t\t1) Agregar Legislador. \n\n\t\t\t\t\t2) Listar camaras.\n\n\t\t\t\t\t3) Ver la cantidad de legisladores registrados. \n\n\t\t\t\t\t4) Agregar propuesta Legislativa. \n\n\t\t\t\t\t5) Votar. \n\n\t\t\t\t\t6) Ver votacion. \n\n\t\t\t\t\t7) Debate.\n\n\t\t\t\t\t8) Salir del programa.");
                eleccion = Console.ReadLine();
                while (eleccion != "1" && eleccion != "2" && eleccion != "3" && eleccion != "4" && eleccion != "5" && eleccion != "6" && eleccion != "7" && eleccion != "8")
                {
                    Console.Clear();
                    Console.WriteLine("\n\tSeleccione accion a realizar: \n\n\t\t\t\t\t1) Agregar Legislador. \n\n\t\t\t\t\t2) Listar camaras.\n\n\t\t\t\t\t3) Ver la cantidad de legisladores registrados. \n\n\t\t\t\t\t4) Agregar propuesta Legislativa. \n\n\t\t\t\t\t5) Votar. \n\n\t\t\t\t\t6) Ver votacion. \n\n\t\t\t\t\t7) Debate.\n\n\t\t\t\t\t8) Salir del programa.");
                    Console.Write("\n\tPor favor seleccione entre 1 y 7. . ");
                    eleccion = Console.ReadLine();
                }
            }
        }
    }
}


