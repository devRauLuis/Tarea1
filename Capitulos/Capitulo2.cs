namespace Capitulos

{
    public class Capitulo2
    {

        public static void Ejercicio1()
        {
            Console.WriteLine("Bienvenido al programa para calcular el perimetro de un poligono regular!");
            Console.WriteLine("Ingrese el total del lados: ");
            double n;
            double.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("Ingrese el valor del lado: ");
            double l;
            double.TryParse(Console.ReadLine(), out l);
            Console.WriteLine($"El perimetro del poligono regular es: {(n * l):N2}");
        }
        // 1° × π/180
        public static void Ejercicio3()
        {
            Console.WriteLine("Bienvenido al programa para convertir grados a radianes!");
            Console.WriteLine("Ingrese los grados: ");
            double grados;
            double.TryParse(Console.ReadLine(), out grados);
            Console.WriteLine($"Los grados en radianes son: {(grados * Math.PI / 180):N2}rad");
        }

        public static void Ejercicio4()
        {

            Console.WriteLine("Bienvenido al programa para convertir Celsius a Fahrenheit!");
            Console.WriteLine("Ingrese los grados Celsius: ");
            double celsius;
            double.TryParse(Console.ReadLine(), out celsius);
            Console.WriteLine($"Los grados Fahrenheit son: {(celsius * 9 / 5 + 32):N2}");
        }

        public static void Ejercicio5()
        {
            Console.WriteLine("Bienvenido al programa para convertir euros a dolares y viceversa!");

            Console.WriteLine("Elija una opcion: ");
            Console.WriteLine("1. Convertir dolares a euros");
            Console.WriteLine("2. Convertir euros a dolares");
            int opcion;
            int.TryParse(Console.ReadLine(), out opcion);
            if (opcion == 1)
                ConvertirEuros();
            else if (opcion == 2)
                ConvertirDolares();
        }

        private static void ConvertirDolares()
        {

            Console.WriteLine("Ingrese los dolares: ");
            double dolares;
            double.TryParse(Console.ReadLine(), out dolares);
            Console.WriteLine("Ingrese la tasa: ");
            double tasa;
            double.TryParse(Console.ReadLine(), out tasa);
            Console.WriteLine($"El total en euros es: {(dolares * tasa):N2}");
        }

        private static void ConvertirEuros()
        {
            Console.WriteLine("Ingrese los euros: ");
            double euros;
            double.TryParse(Console.ReadLine(), out euros);
            Console.WriteLine("Ingrese la tasa de euros del dia de hoy: ");
            double tasa;
            double.TryParse(Console.ReadLine(), out tasa);
            Console.WriteLine($"Los dolares son: {(euros * tasa):N2}");
        }
    }

}

