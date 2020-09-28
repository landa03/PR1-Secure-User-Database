using System;

namespace PR1___Secure_User_Database
{
    class Program
    {
        public static Queue name = new Queue();
        public static Queueint id1 = new Queueint();
        public static Queueint id2 = new Queueint();
        public static Queueint id3 = new Queueint();
        public static Queueint id4 = new Queueint();
        public static Queueint id5 = new Queueint();
        public static Queueint id6 = new Queueint();
        public static Queueint id7 = new Queueint();
        public static Queueint id8 = new Queueint();
        public static Queueint id9 = new Queueint();
        public static Queueint id10 = new Queueint();
        static void Rejistrar()
        {
            System.Console.WriteLine("Rejistrar ha sido seleccionado");
            System.Console.WriteLine("Escriva el nombre del usuario");
            name.Enqueue(Convert.ToString( Console.ReadLine()));
            System.Console.WriteLine("Escriva el numero de identificacion");
            
            id1.Enqueue(Convert.ToInt32( Console.ReadLine()));
            id2.Enqueue(Convert.ToInt32( Console.ReadLine()));
            id3.Enqueue(Convert.ToInt32( Console.ReadLine()));
            id4.Enqueue(Convert.ToInt32( Console.ReadLine()));
            id5.Enqueue(Convert.ToInt32( Console.ReadLine()));
            id6.Enqueue(Convert.ToInt32( Console.ReadLine()));
            id7.Enqueue(Convert.ToInt32( Console.ReadLine()));
            id8.Enqueue(Convert.ToInt32( Console.ReadLine()));
            id9.Enqueue(Convert.ToInt32( Console.ReadLine()));
            id10.Enqueue(Convert.ToInt32( Console.ReadLine()));
            System.Console.WriteLine("Escriva la clave numerica");
            Convert.ToInt32( Console.ReadLine());
            Menu1();
            
        }
        static void Consultar()
        {
            name.Print();
            id1.Print();
            id2.Print();
            id3.Print();
            id4.Print();
            id5.Print();
            id6.Print();
            id7.Print();
            id8.Print();
            id9.Print();
            id10.Print();
            Menu1();
        }
        public static void Menu1()
        {
            System.Console.WriteLine("Seleccione una opcion");
            System.Console.WriteLine("1: Rejistrar usuario");
            System.Console.WriteLine("2: Consultar lista de usuarios");
            char seleccion = Convert.ToChar( Console.ReadLine());
            switch (seleccion)
            {
                case '1': Rejistrar();
                break;
                case '2': Consultar();
                break;
                default:
                    System.Console.WriteLine("Opcion invalida");
                    break;
           }
        }
        static void Main(string[] args)
        {   
            Menu1();
        }
    }
}
//no importa cuanto me esfuerso nada cambia, sigo siendo igual, triste e incapas,lamento no poder terminar el proyecto, pero es muy difisil azer cosas cuando todo parese estar dise;ado para deprimirme, muy probablemente me de un a;o de descanso despues del proximo semestre para atender mis problemas de salud mental.