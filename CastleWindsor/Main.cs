﻿namespace CastleWindsor
{
    public class Persona
    {
        private INombre _nombre;
        private IApellido _apellido;

        public Persona(INombre nombre, IApellido apellido)
        {
            _nombre = nombre;
            _apellido = apellido;

        }
        public string NombreCompleto()
        {
            _nombre.PrimerNombre = "David";
            _apellido.PrimerApellido = "Costa";
            return string.Format("{1} {0}", _nombre.PrimerNombre, _apellido.PrimerApellido);
        }
    }
}