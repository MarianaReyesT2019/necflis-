using System;

namespace necflis
{
    class Program
    {
         static void Main(string[] args)
        {
            Clientela[] lista = new Clientela[15];
            Clientela usuario = new Clientela(null,null,0);
            Peliculas[] lista2 = new Peliculas[15];
            Peliculas peliculas = new Peliculas(null,null,null,null);
            registro registro1 = new registro(null);
            registro registro = new registro(null,null);
            registro[] lista3 = new registro[30];
            string[] listaprueba = new string[10];
            int contador = 0;          
            int origen = 0;
            int operacion = 0;
            int numero = 1 ;
            int valor = 0;
            int contar = 0;
            int num = 1;
            int suma = 0;
            System.Console.WriteLine("------🎥BIENVENIDO a Necflis🎥------");
            while(origen!=3){
            System.Console.WriteLine("|||||||||||||||||||||||||||||||||||||");
            System.Console.WriteLine("***Selecciona una opcion***");
            System.Console.WriteLine("1. Seccion Clientes");
            System.Console.WriteLine("2. Seccion Peliculas📼");
            System.Console.WriteLine("3. Salir");
            System.Console.WriteLine("||||||||||||||||||||||||||||||||||||||");
            origen=Convert.ToInt32(Console.ReadLine());
            
                if(origen==1){
                    while(operacion!=4){
                        System.Console.WriteLine("------ Area de Usuarios 🗣 ------");
                        System.Console.WriteLine("Seleccione un numero de la funcion que quiere realizar");
                        System.Console.WriteLine("1. Ver Listado ");
                        System.Console.WriteLine("2. Registrar Clientes ");
                        System.Console.WriteLine("3. Selecionar Cliente");
                        System.Console.WriteLine("4. Salir");
                        

                        operacion=Convert.ToInt32(Console.ReadLine());
                        switch(operacion){
                            case 1: 
                                if (contador ==0)
                                {
                                    System.Console.WriteLine(" ");
                                    System.Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||");
                                    System.Console.WriteLine("⚠︎⚠︎⚠︎⚠︎NO SE HA REGISTRADO NINGUN CLIENTE⚠︎⚠︎⚠︎⚠");
                                    System.Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||");
                                    System.Console.WriteLine(" ");
                                }  
                                else{
                                System.Console.WriteLine("*******************************");
                                System.Console.WriteLine("      Listado de Usuarios       ");
                    
                                for (int i = 0; i < contador; i++)
                                {
                                    usuario = lista[i];
                                    System.Console.WriteLine("["+numero +"]. " + usuario.nombre);
                                    numero++;
                                }
                                numero= 1;
                                }
                            break;
                            case 2:
                                usuario = new Clientela();
                                lista[contador] = usuario;
                                contador++;      
                                System.Console.WriteLine("*******************************");
                                System.Console.WriteLine("      Lista de Usuarios");
                    
                                for (int i = 0; i < contador; i++)
                                {
                                    usuario = lista[i];
                                    System.Console.WriteLine("["+numero +"]. " + usuario.nombre);
                                    numero++;
                                }
                                numero= 1;            
                            break;

                            case 3:
                                if(contador==0){
                                    System.Console.WriteLine(" ");
                                    System.Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||");
                                    System.Console.WriteLine("⚠︎⚠︎⚠︎⚠︎NO SE HA REGISTRADO NINGUN CLIENTE⚠︎⚠︎⚠︎⚠");
                                    System.Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||");
                                    System.Console.WriteLine(" ");
                                }
                                else{
                                System.Console.WriteLine("*******************************");
                                System.Console.WriteLine("      Listado de Usuarios       ");
                    
                                for (int i = 0; i < contador; i++)
                                {
                                    usuario = lista[i];
                                    System.Console.WriteLine("["+numero +"]. " + usuario.nombre);
                                    numero++;
                                }
                                numero= 1;
                                System.Console.WriteLine("*******************************");
                                System.Console.WriteLine("Ingrese el numero de Cliente ");
                                int valor1 = Int32.Parse(Console.ReadLine());
                                Clientela usuario1 = lista[valor1 -1];
                                System.Console.WriteLine("------Informacion General------");
                                System.Console.WriteLine(" ");
                                System.Console.WriteLine("Nombre: "+ usuario1.nombre);
                                System.Console.WriteLine("Direccion: " + usuario1.direccion);
                                System.Console.WriteLine("Edad: " + usuario1.edad);
                                System.Console.WriteLine("***********************************");

                                while(true){
                                System.Console.WriteLine("****************************");
                                System.Console.WriteLine("Seleccione un numero de la funcion que quiere realizar");
                                System.Console.WriteLine("1. Playlist");
                                System.Console.WriteLine("2. Agregar pelicula");
                                System.Console.WriteLine("3. Atras");
                                System.Console.WriteLine("*****************************");
                                int indice = Int32.Parse(Console.ReadLine());
                                
                                if (indice ==1){

                                    string nombre =registro1.nombre_usuario;
                                    string nombre2 =usuario1.nombre;
                                    if(nombre == nombre2){
                                        System.Console.WriteLine("------Listado en su playlist------");
                                        for (int j = 0; j < registro.contador; j++)
                                            {
                                                string valor2 = registro1.lista[j];
                                                System.Console.WriteLine(num +" " +valor2);
                                                num++;
                                            }
                                            System.Console.WriteLine("|||||||||||||||||||||||||||||||||||");
                                        }
                                    else{
                                        System.Console.WriteLine(" ");
                                        System.Console.WriteLine("*****************************************");
                                        System.Console.WriteLine("Aun no tiene peliculas en su PlayList ");
                                        System.Console.WriteLine(" ");
                                    }

                                    

                                    num = 1;
                                    
                                    
                                }
                                if (indice ==2){
                                    if(contar ==0){
                                        System.Console.WriteLine(" ");
                                        System.Console.WriteLine("*******************************");
                                        System.Console.WriteLine("No se ha registrado ninguna pelicula :(");
                                        System.Console.WriteLine(" ");
                                    }
                                    else{
                                    while(true){
                                    System.Console.WriteLine("*******************************");
                                    System.Console.WriteLine("     📼Listado de Peliculas📼    ");

                
                                    for (int i = 0; i < contar; i++)
                                    {
                                        peliculas = lista2[i];
                                        System.Console.WriteLine( num +" " + peliculas.nombre);
                                        num++;
                                    }
                                    num = 1;
                                    System.Console.WriteLine("Seleccione la pelicula que desea agregar");
                                    int selec = Int32.Parse(Console.ReadLine());
                                    if(selec==0){

                                        registro1 = new registro(usuario1.nombre,listaprueba);
                                        registro.peliculas_usuario = "";
                                        break;
                                        
                                    }
                                    else{
                                       
                                        peliculas = lista2[selec-1];
                                        string peli = peliculas.nombre;
                                        
                                        
                                         
                                        registro =new registro(peli);
                                        lista3[suma] = registro;
                                        suma++;

                                    }

                                    for (int i = 0; i < suma; i++)
                                    {
                                        registro=lista3[i];
                                        listaprueba[i] = registro.peliculas_usuario;
                                    }



                                    }
                                    }
                                }
                                if (indice ==3){
                                    break;
                                }
                                else{
                                    System.Console.WriteLine("Seleccione uno de los vallores...");
                                }
                                }
                                }


                            break; 
                            case 4:
                                System.Console.WriteLine("Gracias por ingresar");
                            break;                   
                            default:
                                System.Console.WriteLine("Elije una de las opciones...");
                            break;
                            }
                    }

                }
                if(origen ==2){
            
                    while(valor!=3){
                        System.Console.WriteLine("******************************");
                        System.Console.WriteLine("          Peliculas");
                        System.Console.WriteLine("Escoja una de las opciones");
                        System.Console.WriteLine("1. Ver Peliculas");
                        System.Console.WriteLine("2. Agregar Pelicula");
                        System.Console.WriteLine("3. Salir");
                        System.Console.WriteLine("*******************************");

                        valor = Int32.Parse(Console.ReadLine());
                        switch(valor){
                            case 1: 
                            if(contar==0){
                                System.Console.WriteLine(" ");
                                System.Console.WriteLine("******************************");
                                System.Console.WriteLine("No se ha registrado ninguna Pelicula");
                                System.Console.WriteLine(" ");
                            }else{
                            System.Console.WriteLine("*******************************");
                            System.Console.WriteLine("   Lista de peliculas");
                                for (int i = 0; i < contar; i++)
                                {
                                    peliculas = lista2[i];
                                    System.Console.WriteLine( num +" " + peliculas.nombre);
                                    num++;
                                }
                                num = 1;
                            }
                            break;

                            case 2:
                                peliculas = new Peliculas();
                                lista2[contar] = peliculas;
                                contar++; 
                                System.Console.WriteLine("*******************************");
                                System.Console.WriteLine("   Lista de peliculas");
                                for (int i = 0; i < contar; i++)
                                {
                                    peliculas = lista2[i];
                                    System.Console.WriteLine( num +" " + peliculas.nombre);
                                    num++;
                                }
                                num = 1;
                            
                            break;

                            case 3:
                                System.Console.WriteLine("Gracias por Ingresar ");
                            break;
                            default:
                                System.Console.WriteLine("Elije una de las opciones");
                            break;
                        }
                    }
                }
                if(origen == 3){

                    System.Console.WriteLine("Siempre es un gusto atenderte...");

                }
                else{
                    System.Console.WriteLine("Seleccione uno los de los valores...");

                }
                }
                
            }
        }
    }

    class Clientela{
        public string nombre;
        public string direccion;
        public int edad;

        public Clientela(string nombre, string direccion, int edad){
            this.nombre = nombre;
            this.direccion = direccion;
            this.edad = edad;
        }
        public Clientela(){
            System.Console.WriteLine("Ingrese el nombre  del usuario");
            nombre = Console.ReadLine();
                                            
            System.Console.WriteLine("Ingrese la direccion del usuario");
            direccion = Console.ReadLine();

            System.Console.WriteLine("Ingrese la edad del Cliente");
            edad=Convert.ToInt32(Console.ReadLine());
        }
    }
    class Peliculas{
        public string nombre;
        public string tipo;
        public string genero;
        public string sinopsis;
        public Peliculas(string nombre, string tipo, string genero, string sinopsis){
            this.nombre = nombre;
            this.tipo = tipo;
            this.genero = genero;
            this.sinopsis = sinopsis;
        }

        public Peliculas(){
            System.Console.WriteLine("Escriba el nombre de la pelicula");
            nombre = Console.ReadLine();
            System.Console.WriteLine("Escriba el nombre tipo de pelicula");
            System.Console.WriteLine("1. Serie");
            System.Console.WriteLine("2. Pelicula");
            tipo = Console.ReadLine();
            System.Console.WriteLine("Seleccione el genero de la pelicula ");
            System.Console.WriteLine("1. Accion");
            System.Console.WriteLine("2. Comedia");
            System.Console.WriteLine("3. Ciencia Ficcion");
            System.Console.WriteLine("4. Suspenso");
            genero =Console.ReadLine();
            System.Console.WriteLine("Escriba la sinopsis de la pelicula");
            sinopsis = Console.ReadLine();

        }
    }

    class registro
    {

        public static int contador = 0;
        public string nombre_usuario;

        public string peliculas_usuario;

        public string[] lista;

        
        public registro(string peliculas_usuario)
        {
            
            this.peliculas_usuario =  peliculas_usuario; 
            contador++; 
            
        }

        public registro(string nombre_usuario,string[] lista){
            this.nombre_usuario = nombre_usuario;
        this.lista = lista;
        }
    }    

       
    
   
     

        

