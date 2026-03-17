Console.WriteLine("Sistema de registro de usuario");
//creamos todas las variables
int opcion = 0;
int edad = 0;
string correo = string.Empty;
string nombre = string.Empty;
int tipo_usuario = 0;
string tipo_usuario_texto = string.Empty;
int validacion = 1;
string mayoria_edad = string.Empty;
string buscar = string.Empty;
do
{
    Console.WriteLine("1. Registrar usuario");
    Console.WriteLine("2. Mostrar usuario registrado");
    Console.WriteLine("3. Buscar usuario por nombre");
    Console.WriteLine("4. Salir");
    opcion = int.Parse(Console.ReadLine());
    //vemos que opcion elige el usuario
    switch (opcion)
    {
        //en caso que escoja la primera opcion
        case 1:
            //hacemos un bucle hasta que el error este bien ingresado
            do
            {
                Console.Write("Ingrese su nomre:");
                nombre = Console.ReadLine();
                //si el nombre no esta bien colocado se repite
                if (nombre.Length < 3)
                {
                    Console.WriteLine("Error Nombre incompleto.");
                }
                else
                {
                    validacion = 0;
                }
            }
            while (validacion == 1);
            validacion = 1;
            Console.Write("Ingrese su edad:");
            edad = int.Parse(Console.ReadLine());
            if (edad < 18)
            {
                mayoria_edad = ("Menor de edad");
                Console.WriteLine(mayoria_edad);
            }
            else
            {
                mayoria_edad = ("Mayor de edad");
                Console.WriteLine(mayoria_edad);
            }
            do
            {
                Console.Write("Ingrese su correo electronico:");
                correo = Console.ReadLine();
                //verificamos que el correo contenga @
                if (correo.Contains("@"))
                {
                    validacion = 0;
                }
                else
                {
                    //si no contiene @ preguntamos al usuario si desea ingresar otro correo
                    Console.WriteLine("Error correo electronico no contiene @");
                    Console.WriteLine("¿Desea ingresar un nuevo correo?");
                    string desicion = Console.ReadLine();
                    desicion = desicion.Trim();
                    desicion = desicion.ToLower();
                    //dependiendo de la respuesta repetimos el proceso o continuamos
                    if (desicion.Contains("si"))
                    {
                        validacion = 1;
                    }
                    else
                    {
                        validacion = 0;
                    }
                }
            }
            while (validacion == 1);
            validacion = 1;
            //mostramos el menu con los tipos de usuario
            Console.WriteLine("1. Administrador");
            Console.WriteLine("2. Cliente");
            Console.WriteLine("3. Invitado");
            Console.Write("Escoja el tipo de usuario:");
            tipo_usuario = int.Parse(Console.ReadLine());
            //dependiendo del escojido asi se registrara
            switch (tipo_usuario)
            {
                case 1:
                    tipo_usuario_texto = ("Administrativo");
                    break;
                case 2:
                    tipo_usuario_texto = ("Cliente");
                    break;
                case 3:
                    tipo_usuario_texto = ("Invitado");
                    break;
            }
                break;
        case 2:
            //mostramos los datos del usuario registrado
            Console.WriteLine("Usuario registrado:");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Correo Electronico: " + correo);
            Console.WriteLine("Tipo de Usuario: " + tipo_usuario_texto);
            break;
        case 3:
            //pedimos que el usuario ingrese el nombre y lo comparamos
            Console.Write("Ingrese nombre del usuario:");
            buscar = Console.ReadLine();
            //si existe mostramos la informacion y si no mostramos que no existe
            if (nombre.Contains(buscar))
            {
                Console.WriteLine("Correo: " + correo);
                Console.WriteLine("Edad: " + edad);
                Console.WriteLine("Tipo de Usuario: " + tipo_usuario_texto);
            }
            else
            {
                Console.WriteLine("Usuario inexistente");
            }
            break;
        case 4:
            break;
        default: Console.WriteLine("Ninguna opcion escojida"); break;
    }
}
while (opcion != 4);
Console.Write("Usuarios registrados");