using System;

namespace CoreEscuela
{

    class CoreEscuela
    {
        public String nombreEscuela;
        public String direccion;
        public int añoFundacion;
        public void Timbrar()
        {
            //do
            Console.Beep(20000,3000);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var miEscuela2 = new CoreEscuela();
            miEscuela2.nombreEscuela = "Platzi";
            miEscuela2.direccion= "El rio";
            miEscuela2.añoFundacion= 1999;
            miEscuela2.Timbrar();
            Console.WriteLine("Timbrando");
            //Console.WriteLine("Hello World!");
        }
    }
}
