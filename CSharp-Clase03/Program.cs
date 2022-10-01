using CSharp_Clase03;

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Cliente obj = new Cliente();
obj.NombreCompleto = "Juan C";
obj.Direccion = "ghfhg hjgh jhgj jhg";
obj.Email = "juan@mail.com";
obj.EsNuevo = true;
obj.Telefono = "+51 456 767 345";

Console.WriteLine(obj);