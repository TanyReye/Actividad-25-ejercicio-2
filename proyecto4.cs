/*Sistema 4: Sistema de Análisis de Texto 
El programa analiza una frase ingresada por el usuario. 
Menú 
1. Contar caracteres 
2. Contar vocales 
3. Mostrar frase en mayúsculas 
4. Mostrar frase en minúsculas 
5. Salir 
Reglas 
El programa debe: 
• Pedir una frase 
• Recorrerla usando ciclos 
• Contar vocales usando condicionales */

Console.Write("Ingrese una frase: ");
string frase = Console.ReadLine();
int opcion;

do
{

    Console.WriteLine("MENU");
    Console.WriteLine("1.Contar caracteres");
    Console.WriteLine("2.Contar vocales");
    Console.WriteLine("3.Mostrar frase en mayúsculas");
    Console.WriteLine("4.Mostrar frase en minusculas");
    Console.WriteLine("5.Salir");
    Console.WriteLine("");
    Console.Write("Ingrese una opcion: ");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
        Console.WriteLine("Cantidad de caracteres: " + frase.Length);
        break;
        
        case 2:
        int vocales=0;
        string texto = frase.ToLower();
        for (int i = 0; i < texto.Length; i++)
        {
            if (texto[i] == 'a' || texto[i] == 'e' || texto[i] == 'i' || texto[i] == 'o' || texto[i] == 'u')
            {
                vocales++;
            }
        }
        Console.WriteLine("Cantidad de vocales: " + vocales);

        break;

        case 3:
        Console.WriteLine("En mayusculas: " + frase.ToUpper());
        break;

        case 4:
        Console.WriteLine("En minusculas: " + frase.ToLower());
        break;
    }
} while (opcion != 5);