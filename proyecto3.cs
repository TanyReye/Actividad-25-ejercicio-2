/*Sistema 3: Sistema de Cajero Automático Simulado 
El programa simula operaciones básicas de un cajero. 
Menú 
1. Consultar saldo 
2. Depositar dinero 
3. Retirar dinero 
4. Salir 
Saldo inicial: 
1000 
Reglas 
• No permitir retirar más dinero del saldo disponible. 
• Si el retiro es mayor a 500, mostrar mensaje de seguridad. 
• Usar switch para las opciones del menú. */

double saldo = 1000;
int opcion;
double retiro;
double deposito;


do
{
    Console.WriteLine("MENU");
    Console.WriteLine("1.Consultar saldo");
    Console.WriteLine("2.Depositar dinero");
    Console.WriteLine("3.Retirar dinero");
    Console.WriteLine("4.Salir");
    Console.WriteLine("");
    Console.Write("Ingrese una opcion: ");
    opcion = int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:
        Console.WriteLine("Su saldo es: " + saldo);
        break;
        case 2:
        Console.Write("Ingrese cantidad a depositar: ");
        deposito = double.Parse(Console.ReadLine());
        saldo += deposito;
        break;
        case 3:
        Console.Write("Ingrese cantidad a retirar: ");
        retiro = double.Parse(Console.ReadLine());

        if (retiro>saldo)
        {
            Console.WriteLine("No le alcanza para retirar esa cantidad");
        }
        else
        {
            saldo -= retiro;
        }
        break;
        
    }
     Console.WriteLine("");
} while (opcion !=4);