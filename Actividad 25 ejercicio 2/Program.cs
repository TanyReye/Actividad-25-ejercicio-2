//creamos las variables
int opciones = 0;
string nombre = string.Empty;
int edad = 0;
string correo  = string.Empty;
string tipo_usuario = string.Empty;

//mostramos el menu
do
{
    Console.WriteLine("1. Registrar usuario");
    Console.WriteLine("2. Mostrar usuarios registrados");
    Console.WriteLine("3. Buscar usuario por nombre");
    Console.WriteLine("4. Salir");
    switch (opciones)
    {
        case 1:
            {
                //borramos cualquier residuo del anterior registo
                nombre = string.Empty;
                edad = 0;
                correo = string.Empty;
                tipo_usuario = string.Empty;
                Console.Write("Ingrese su nombre:");
                nombre = Console.ReadLine();
                //comprobamos cada validacion solicitada
                if ( nombre.Length < 3)
                {
                    Console.WriteLine("Error nombre invalido");
                }
                else
                {
                    Console.Write("Ingrese su Edad:");
                    edad = int.Parse(Console.ReadLine());
                    if(edad < 18)
                    {
                        Console.WriteLine("Usted es menor de edad");
                    }
                    else if (edad>18)
                    {
                        Console.WriteLine("Usted es mayor de edad");
                        Console.Write("Ingrese su correo:");
                        correo = Console.ReadLine();
                        for (int i = 0; i < 5; i++)
                             {
                                 if (correo.Contains("@"))
                                 {
                                    i = 5;
                                     for (int j = 0; j < 5; j++)
                                {

                                
                                     Console.Write("Ingrese su tipo de usuario:");
                                     tipo_usuario = Console.ReadLine();
                                     tipo_usuario = tipo_usuario.ToLower();
                                     if (tipo_usuario.Contains("administrador") || tipo_usuario.Contains("cliente") || tipo_usuario.Contains("invitado"))
                                     {
                                        j = 5;
                                      }
                                    else
                                    {
                                    Console.WriteLine("Tipo de usuario no existente");
                                    }
                                }
                            }
                                 else
                                 {
                                     Console.WriteLine("Error, el correo electronico no contiene @");
                                 }
                        }
                    }
                }


            }
            break;
        case 2:
            Console.WriteLine("El nombre de usuario es: ");
            Console.WriteLine(nombre);
            Console.WriteLine("El correo del usuario es: ");
            Console.WriteLine(correo);
            Console.WriteLine("El tipo de usuario es: ");
            Console.WriteLine(tipo_usuario);
            break;
            
        case 3:

        break;
    }
}
while (opciones != 4) ;