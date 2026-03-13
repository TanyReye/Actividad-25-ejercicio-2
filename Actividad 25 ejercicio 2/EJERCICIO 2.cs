int menu = 0;
double nota = 0;
double suma = 0;
double promedio = 0;
string nombre = "";
string curso = "";

do
{
    Console.WriteLine(" "); //espacio para orden :)
    Console.WriteLine("1. Registrar estudiante:");
    Console.WriteLine("2. Calcular promedio:");
    Console.WriteLine("3. Mostrar estado academico:");
    Console.WriteLine("4. Salir:");
    menu = int.Parse(Console.ReadLine());

    switch (menu)
    {
        case 1:

            suma = 0; //variiable suma para sumar las 3 notas que se ingresen

            do
            {
                Console.WriteLine("Ingrese nombre de estudiante: ");
                nombre = Console.ReadLine();

                if (nombre.Contains("0") || nombre.Contains("1") || nombre.Contains("2") || nombre.Contains("3") || nombre.Contains("4") || nombre.Contains("5") || nombre.Contains("6") || nombre.Contains("7") || nombre.Contains("8") || nombre.Contains("9"))
                {
                    Console.WriteLine("ERROR, el nombre contiene números");
                }

            } while (nombre.Contains("0") || nombre.Contains("1") || nombre.Contains("2") || nombre.Contains("3") || nombre.Contains("4") || nombre.Contains("5") || nombre.Contains("6") || nombre.Contains("7") || nombre.Contains("8") || nombre.Contains("9"));

            Console.WriteLine("Ingrese curso: ");
            curso = Console.ReadLine();

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Ingrese la nota " + i + ": ");
                nota = double.Parse(Console.ReadLine());
                suma = suma + nota;
            }

            break;

        case 2:

            promedio = suma / 3;

            if (promedio >= 90 && promedio <= 100)
            {
                Console.WriteLine("Excelente");
            }
            else if (promedio >= 70 && promedio <= 89)
            {
                Console.WriteLine("Aprobado");
            }
            else if (promedio >= 60 && promedio <= 69)
            {
                Console.WriteLine("Recuperacion");
            }
            else if (promedio >= 0 && promedio <= 59);
           
            else if (promedio > 100)
            {
                Console.WriteLine("ERROR");
            }

            break;

        case 3:

            Console.WriteLine("El nombre del estudiante es: " + nombre);
            Console.WriteLine("El promedio del estudiante es: " + promedio);
            Console.WriteLine("El curso es: " + curso);
            break;
    }

} while (menu != 4);

Console.WriteLine("Saliendo...");
