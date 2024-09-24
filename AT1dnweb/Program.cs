namespace AT1dnweb
{
    internal class Program
    {
        public delegate int DelegateCalcula(int x, int y);


        static void Main(string[] args)
        {
            Console.WriteLine("--------- PROGRAMA CALCULA SOMA / SUBTRAÇÃO / MULTIPLICAÇÃO ---------");
            Console.Write("Digite um número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite outro número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite: \n1 - Somar\n2 - Subtrair\n3 - Multiplicar\nDigite aqui:");
            int numeroDigitado = int.Parse(Console.ReadLine());

            DelegateCalcula delegateCalcula = null;

            switch (numeroDigitado)
            {
                case 1:
                    delegateCalcula = Somar;
                    break;
                case 2:
                    delegateCalcula = Subtrair;
                    break;
                case 3:
                    delegateCalcula = Multiplicar;
                    break;
                default:
                    Console.WriteLine("Digite de 1 a 3.");
                    return;
            }


            int resultado = delegateCalcula(num1, num2);
            Console.WriteLine("Resultado = " + resultado);
        }

        public static int Somar(int x, int y)
        {
            return x + y;
        }
        public static int Subtrair(int x, int y)
        {
            return x - y;
        }
        public static int Multiplicar(int x, int y)
        {
            return x * y;
        }
    }
}
