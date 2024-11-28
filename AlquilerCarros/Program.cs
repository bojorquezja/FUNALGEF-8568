
using AlquilerCarros;



byte opcion;



int respuesta;



int posicion = 0;



Carro carro = new Carro();



Alquiler alquiler = new Alquiler();



Cliente cliente = new Cliente();



AlquilerUtil alquilerUtil = new AlquilerUtil();



CarroUtil1 carroUtil1 = new CarroUtil1();



ClienteUtil clienteUtil = new ClienteUtil();

Claseutil util = new Claseutil();



do



{



    Console.Write("Presione [1] para ingresar al aplicativo!: ");



    respuesta = int.Parse(Console.ReadLine());



    Console.Clear();









} while (respuesta <= 0);



int[] arreglonumero = new int[respuesta];

string[] arreglocarro = new string[respuesta];

string[] arreglocliente = new string[respuesta];

double[] arregloprecio = new double[respuesta];

///////////////////////////////////////////////

string[] arregloplaca = new string[respuesta];

string[] arreglomarca = new string[respuesta];

double[] arregloprecioalquiler = new double[respuesta];

//////////////////////////////////////////////////////

int[] arreglodni = new int[respuesta];

string[] arreglonombre = new string[respuesta];

double[] arreglopagomaximo = new double[respuesta];



arreglonumero[posicion] = alquiler.Numero;



arreglocarro[posicion] = alquiler.Carro;



arreglocliente[posicion] = alquiler.Cliente;



arregloprecio[posicion] = alquiler.Precio;



arregloplaca[posicion] = carro.Placa;



arreglomarca[posicion] = carro.Marca;



arregloprecioalquiler[posicion] = carro.PrecioAlquiler;

arreglodni[posicion] = cliente.Dni;



arreglonombre[posicion] = cliente.Nombre;



arreglopagomaximo[posicion] = cliente.PagoMaximo;



do



