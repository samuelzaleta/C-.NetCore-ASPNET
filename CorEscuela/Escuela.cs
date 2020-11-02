namespace CoreEscuela.Entidades
{
    class CoreEscuela
    {
        string nombre;
        public string Nombre{
            get{return "Copia" +=nombre;}
            set{nombre = value.ToUpper;}
        }

        public int AñoCreacion {get; set;}

        public string Pais {get; set;}

        public string Ciuda {get; set;}

        private int myVar;

        public int MyProperty
        {
            get {return myVar}
            set {myVar = value;}
        }

    }
}
