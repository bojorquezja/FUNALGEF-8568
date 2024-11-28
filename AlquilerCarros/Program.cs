

byte opcion;

int respuesta;

int posicion = 0;

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

do

{



    Console.WriteLine("\n**MENU**");

    Console.WriteLine("CREAR [1]: ");

    Console.WriteLine("LISTAR [2]: ");

    Console.WriteLine("MODIFICAR [3]: ");

    Console.WriteLine("FIN [0]: ");

    Console.WriteLine("Ingrese opcion: ");

    while (!byte.TryParse(Console.ReadLine(), out opcion) || opcion > 3)

    {

        Console.WriteLine("Error: Ingrese valor: ");

    }

    Console.Clear();
    Console.Clear();



    switch (opcion)

    {

        case 1:
            for (int i = 0; i < posicion; i++)
                Console.WriteLine("\ncarro " + arreglocarro[i] +"\ncliente: " + arreglocliente[i] + "\nPrecio:"+ arregloprecio[i]+ " "); 

            break;

        case 2:
            for (int i = 0; i < posicion; i++)
                Console.WriteLine("\nplaca " + arregloplaca[i] + "\nmarca: " + arreglomarca[i] + "\nPrecioalquiler:" + arregloprecioalquiler[i] + " ");

            break;



        case 3:
            for (int i = 0; i < posicion; i++)
                Console.WriteLine("\ndni " + arreglodni[i] + "\nNombre: " + arreglonombre[i] + "\nPagoMaximo:" + arreglopagomaximo[i] + " ");

            break;

    }

} while (opcion != 4);