{







    Console.WriteLine("\n**MENU**");



    Console.WriteLine("OPCION [1]: ");

    Console.WriteLine("OPCION [2]: ");

    Console.WriteLine("OPCION [3]: ");

    Console.WriteLine("ELIMINAR [4]");

    Console.WriteLine("FIN [0]: ");



    Console.WriteLine("Ingrese opcion: ");



    while (!byte.TryParse(Console.ReadLine(), out opcion) || opcion > 3)



    {



        Console.WriteLine("Error: Ingrese valor: ");



    }



    Console.Clear();







    switch (opcion)



    {



        case 1:

            byte opcion1;



            do



            {







                Console.WriteLine("\n**MENU**");



                Console.WriteLine("Crear [1]: ");

                Console.WriteLine("Listar [2]: ");

                Console.WriteLine("FIN [0]: ");



                Console.WriteLine("Ingrese opcion: ");



                while (!byte.TryParse(Console.ReadLine(), out opcion1) || opcion1 > 2)



                {



                    Console.WriteLine("Error: Ingrese valor: ");



                }



                Console.Clear();



                switch (opcion1)

                {

                    case 1:

                        util.crear1(); break;

                    case 2:

                        for (int i = 0; i < posicion; i++)

                            Console.WriteLine("\ncarro " + arreglocarro[i] + "\ncliente: " + arreglocliente[i] + "\nPrecio:" + arregloprecio[i] + " "); break;



                }

            } while (opcion1 != 0);



            break;



        case 2:

            byte opcion12;

            do



            {







                Console.WriteLine("\n**MENU**");



                Console.WriteLine("Crear [1]: ");

                Console.WriteLine("Listar [2]: ");

                Console.WriteLine("FIN [0]: ");



                Console.WriteLine("Ingrese opcion: ");



                while (!byte.TryParse(Console.ReadLine(), out opcion12) || opcion12 > 2)



                {



                    Console.WriteLine("Error: Ingrese valor: ");



                }



                Console.Clear();



                switch (opcion12)

                {

                    case 1:

                        util.crear2(); break;

                    case 2:

                        for (int i = 0; i < posicion; i++)

                            Console.WriteLine("\nplaca " + arregloplaca[i] + "\nmarca: " + arreglomarca[i] + "\nPrecioalquiler:" + arregloprecioalquiler[i] + " ");

                        break;

                }

            } while (opcion12 != 0);









            break;





        case 3:

            byte opcion13;

            do



            {







                Console.WriteLine("\n**MENU**");



                Console.WriteLine("Crear [1]: ");

                Console.WriteLine("Listar [2]: ");

                Console.WriteLine("FIN [0]: ");



                Console.WriteLine("Ingrese opcion: ");



                while (!byte.TryParse(Console.ReadLine(), out opcion13) || opcion13 > 2)



                {



                    Console.WriteLine("Error: Ingrese valor: ");



                }



                Console.Clear();



                switch (opcion13)

                {

                    case 1:

                        util.crear3(); break;

                    case 2:

                        for (int i = 0; i < posicion; i++)

                            Console.WriteLine("\ndni " + arreglodni[i] + "\nNombre: " + arreglonombre[i] + "\nPagoMaximo:" + arreglopagomaximo[i] + " ");

                        break;

                }

            } while (opcion13 != 0);



            break;

        case 4:

            Console.Write("El dato es (numerico) o (letra) o (decimal): ");



            string usuario = Console.ReadLine().Trim().ToLower();



            if (usuario == "numerico")



            {



                Console.WriteLine("Ingresa el dato que Eliminaras: ");



                int eliminar = int.Parse(Console.ReadLine());



                foreach (int i in arreglonumero)



                {



                    if (i == eliminar)



                    {



                        Console.WriteLine("Encontrado correctamente");



                        Console.WriteLine("*");



                        Console.WriteLine("Se eliminara");



                        Console.Write("Ingresa el dato que modificaras: ");



                        int cambio = int.Parse(Console.ReadLine());



                        for (int l = 0; l < respuesta; l++)



                        {



                            if (arreglonumero[l] == eliminar)



                            {



                                arreglonumero[l] = cambio;



                                Console.Write("El cambio fue realizado");



                            }



                        }



                    }



                }



                foreach (int i in arreglodni)



                {



                    if (i == eliminar)



                    {



                        Console.WriteLine("Encontrado correctamente");



                        Console.WriteLine("*");



                        Console.WriteLine("Se eliminara");



                        Console.Write("Ingresa el dato que modificaras: ");



                        int cambio = int.Parse(Console.ReadLine());



                        for (int o = 0; o < respuesta; o++)



                        {



                            if (arreglodni[o] == eliminar)



                            {



                                arreglodni[o] = cambio;



                                Console.Write("El cambio fue realizado");



                            }



                        }







                    }



                }



            }







            if (usuario == "letra")



            {



                Console.Write("Ingresa el dato que deseas eliminar: ");



                string eliminar1 = Console.ReadLine().Trim().ToLower();



                foreach (string r in arreglocarro)



                {







                    if (r == eliminar1)



                    {



                        Console.WriteLine("Encontrado correctamente");



                        Console.WriteLine("*");



                        Console.WriteLine("Se eliminara");



                        Console.Write("Ingresa el dato que modificaras: ");



                        string cambio2 = Console.ReadLine();



                        for (int i = 0; i < respuesta; i++)



                        {



                            if (arreglocarro[i] == eliminar1)



                            {



                                arreglocarro[i] = cambio2;



                                Console.Write("El cambio fue realizado");



                            }



                        }



                    }



                }



                foreach (string r in arreglocliente)



                {







                    if (r == eliminar1)



                    {



                        Console.WriteLine("Encontrado correctamente");



                        Console.WriteLine("*");



                        Console.WriteLine("Se eliminara");



                        Console.Write("Ingresa el dato que modificaras: ");



                        string cambio2 = Console.ReadLine().Trim().ToLower();



                        for (int i = 0; i < respuesta; i++)



                        {



                            if (arreglocliente[i] == eliminar1)



                            {



                                arreglocliente[i] = cambio2;



                                Console.Write("El cambio fue realizado");



                            }



                        }



                    }



                }



                foreach (string r in arregloplaca)



                {







                    if (r == eliminar1)



                    {



                        Console.WriteLine("Encontrado correctamente");



                        Console.WriteLine("*");



                        Console.WriteLine("Se eliminara");



                        Console.Write("Ingresa el dato que modificaras: ");



                        string cambio2 = Console.ReadLine().Trim().ToLower();



                        for (int i = 0; i < respuesta; i++)



                        {



                            if (arregloplaca[i] == eliminar1)



                            {



                                arregloplaca[i] = cambio2;



                                Console.Write("El cambio fue realizado");



                            }



                        }



                    }



                }



                foreach (string r in arreglomarca)



                {







                    if (r == eliminar1)



                    {



                        Console.WriteLine("Encontrado correctamente");



                        Console.WriteLine("*");



                        Console.WriteLine("Se eliminara");



                        Console.Write("Ingresa el dato que modificaras: ");



                        string cambio2 = Console.ReadLine().Trim().ToLower();



                        for (int i = 0; i < respuesta; i++)



                        {



                            if (arreglomarca[i] == eliminar1)



                            {



                                arreglomarca[i] = cambio2;



                                Console.Write("El cambio fue realizado");



                            }



                        }



                    }



                }



                foreach (string r in arreglonombre)



                {







                    if (r == eliminar1)



                    {



                        Console.WriteLine("Encontrado correctamente");



                        Console.WriteLine("*");



                        Console.WriteLine("Se eliminara");



                        Console.Write("Ingresa el dato que modificaras: ");



                        string cambio2 = Console.ReadLine().Trim().ToLower();



                        for (int i = 0; i < respuesta; i++)



                        {



                            if (arreglonombre[i] == eliminar1)



                            {



                                arreglonombre[i] = cambio2;



                                Console.Write("El cambio fue realizado");



                            }



                        }



                    }



                }



            }



            if (usuario == "decimal")



            {







                foreach (double r in arregloprecio)



                {



                    Console.WriteLine("Ingresa el dato que Eliminaras: ");



                    double eliminar = int.Parse(Console.ReadLine());







                    if (r == eliminar)



                    {



                        Console.WriteLine("Encontrado correctamente");



                        Console.WriteLine("*");



                        Console.WriteLine("Se eliminara");



                        Console.Write("Ingresa el dato que modificaras: ");



                        double cambio2 = double.Parse(Console.ReadLine().Trim().ToLower());



                        for (int i = 0; i < respuesta; i++)



                        {



                            if (arregloprecio[i] == eliminar)



                            {



                                arregloprecio[i] = cambio2;



                                Console.Write("El cambio fue realizado");



                            }



                        }



                    }



                }



                foreach (double r in arregloprecioalquiler)



                {



                    Console.WriteLine("Ingresa el dato que Eliminaras: ");



                    double eliminar = int.Parse(Console.ReadLine());







                    if (r == eliminar)



                    {



                        Console.WriteLine("Encontrado correctamente");



                        Console.WriteLine("*");



                        Console.WriteLine("Se eliminara");



                        Console.Write("Ingresa el dato que modificaras: ");



                        double cambio2 = double.Parse(Console.ReadLine().Trim().ToLower());



                        for (int i = 0; i < respuesta; i++)



                        {



                            if (arregloprecioalquiler[i] == eliminar)



                            {



                                arregloprecioalquiler[i] = cambio2;



                                Console.Write("El cambio fue realizado");



                            }



                        }



                    }



                }



                foreach (double r in arreglopagomaximo)



                {



                    Console.WriteLine("Ingresa el dato que Eliminaras: ");



                    double eliminar = int.Parse(Console.ReadLine());







                    if (r == eliminar)



                    {



                        Console.WriteLine("Encontrado correctamente");



                        Console.WriteLine("*");



                        Console.WriteLine("Se eliminara");



                        Console.Write("Ingresa el dato que modificaras: ");



                        double cambio2 = double.Parse(Console.ReadLine().Trim().ToLower());



                        for (int i = 0; i < respuesta; i++)



                        {



                            if (arreglopagomaximo[i] == eliminar)



                            {



                                arreglopagomaximo[i] = cambio2;



                                Console.Write("El cambio fue realizado");



                            }



                        }



                    }



                }







            }















            break;













    }



} while (opcion != 4);