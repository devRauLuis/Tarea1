namespace Capitulos
{
    public class Capitulo3
    {

        public static void Ejercicio1()
        {

            Console.WriteLine("Bienvenido al programa que te dice si un numero es par o impar!");
            Console.WriteLine("Ingrese un numero: ");
            int numero;
            int.TryParse(Console.ReadLine(), out numero);
            if (numero % 2 == 0)
                Console.WriteLine("Es par!");
            else
                Console.WriteLine("Es impar!");
        }


        public static void Ejercicio5()
        {
            Console.WriteLine("Bienvenido al programa para calcular el area o el perimetro de un poligono regular!");
            Console.WriteLine("Elija una opcion: ");
            Console.WriteLine("1. Area");
            Console.WriteLine("2. Perimetro");
            int opcion;
            int.TryParse(Console.ReadLine(), out opcion);
            if (opcion == 1)
                Area();
            else if (opcion == 2)
                Perimetro();
        }

        private static void Area()
        {
            Console.WriteLine("Ingrese el total de lados: ");
            int n;
            int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("Ingrese el valor del lado: ");
            double l;
            double.TryParse(Console.ReadLine(), out l);
            Console.WriteLine($"El area del poligono regular es: {(n * Math.Pow(l, 2) / (4 * Math.Tan(Math.PI / n))):N2}");
        }

        private static void Perimetro()
        {
            Console.WriteLine("Ingrese el total de lados: ");
            int n;
            int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("Ingrese el valor del lado: ");
            double l;
            double.TryParse(Console.ReadLine(), out l);
            Console.WriteLine($"El perimetro del poligono regular es: {(n * l):N2}");
        }
    }
}