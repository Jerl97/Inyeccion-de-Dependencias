using System;

namespace Ninject1
{
    public class Libreria : ILibrero
    {

        public string InstertarLibro()
        {
            string libro = "Se Ingreso un libro ";
            Console.WriteLine(libro);
            return libro;
        }


    }
}
