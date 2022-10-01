using System;
namespace CSharp_Clase03
{
    public struct Cliente
    {
        public string NombreCompleto { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public bool EsNuevo { get; set; }

        public override string ToString()
        {
            return $"Nombre: {NombreCompleto} \n" +
                $"Telefono: {Telefono}\n" +
                $"Direccion: {Direccion}\n" +
                $"Email: {Email}\n" +
                $"Cliente Nuevo?: {(EsNuevo? "Si":"No")}";
        }
    }
}

